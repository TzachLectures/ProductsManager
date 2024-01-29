using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsManager.Models;
using ProductsManager.Services;

namespace ProductsManager.Pages
{
    public class IndexModel : PageModel
    {
       
        public List<Product> Products { get;private set; }
        private ProductsDbService _productsDbService;

        public IndexModel()
        {
            _productsDbService = new ProductsDbService();
        }

        public void OnGet()
        {
            Products = _productsDbService.GetAll();
        }

        public IActionResult OnPostDelete(int id)
        {
            return RedirectToPage();
        }
    }
}