using FisherLink.Controllers;
using FisherLink.Data;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace FisherTest
{
    public class ControllerTest : IClassFixture<ApplicationDbContext>
    {
        private ApplicationDbContext fixture;

        public ControllerTest(ApplicationDbContext contextFixture)
        {
            fixture = contextFixture;
        }

        [Fact]
        public void TestStudentController()
        {
            var controller = new StudentsController(fixture);

             // Act
            var result = controller.Create() as ViewResult;

            //Assert
            Assert.Equal("Create", result.ViewName);

        }
        
    }
}