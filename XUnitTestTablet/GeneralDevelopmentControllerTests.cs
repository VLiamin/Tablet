using Microsoft.AspNetCore.Mvc;
using Tablet.Controllers;
using Tablet.Data;
using Tablet.Data.interfaces;
using Tablet.Data.Models;
using Xunit;

namespace XUnitTestTablet
{
    public class GeneralDevelopmentControllerTests
    {
        [Fact]
        public void CheckoutTest()
        {

            AppDBContent app = new AppDBContent();
            GeneralDevelopmentController controller = new GeneralDevelopmentController(new MainModel(app));
            
            ViewResult result = controller.Checkout() as ViewResult;
            Assert.NotNull(result);
        }
    }
}
