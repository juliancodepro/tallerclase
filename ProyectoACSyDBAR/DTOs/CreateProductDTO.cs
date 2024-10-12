namespace ProyectoACSyDBAR.DTOs
{
    public class CreateProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }  
        public double Price { get; set; }
        public int Stock {  get; set; }
        public string Category { get; set; }

    }
}
