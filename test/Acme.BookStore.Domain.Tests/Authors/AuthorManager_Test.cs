using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using NSubstitute;
using Shouldly;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace Acme.BookStore.Authors
{
    public class AuthorManager_Tests
    {
        [Fact]
        public async Task Should_Able_To_ChangeName()
        {
            // Arrange

            var _authorRepository = Substitute.For<IAuthorRepository>();
            //_authorRepository.ClearReceivedCalls();
            var _authorManager = new AuthorManager(_authorRepository);

            var author = await _authorRepository.InsertAsync(
                await _authorManager.CreateAsync(
                    "SuperTest",
                    new DateTime(1903, 06, 25),
                    "Orwell produced literary criticism and poetry"
                )
            );
            string name = "New SuperName";
            // Act
            await _authorManager.ChangeNameAsync(author, name);

            //Assert
            author.Name.ShouldBe(name);


        }
    }
}
