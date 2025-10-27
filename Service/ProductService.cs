class ProductService
{
  private readonly ProductRepository productRepository;

  public ProductService(ProductRepository repository)
  {
    productRepository = repository;
  }

  public Product? GetProduct(int id)
  {
    try
    {
      var products = productRepository.GetProducts();
      Product foundProduct = products[id];
      // Return to the caller/user/consumer
      return foundProduct;
    }
    catch (System.Collections.Generic.KeyNotFoundException)
    {
      return null;
    }
  }
}