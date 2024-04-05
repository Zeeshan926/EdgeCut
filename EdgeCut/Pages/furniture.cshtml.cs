using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EdgeCut.Models;

namespace EdgeCut.Pages
{
    public class furnitureModel : PageModel
    {
        public List<FurnituresModel> fakePizzaDB = new List<FurnituresModel>()
        {
            new FurnituresModel()
            {
                ImageTittle="f1",
                furnitureName="brownChairDesign",
                BasePrice=2,
                doubleBedDesign=true,
                houseChairDesign=true,
                FinalPrice=4},
             new FurnituresModel()
            {
                ImageTittle="f2",
                furnitureName="doubleBedDesign",
                BasePrice=2,
                doubleBedDesign=true,
                houseChairDesign=true,
                FinalPrice=4},
             new FurnituresModel()
            {
                ImageTittle="f3",
                furnitureName="houseChairDesign",
                BasePrice=2,
                doubleBedDesign=true,
                houseChairDesign=true,
                FinalPrice=4},
             new FurnituresModel()
            {
                ImageTittle="f4",
                furnitureName="brownTableDesign",
                BasePrice=2,
                doubleBedDesign=true,
                houseChairDesign=true,
                FinalPrice=4},
             new FurnituresModel()
            {
                ImageTittle="f5",
                furnitureName="blueChairDesign",
                BasePrice=2,
                doubleBedDesign=true,
                houseChairDesign=true,
                FinalPrice=4 },
             new FurnituresModel()
            {
                ImageTittle="f6",
                furnitureName="blueTableDesign",
                BasePrice=2,
                doubleBedDesign=true,
                houseChairDesign=true,
                FinalPrice=4 },
        };
        public void OnGet()
        {
        }
    }
}
