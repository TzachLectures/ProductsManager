using ProductsManager.Models;
using System.Text.Json;

namespace ProductsManager.Services
{
    public class ProductsDbService
    {
        public  List<Product> GetAll()
        {
            return DbService.Products;
        }

        public Product GetOne (int id)
        {
            return DbService.Products.FirstOrDefault(p => p.Id == id);
        }

        public void EditProduct (int id, Product p)
        {
            Product productToEdit = DbService.Products.FirstOrDefault(p => p.Id == id);
           if(productToEdit != null)
            {
                productToEdit.Name = p.Name;
                productToEdit.Description = p.Description;
                productToEdit.Price = p.Price;
                productToEdit.Stock = p.Stock;
                productToEdit.Category = p.Category;
            }

        }
        public void DeleteProduct (int id)
        {
            Product productToRemove = DbService.Products.FirstOrDefault(p => p.Id == id);
            if (productToRemove != null)
            {
                DbService.Products.Remove(productToRemove);
            }
        }

        public void AddNewProduct (Product p) // you create the id as a running number
        {
            p.Id = DbService.Products.Max(p => p.Id) + 1;
            DbService.Products.Add(p);
        }



    }

}



