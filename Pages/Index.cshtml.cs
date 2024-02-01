using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductsManager.Models;
using ProductsManager.Services;
using System.Text.Json;

namespace ProductsManager.Pages
{
    public class IndexModel : PageModel
    {
       
        public List<Product> Products { get;private set; }
        private ProductsDbService _productsDbService;
        public List<int> Cart { get; set; }

        public IndexModel()
        {
            _productsDbService = new ProductsDbService();
        }

        public void OnGet()
        {
            Products = _productsDbService.GetAll();
            InitializeCart();

        }


        public IActionResult OnPostDelete(int id)
        {
            _productsDbService.DeleteProduct(id);
            return RedirectToPage();
        }

        public IActionResult OnPostCart(int id)
        {
            InitializeCart();
            if (Cart.Contains(id))
            {
                Cart.Remove(id);
            }
            else
            {
                Cart.Add(id);
            }
            HttpContext.Session.SetString("Cart", JsonSerializer.Serialize(Cart));
            return RedirectToPage();
        }

        private void InitializeCart()
        {
            string? cartSession = HttpContext.Session.GetString("Cart");
            if (cartSession != null)
            {
                try
                {
                Cart = JsonSerializer.Deserialize<List<int>>(cartSession);

                }
                catch (Exception error)
                {
                    Console.WriteLine(error);
                    Cart = new List<int>();
                }
            }
            else
            {
                Cart = new List<int>();
            }
        }
    }
}