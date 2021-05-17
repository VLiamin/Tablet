using Microsoft.AspNetCore.Mvc;
using Tablet.Controllers;
using Tablet.Data;
using Tablet.Data.interfaces;
using Tablet.Data.Models;
using Xunit;

namespace XUnitTestTablet
{
    public class HomeControllerTests
    {
        [Fact]
        public void Test1()
        {

            AppDBContent app = new AppDBContent();
            GeneralDevelopmentController controller = new GeneralDevelopmentController(new MainModel(app));
            
            ViewResult result = controller.Checkout() as ViewResult;
            Assert.NotNull(result);
        }
    }
}
