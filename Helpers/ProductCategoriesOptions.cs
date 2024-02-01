using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProductsManager.Helpers
{
    public class ProductCategoriesOptions
    {
        public List<SelectListItem> Categories { get; set; }
        public ProductCategoriesOptions()
        {
            Categories =  new List<SelectListItem>
        {
            new SelectListItem { Value = "Kitchen", Text = "Kitchen" },
            new SelectListItem { Value = "Electronics", Text = "Electronics" },
            new SelectListItem { Value = "Home Appliances", Text = "Home Appliances" },
        };

        }

    }
}
