
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EdgeCut.Models;


namespace EdgeCut.Pages.Forms
{
    public class CustomFurnitureModel : PageModel
    {
        public FurnituresModel furniture { get; set; }
        private float furniturePrice { get; set; }

        
        public void OnGet()
        {
        }

        // public IActionResult OnPost()
        //{
        //  furniturePrice = furniture.BasePrice;
        //if (furniture.brownChairDesign) furniturePrice += 1;
        //if (furniture.doubleBedDesign) furniturePrice += 1;
        //if (furniture.houseChairDesign) furniturePrice += 1;
        //if (furniture.brownTableDesign) furniturePrice += 1;
        //if (furniture.blueChairDesign) furniturePrice += 1;

        //return RedirectToPage("/Checkout/Checkout", new { furniture.furnitureName, furniturePrice });
        //}
        public IActionResult OnPost(FurnituresModel furniture)
        {
            if (furniture == null)
            {
                // Handle null furniture object, perhaps by returning an error message or redirecting back to the form
                return BadRequest("Invalid furniture data.");
            }

            furniturePrice = furniture.BasePrice;
            if (furniture.brownChairDesign) furniturePrice += 1;
            if (furniture.doubleBedDesign) furniturePrice += 1;
            if (furniture.houseChairDesign) furniturePrice += 1;
            if (furniture.brownTableDesign) furniturePrice += 1;
            if (furniture.blueChairDesign) furniturePrice += 1;
            if (furniture.blueTableDesign) furniturePrice += 1;

            return RedirectToPage("/Checkout/Checkout", new { furniture.furnitureName, furniturePrice });
        }

    }
}
