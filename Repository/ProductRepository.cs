class ProductRepository
{
  private readonly Dictionary<int, Product> products = new Dictionary<int, Product>
  {
    {1, new Product {Id = 1, Name = "Barber Blades", Price = 9.99}},
    {2, new Product {Id = 2, Name = "Towels", Price = 19.99}},
    {3, new Product {Id = 3, Name = "Soap", Price = 0.99}},
  };

  public Dictionary<int, Product> GetProducts()
  {
    return products;
  }
}
