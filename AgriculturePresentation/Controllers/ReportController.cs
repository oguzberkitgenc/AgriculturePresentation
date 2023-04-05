using AgriculturePresentation.Models;
using ClosedXML.Excel;
using DataAccesLayer.Contexts;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            ExcelPackage excelPackage = new ExcelPackage();
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
            return File(bytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "YazılımRaporu.xlsx");
        }
        public List<ContactModel> ContactList()
        {
            List<ContactModel> contactModels = new List<ContactModel>();
            using (var context = new AgricultureContext())
            {
                contactModels=context.Contects.Select(x=>new ContactModel
                {
                    ContactID=x.ContactID,
                    ContactName=x.Name,
                    ContactDate=x.Date,
                    ContactMail=x.Mail,
                    ContactMessage=x.Message
                }).ToList();
            }
            return contactModels;
        }
        public IActionResult ContactReport()
        {
            using (var workBook=new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Mesaj Listesi");
                workSheet.Cell(1, 1).Value = "Mesaj ID";
                workSheet.Cell(1, 2).Value = "Mesaj Göndere";
                workSheet.Cell(1, 3).Value = "Mail Adresi";
                workSheet.Cell(1, 4).Value = "Mesaj İceriği";
                workSheet.Cell(1, 5).Value = "Mesaj Tarihi";

                int contactRowCount = 2;
                foreach (var item in ContactList())
                {
                    workSheet.Cell(contactRowCount,1).Value = item.ContactID;
                    workSheet.Cell(contactRowCount,2).Value = item.ContactName;
                    workSheet.Cell(contactRowCount, 3).Value = item.ContactMail;
                    workSheet.Cell(contactRowCount,4).Value= item.ContactMessage;
                    workSheet.Cell(contactRowCount,5).Value= item.ContactDate;
                    contactRowCount++;
                }
                using(var stream=new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content=stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MesajRapor.xlsx");
                }
            }
        }
    }
}
