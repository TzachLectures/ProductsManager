using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsManager.Models;
using ProductsManager.Services;

namespace ProductsManager.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        private ProductsDbService _productsDbService;

        public AddProductModel()
        {
            _productsDbService = new ProductsDbService();
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _productsDbService.AddNewProduct(Product);
            return RedirectToPage("Index");
        }
    }
}
