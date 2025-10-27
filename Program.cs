class Program
{
  static void Main()
  {
    var productRepository = new ProductRepository();
    var productService = new ProductService(productRepository);

    // Read user input
    Console.WriteLine("Please enter a Product ID");
    string? userInput = Console.ReadLine();

    // Convert
    if (!int.TryParse(userInput, out int convertedInput))
    {
      throw new Exception("ID needs to be a number");
    }

    // Search in data store
    Product? foundProduct = productService.GetProduct(convertedInput);
    if (foundProduct == null)
    {
      Console.WriteLine($"Sorry no product found with ID: {convertedInput}");
    }
    else
    {
      Console.WriteLine($"Product:\n\tID: {foundProduct.Id}\n\tName: {foundProduct.Name}\n\tPrice: {foundProduct.Price}");
    }
  }
}
