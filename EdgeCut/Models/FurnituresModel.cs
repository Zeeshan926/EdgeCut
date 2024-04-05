namespace EdgeCut.Models
{
    public class FurnituresModel
    {
        public string? ImageTittle { get; set; }
        public string? furnitureName { get; set; }
        public float BasePrice { get; set; } = 2;
        public bool brownChairDesign { get; set; }
        public bool doubleBedDesign { get; set; }
        public bool houseChairDesign { get; set; }
        public bool brownTableDesign { get; set; }
        public bool blueChairDesign { get; set; }
        public bool blueTableDesign { get; set; }
        public float FinalPrice { get; set; }
    }
}
