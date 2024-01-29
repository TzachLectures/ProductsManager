using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsManager.Models;
using ProductsManager.Services;

namespace ProductsManager.Pages
{
    public class EditProductModel : PageModel
    {
        [BindProperty]
        public Product Product { get; set; }

        private ProductsDbService _productsDbService;

        public EditProductModel()
        {
            _productsDbService = new ProductsDbService();
        }
        public void OnGet(int id)
        {
            //search in the db - and put the data in the BindProperty
            Product = _productsDbService.GetOne(id);
        }
    }
}
