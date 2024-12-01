namespace Product_API.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Cost { get; set; }
        public static List<Product> Products = new List<Product>
        {
            new Product { Id = 1, ProductName = "Opera", ProductDescription = "Tech", Cost = 1.5m },
            new Product {Id = 2, ProductName = "Tecno", ProductDescription = "Mobile", Cost = 2.1m},
            new Product {Id = 3, ProductName = "Lenovo", ProductDescription = "Laptop", Cost = 3.2m},
        }; 
    }
}
