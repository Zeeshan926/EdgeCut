using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EdgeCut.Models;
using EdgeCut.Data;

namespace EdgeCut.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string? FurnitureName { get; set; }
        public float FurniturePrice { get; set; }
        public string? ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(FurnitureName))
            {
                FurnitureName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "b1.jpg";
            }
            FurnitureOrder furnitureOrder = new FurnitureOrder();
            furnitureOrder.FurnitureName = FurnitureName;
            furnitureOrder.BasePrice = FurniturePrice;

            _context.FurnitureOrders.Add(furnitureOrder);
            _context.SaveChanges();
        }
    }
}
