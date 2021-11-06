using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf.Xobject;

namespace CutPDF
{
	class PDFProcessor
	{
		public static void Crop(string src, string dest, float ratio = 0.5f)
		{
			//Initialize PDF document
			PdfDocument pdf = new PdfDocument(new PdfWriter(dest));
			PdfReader reader = new PdfReader(src);
			reader.SetUnethicalReading(true);
			PdfDocument sourcePdf = new PdfDocument(reader);

			int n = sourcePdf.GetNumberOfPages();
			for (int i = 1; i <= n; i++)
			{
				//Original page
				PdfPage origPage = sourcePdf.GetPage(i);
				PdfFormXObject pageCopy = origPage.CopyAsFormXObject(pdf);

				//Original page size
				Rectangle orig = origPage.GetPageSize();

				//Tile size
				Rectangle tileSize = new Rectangle(orig.GetLeft(), orig.GetBottom(), orig.GetWidth() * ratio, orig.GetHeight());

				//The first tile
				PdfPage page = pdf.AddNewPage(new PageSize(tileSize));
				PdfCanvas canvas = new PdfCanvas(page);
				canvas.AddXObjectAt(pageCopy, 0, 0);
			}

			pdf.Close();
			sourcePdf.Close();
		}
	}
}
