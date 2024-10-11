namespace LongParameterList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product> 
            {
                new Product{
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 3999.99M,
                    Stock = "Available",
                    Supplier = "TechStore",
                    SupplierContact = "techstore@example.com"
                },
                new Product{
                    Name = "Office Chair",
                    Category = "Furniture",
                    Price = 249.99M,
                    Stock = "Limited",
                    Supplier = "HomeComfort",
                    SupplierContact = "support@homecomfort.com"
                },
                new Product{
                    Name = "Running Shoes",
                    Category = "Footwear",
                    Price = 199.99M,
                    Stock = "Out of Stock",
                    Supplier = "SportMax",
                    SupplierContact = "info@sportmax.com"
                },
            };

            products.ForEach(p => RegisterProduct(p));
        }

        static void RegisterProduct(Product product) 
        {
            Console.WriteLine($"Registering product - Name: {product.Name}, Category:{product.Category}, Price:{product.Price}, Stock:{product.Stock}, Supplier:{product.Supplier}, Supplier contact:{product.SupplierContact} ");
        }
    }
}