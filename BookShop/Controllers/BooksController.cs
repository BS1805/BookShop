using BookShop.Data;
using BookShop.Models;
using BookShop.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public BooksController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddBookViewModel viewModel)
        {
            var book = new Book
            {
                Name = viewModel.Name,
                Description = viewModel.Description,
                price = viewModel.price,
                Available = viewModel.Available
            };
            await dbContext.Books.AddAsync(book);
            await dbContext.SaveChangesAsync();
            return View();
        }
    }
}
