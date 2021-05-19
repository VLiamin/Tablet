using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tablet.Data.Models;
using Tablet.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Tablet.Controllers
{
    public class ProjectPageController : Controller
    {
        private readonly ProjectPageModel projectPageModel;
        private static String id;
        private static String name;

        public ProjectPageController(ProjectPageModel projectPageModel)
        {
            this.projectPageModel = projectPageModel;
        }


        public ViewResult Index()
        {
            ProjectPageViewModel.projectId = id;

            var items = projectPageModel.getProjectModels(ProjectPageController.id);
            projectPageModel.Project = items;

            var secondItems = projectPageModel.GetProjectProblemsModels();
            projectPageModel.projectProblems = secondItems;

            var thirdItems = projectPageModel.GetProjectStagesModels();
            projectPageModel.Stages = thirdItems;

            var fourthItems = projectPageModel.GetProjectGeneralProblems(ProjectPageController.id);
            projectPageModel.GeneralProblems = fourthItems;

            var fifthItems = projectPageModel.GetProjectGeneralWorks();
            projectPageModel.GeneralWorks = fifthItems;

            var sixthItems = projectPageModel.GetProjectRisks();
            projectPageModel.ProjectRisks = sixthItems;

            var obj = new ProjectPageViewModel
            {
                projectPageModel = this.projectPageModel,

            };
            
            return View(obj);
        }

        public RedirectToActionResult getProjectId(string id)
        {
            ProjectPageController.id = id;
            return RedirectToAction("Index");
        }

        public ViewResult AddProblem()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddProblem(ProjectProblems projectProblems)
        {
            projectPageModel.AddToProjectProblems(projectProblems.Id, id, projectProblems.Problem);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult DeleteProblem(String ID)
        {
            projectPageModel.DeleteProjectProblems(ID, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddStage()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddStage(Stages stages)
        {
            projectPageModel.AddToProjectStage(stages.Id, id, stages.Stage);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult DeleteStage(String ID)
        {
            projectPageModel.DeleteProjectStage(ID, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddGeneralProblem()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddGeneralProblem(ProjectGeneralProblems projectGeneralProblems)
        {
            projectPageModel.AddToProjectGeneralProblems(projectGeneralProblems.Description, projectGeneralProblems.Date, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddGeneralWorks()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddGeneralWorks(ProjectGeneralWorks projectGeneralWorks)
        {
            projectPageModel.AddToProjectGeneralWorks(projectGeneralWorks.Description, projectGeneralWorks.Date,
                projectGeneralWorks.RedLine,  projectGeneralWorks.Responsible, projectGeneralWorks.Persent, id);
            return RedirectToAction("Index");
        }

        public ViewResult AddRisks()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddRisks(ProjectRisks projectRisks)
        {
            
            projectPageModel.AddToProjectRisks(projectRisks.Description, projectRisks.OTV,
                projectRisks.RedLine, projectRisks.Solution, id);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public RedirectToActionResult Editor(Project project)
        {
            projectPageModel.EditToProject(id, project.Customer, project.Developer,
                project.Technology, project.Cost);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult DeleteFinalProblems(String ID)
        {
            projectPageModel.DeleteGeneralProblems(ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult DeleteGeneralWorks(String ID)
        {
            projectPageModel.DeleteGeneralWorks(ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public RedirectToActionResult DeleteRisks(String ID)
        {
            projectPageModel.DeleteProjectRisks(ID);
            return RedirectToAction("Index");
        }

        public RedirectToActionResult MakePDF()
        {
            iTextSharp.text.Document doc = new iTextSharp.text.Document();
            PdfWriter.GetInstance(doc, new FileStream("C:\\ProjectId\\"  + (id) +"_Project.pdf", FileMode.Create));
            doc.Open();

            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
            BaseFont baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);

            PdfPCell cell = new PdfPCell(new Phrase("Общая информация о проекте", font));
            PdfPTable table = new PdfPTable(6);
            cell.Colspan = 6;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Номер", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Название", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Заказчик", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Разработчик", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Технология", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Стоимость", font)));
            table.AddCell(cell);
            var items = projectPageModel.getProjectModels(id);
            
            if (items != null)
            {
                foreach (var el in items)
                {
                    if (el.Id.Equals(id))
                    {
                        table.AddCell(new Phrase(el.Id, font));
                        table.AddCell(new Phrase(el.Name.ToString(), font));
                        table.AddCell(new Phrase(el.Customer, font));
                        table.AddCell(new Phrase(el.Developer.ToString(), font));
                        table.AddCell(new Phrase(el.Technology.ToString(), font));
                        table.AddCell(new Phrase(el.Cost.ToString(), font));
                    }
                }
            }


            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));

            cell = new PdfPCell(new Phrase("Этапы", font));
            table = new PdfPTable(2);
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Номер", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Этап", font)));
            table.AddCell(cell);
            var items2 = projectPageModel.GetProjectStagesModels();
            
            if (items2 != null)
            {
                foreach (var el in items2)
                {
                    
                    if (el.ProjectId.Equals(id))
                    {
                        table.AddCell(new Phrase(el.Id.ToString(), font));
                        table.AddCell(new Phrase(el.Stage.ToString(), font));
                    }
                }
            }


            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));


            cell = new PdfPCell(new Phrase("Задачи до конца проекта", font));
            table = new PdfPTable(2);
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Номер", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Название", font)));
            table.AddCell(cell);

            var items3 = projectPageModel.GetProjectProblemsModels();

            if (items3 != null)
            {
                foreach (var el in items3)
                {
                    if (el.ProjectId.Equals(id))
                    {
                        table.AddCell(new Phrase(el.Id.ToString(), font));
                        table.AddCell(new Phrase(el.Problem.ToString(), font));
                    }
                }
            }


            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));


            cell = new PdfPCell(new Phrase("Основные задачи этапа", font));
            table = new PdfPTable(2);
            cell.Colspan = 2;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Описание", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Срок", font)));
            table.AddCell(cell);

            var items4 = projectPageModel.GetProjectGeneralProblems(ProjectPageController.id);


            if (items4 != null)
            {
                foreach (var el in items4)
                {
                    if (el.ProjectId.Equals(id))
                    {
                        table.AddCell(new Phrase(el.Description, font));
                        table.AddCell(new Phrase(el.Date.ToString(), font));
                    }
                }
            }


            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));


            cell = new PdfPCell(new Phrase("Основные текущие и предстоящие работы", font));
            table = new PdfPTable(5);
            cell.Colspan = 5;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Описание", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Срок", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Точка невозрата", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Ответственные", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("%", font)));
            table.AddCell(cell);

            var items5 = projectPageModel.GetProjectGeneralWorks();


            if (items5 != null)
            {
                foreach (var el in items5)
                {
                    if (el.ProjectId.Equals(id))
                    {
                        table.AddCell(new Phrase(el.Description, font));
                        table.AddCell(new Phrase(el.Date.ToString(), font));
                        table.AddCell(new Phrase(el.RedLine.ToString(), font));
                        table.AddCell(new Phrase(el.Responsible.ToString(), font));
                        table.AddCell(new Phrase(el.Persent.ToString(), font));
                    }
                }
            }


            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));

            cell = new PdfPCell(new Phrase("Риски", font));
            table = new PdfPTable(4);
            cell.Colspan = 4;
            cell.HorizontalAlignment = 1;
            cell.Border = 0;
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Описание рисков", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("ОТВ", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Срок", font)));
            table.AddCell(cell);
            cell = new PdfPCell(new Phrase(new Phrase("Решение", font)));
            table.AddCell(cell);

            var items6 = projectPageModel.GetProjectRisks();


            if (items6 != null)
            {
                foreach (var el in items6)
                {
                    if (el.ProjectId.Equals(id))
                    {
                        table.AddCell(new Phrase(el.Description, font));
                        table.AddCell(new Phrase(el.OTV.ToString(), font));
                        table.AddCell(new Phrase(el.RedLine.ToString(), font));
                        table.AddCell(new Phrase(el.Solution.ToString(), font));
                    }
                }
            }


            doc.Add(table);
            doc.Add(new Paragraph("\n\n"));

            doc.Close();
            return RedirectToAction("Index");
        }
    }
}
