namespace MilkyProject.WebUI.Dtos.Product_Dto
{
    public class CreateProductDto
    {
        public string ProductName { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
