using Microsoft.EntityFrameworkCore;
using Moq;
using System.Threading.Tasks;
using Web_ASPNET_API3._1.Controllers;
using Web_ASPNET_Core3._1.Models;
using Xunit;

namespace Web_ASPNET_Test
{
    class CategoriesControllerTest
    {
        private readonly Mock<DbSet<Category>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Category _categoria;
        public CategoriesControllerTest()
        {
            _mockSet = new Mock<DbSet<Category>>();
            _mockContext = new Mock<Context>();
            _categoria = new Category { Id = 1, Description = "Teste Categoria" };

        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriesController(_mockContext.Object);

            await service.GetCategoria(1);

            _mockSet.Verify(m => m.FindAsync(1),
                Times.Once());
        }

    }
}
