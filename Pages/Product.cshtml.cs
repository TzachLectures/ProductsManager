using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsManager.Models;
using ProductsManager.Services;

namespace ProductsManager.Pages
{
    public class ProductModel : PageModel
    {
        public Product Product { get; set; }
        private ProductsDbService _productsDbService;

        public ProductModel()
        {
            _productsDbService = new ProductsDbService();
        }


        public void OnGet(int id)
        {
            Product = _productsDbService.GetOne(id);
        }
    }
}
