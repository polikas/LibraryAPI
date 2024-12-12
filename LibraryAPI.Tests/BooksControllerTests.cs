using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAPI.Models;
using LibraryAPI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace LibraryAPI.Tests
{
    public class BooksControllerTests
    {
        [Fact]
        public void GetAllBooks_ShouldReturnOk()
        {
            // Arrange
            var controller = new BooksController();

            // Act
            var result = controller.GetAllBooks();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }
    }
}
