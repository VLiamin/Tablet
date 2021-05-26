using Microsoft.AspNetCore.Mvc;
using Tablet.Controllers;
using Tablet.Data;
using Tablet.Data.interfaces;
using Tablet.Data.Models;
using Xunit;

namespace XUnitTestTablet
{
    public class StructureControllerTests
    {
        [Fact]
        public void SecondCheckoutTest()
        {

            AppDBContent app = new AppDBContent();
            StructureController controller = new StructureController(new MainModel(app));

            ViewResult result = controller.SecondCheckout() as ViewResult;
            Assert.NotNull(result);
        }
    }
}
