using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EdgeCut.Data;
using EdgeCut.Models;

namespace EdgeCut.Pages.Forms
{
    public class OrdersModel : PageModel
    {
        public List<FurnitureOrder> FurnitureOrders = new List<FurnitureOrder>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            FurnitureOrders = _context.FurnitureOrders.ToList();
        }
        
    }
}
