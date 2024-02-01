using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductsManager.Helpers;
using ProductsManager.Models;
using ProductsManager.Services;

namespace ProductsManager.Pages
{
    public class AddProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public List<SelectListItem> Categories { get; set; }

        private ProductsDbService _productsDbService;

        public AddProductModel()
        {
            _productsDbService = new ProductsDbService();
            Categories = new ProductCategoriesOptions().Categories;
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
