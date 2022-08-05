using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Acme.BookStore.Books
{
    public class Book_Test
    {
        [Fact]
        public void CanChangeBookName()
        {

            //Arrange
            var books = new Book
            {
                Name = "Test",
                Price = 15.0f
            };

            //Act
            books.Name = "New Name";

            //Assert
            Assert.Equal("New Name", books.Name);
        }

        [Fact]
        public void CanChangeBookPrice()
        {

            //Arrange
            var books = new Book
            {
                Name = "Test",
                Price = 15.0f
            };

            //Act
            books.Price = 20.0f;

            //Assert
            Assert.Equal(15.0f, books.Price);
        }

    }
}
