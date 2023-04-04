using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace AgriculturePresentation.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticReport()
        {
            ExcelPackage excelPackage= new ExcelPackage();
            var workBook = excelPackage.Workbook.Worksheets.Add("Dosya 1");

            workBook.Cells[1, 1].Value = "Ürün Adı";
            workBook.Cells[1, 2].Value = "Ürün Kategorisi";
            workBook.Cells[1, 3].Value = "Ürün Fiyat(Taban)";

            workBook.Cells[2, 1].Value = "Web Tasarım";
            workBook.Cells[2, 2].Value = "Web";
            workBook.Cells[2, 3].Value = "4999 ₺";

            workBook.Cells[3, 1].Value = "Windows Uygulaması";
            workBook.Cells[3, 2].Value = "Desktop";
            workBook.Cells[3, 3].Value = "7499 ₺";

            workBook.Cells[4, 1].Value = "Mobil Programlama";
            workBook.Cells[4, 2].Value = "Android";
            workBook.Cells[4, 3].Value = "4999 ₺";

            workBook.Cells[5, 1].Value = "Mobil Programlama";
            workBook.Cells[5, 2].Value = "IOS";
            workBook.Cells[5, 3].Value = "7999 ₺";

            var bytes = excelPackage.GetAsByteArray();
            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","YazılımRaporu.xlsx");
        }
    }
}
