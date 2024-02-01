using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductsManager.Helpers;
using ProductsManager.Models;
using ProductsManager.Services;

namespace ProductsManager.Pages
{
    public class EditProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        public List<SelectListItem> Categories { get; set; }

        private ProductsDbService _productsDbService;

        public EditProductModel()
        {
            _productsDbService = new ProductsDbService();
            Categories = new ProductCategoriesOptions().Categories;
        }

        
        public void OnGet(int id)
        {
            //search in the db - and put the data in the BindProperty
            Product = _productsDbService.GetOne(id);
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _productsDbService.EditProduct(Product.Id, Product);
            return RedirectToPage("Index");
        }
    }
}
