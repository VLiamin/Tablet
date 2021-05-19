using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Tablet.Controllers;
using Tablet.Data;
using Tablet.Data.Models;
using Xunit;

namespace XUnitTestTablet
{
    public class ProjectPageControllerTests
    {
        [Fact]
        public void AddProblemTest()
        {

            AppDBContent app = new AppDBContent();
            ProjectPageController controller = new ProjectPageController(new ProjectPageModel(app));

            ViewResult result = controller.AddProblem() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void AddRisksTest()
        {

            AppDBContent app = new AppDBContent();
            ProjectPageController controller = new ProjectPageController(new ProjectPageModel(app));

            ViewResult result = controller.AddRisks() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void AddStageTest()
        {

            AppDBContent app = new AppDBContent();
            ProjectPageController controller = new ProjectPageController(new ProjectPageModel(app));

            ViewResult result = controller.AddStage() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void AddGeneralWorksTest()
        {

            AppDBContent app = new AppDBContent();
            ProjectPageController controller = new ProjectPageController(new ProjectPageModel(app));

            ViewResult result = controller.AddGeneralWorks() as ViewResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void AddGeneralProblemTest()
        {

            AppDBContent app = new AppDBContent();
            ProjectPageController controller = new ProjectPageController(new ProjectPageModel(app));

            ViewResult result = controller.AddGeneralProblem() as ViewResult;
            Assert.NotNull(result);
        }
    }
}
