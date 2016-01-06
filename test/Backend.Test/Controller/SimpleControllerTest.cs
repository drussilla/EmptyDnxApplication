using Backend.Controllers;
using Microsoft.AspNet.Mvc;
using Xunit;

namespace Backend.Test.Controllers
{
    public class SimpleControllerTest
    {
        [Fact]
        public void Index_Default_ResultOk()
        {
            // arrange 
            SimpleController target = new SimpleController();
            
            // act
            var result = target.Index();
            
            // assert
            Assert.IsType<HttpOkResult>(result);            
        }

    }
}