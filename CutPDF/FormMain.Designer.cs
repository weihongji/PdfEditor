
namespace CutPDF
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panelControls = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblPath = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.panelOutput = new System.Windows.Forms.Panel();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
			this.tip = new System.Windows.Forms.ToolTip(this.components);
			this.panelControls.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelControls
			// 
			this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelControls.Controls.Add(this.btnCancel);
			this.panelControls.Controls.Add(this.btnOK);
			this.panelControls.Controls.Add(this.tableLayoutPanel1);
			this.panelControls.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelControls.Location = new System.Drawing.Point(3, 3);
			this.panelControls.Margin = new System.Windows.Forms.Padding(4);
			this.panelControls.Name = "panelControls";
			this.panelControls.Size = new System.Drawing.Size(678, 121);
			this.panelControls.TabIndex = 0;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(380, 68);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(100, 31);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "退出(&X)";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(197, 68);
			this.btnOK.Margin = new System.Windows.Forms.Padding(4);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(100, 31);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "处理(&O)";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
			this.tableLayoutPanel1.Controls.Add(this.lblPath, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.txtPath, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(676, 60);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblPath
			// 
			this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(24, 13);
			this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPath.Name = "lblPath";
			this.lblPath.Padding = new System.Windows.Forms.Padding(0, 9, 0, 0);
			this.lblPath.Size = new System.Drawing.Size(72, 25);
			this.lblPath.TabIndex = 0;
			this.lblPath.Text = "文件路径";
			// 
			// txtPath
			// 
			this.txtPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPath.Location = new System.Drawing.Point(104, 19);
			this.txtPath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(448, 26);
			this.txtPath.TabIndex = 1;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(560, 17);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(100, 31);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "浏览(&B)";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// panelOutput
			// 
			this.panelOutput.Controls.Add(this.txtOutput);
			this.panelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelOutput.Location = new System.Drawing.Point(3, 124);
			this.panelOutput.Margin = new System.Windows.Forms.Padding(4);
			this.panelOutput.Name = "panelOutput";
			this.panelOutput.Size = new System.Drawing.Size(678, 334);
			this.panelOutput.TabIndex = 1;
			// 
			// txtOutput
			// 
			this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
			this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtOutput.Location = new System.Drawing.Point(0, 0);
			this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.ReadOnly = true;
			this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtOutput.Size = new System.Drawing.Size(678, 334);
			this.txtOutput.TabIndex = 0;
			this.txtOutput.WordWrap = false;
			// 
			// FormMain
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.panelOutput);
			this.Controls.Add(this.panelControls);
			this.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(550, 300);
			this.Name = "FormMain";
			this.Padding = new System.Windows.Forms.Padding(3);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "分割 PDF 文件";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.panelControls.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panelOutput.ResumeLayout(false);
			this.panelOutput.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelControls;
		private System.Windows.Forms.Panel panelOutput;
		private System.Windows.Forms.TextBox txtOutput;
		private System.Windows.Forms.FolderBrowserDialog folderBrowser;
		private System.Windows.Forms.ToolTip tip;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnBrowse;
	}
}

