using Microsoft.AspNetCore.Mvc;
using Tablet.ViewModels;
using Tablet.Data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Tablet.Controllers
{
    public class HomeController : Controller
    {

        private readonly MainModel mainModel;

        public HomeController(MainModel mainModel)
        {
            this.mainModel = mainModel;
        }

        public IConfiguration Configuration { get; }

       [Authorize(Roles = "Admin, User")]
        public IActionResult Index()
        {
            if (HomeViewModel.measurement == null)
                HomeViewModel.measurement = "Трудозатраты";
            var items = mainModel.getGeneralDevelopmentModels();
            mainModel.generalDevelopmentModels = items;

            var secondItems = mainModel.GetStructures();
            mainModel.Structures = secondItems;

            var thirdItem = mainModel.GetInformation();
            InformationModel[] array = thirdItem.ToArray();
            if (array.Length != 0 && array[0].Id.Equals("1"))
            {
                HomeViewModel.measurement = array[0].Information;
            }

            var obj = new HomeViewModel
            {
                mainModel = this.mainModel
            };

            return View(obj);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public RedirectToActionResult ChangeMeasurement(String measurement)
        {
            HomeViewModel.measurement = measurement;
            mainModel.AddToTableInformation(measurement);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult MakePDF()
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream("C:\\Project\\HomePage.pdf", FileMode.Create));
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            

            PdfPCell cell = new PdfPCell(new Phrase("Готовность проекта", font));
            PdfPTable table = new PdfPTable(3);
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Дата", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Прогноз", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Факт", font)));
            table.AddCell(cell);
            var items = mainModel.getGeneralDevelopmentModels();
            if (items != null)
            {
                foreach (var el in items)
                {
                    table.AddCell(new Phrase(el.Date.ToString(), font));
                    table.AddCell(new Phrase(el.Forecast.ToString(), font));
                    table.AddCell(new Phrase(el.Progress.ToString(), font));
                }
            }


            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));

            cell = new PdfPCell(new Phrase("Структура проекта", font));
            table = new PdfPTable(2);
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Наименование", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Проценты", font)));
            table.AddCell(cell);
            var items2 = mainModel.GetStructures();
            if (items2 != null)
            {
                foreach (var el in items2)
                {
                    table.AddCell(new Phrase(el.Name, font));
                    table.AddCell(new Phrase(el.Proportion.ToString(), font));
                }
            }


            doc.Add(table);

            doc.Close();
            return RedirectToAction("Index");
        }

    }
}
