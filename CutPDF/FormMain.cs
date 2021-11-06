using System;
using System.IO;
using System.Windows.Forms;

namespace CutPDF
{
	public partial class FormMain : Form
	{
		private string dest = "";

		public FormMain() {
			InitializeComponent();
		}

		private void FormMain_Load(object sender, EventArgs e) {
			this.txtPath.Text = GetConfigString("src");
			this.dest = GetConfigString("dest");
			if (String.IsNullOrEmpty(dest)) {
				dest = DateTime.Today.ToString("yyyyMMdd");
			}
		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			this.folderBrowser.SelectedPath = this.txtPath.Text;
			if (this.folderBrowser.ShowDialog() == DialogResult.OK) {
				this.txtPath.Text = this.folderBrowser.SelectedPath;
			}
		}

		private void btnOK_Click(object sender, EventArgs e) {
			if (!CheckDir()) {
				return;
			}
			DirectoryInfo dirInfo = new DirectoryInfo(txtPath.Text);
			FileInfo[] files = dirInfo.GetFiles("*.pdf");
			if (files.Length == 0) {
				MessageBox.Show("当前目录下无pdf文件", "无文件", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.txtPath.Focus();
				return;
			}
			string srcDir = txtPath.Text;
			string desDir = getTargetDir();
			Output("");
			Output("新文件将存放在：" + desDir);
			Output("------------------------------------------");
			if (!srcDir.EndsWith(@"\")) {
				srcDir += @"\";
			}
			if (!desDir.EndsWith(@"\")) {
				desDir += @"\";
			}
			foreach (var f in files) {
				PDFProcessor.Crop(srcDir + f.Name, desDir + f.Name);
				Output(f.Name, true);
			}
			Output(files.Length.ToString() + "个文件处理完毕！");
		}

		private void btnCancel_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void Output(string result, bool showTimestamp = false) {
			this.txtOutput.Text += (showTimestamp ? DateTime.Now.ToString("HH:mm:ss") + " " : "") + result + Environment.NewLine;
		}

		private bool CheckDir() {
			String msg = "";

			if (this.txtPath.Text == "") {
				msg = "请指定pdf文件的目录";
			}
			else if (!Directory.Exists(this.txtPath.Text)) {
				msg = "所指定的目录不存在";
			}

			if (msg.Length > 0) {
				MessageBox.Show(msg, "无效目录", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.txtPath.Focus();
				this.txtPath.SelectAll();
				return false;
			}

			return true;
		}

		private string getTargetDir() {
			string target = "";
			if (dest.IndexOf(":") > 0) {
				target = dest;
			}
			else {
				string src = this.txtPath.Text;
				if (src.Length > 0 && dest.Length > 0) {
					target = System.IO.Path.Combine(src, dest);
				}
			}

			if (target.Length == 0) {
				MessageBox.Show("输出目录不能确定", "无效目录", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (!Directory.Exists(target)) {
				Directory.CreateDirectory(target);
			}

			return target;
		}

		private static string GetConfigString(string key, string defaultValue = "") {
			var config = System.Configuration.ConfigurationManager.AppSettings[key];

			if (!string.IsNullOrEmpty(config)) {
				return config;
			}
			return defaultValue;
		}
	}
}
