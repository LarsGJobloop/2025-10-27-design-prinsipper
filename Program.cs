class Program
{
  static void Main()
  {
    var productRepository = new ProductRepository();
    var products = productRepository.GetProducts();

    // Read user input
    Console.WriteLine("Please enter a Product ID");
    string? userInput = Console.ReadLine();

    // Convert
    if (!int.TryParse(userInput, out int convertedInput))
    {
      throw new Exception("ID needs to be a number");
    }

    // Search in data store
    try
    {
      Product foundProduct = products[convertedInput];
      // Present to the caller/user/consumer
      Console.WriteLine($"Product:\n\tID: {foundProduct.Id}\n\tName: {foundProduct.Name}\n\tPrice: {foundProduct.Price}");
    }
    catch (System.Collections.Generic.KeyNotFoundException)
    {
      Console.WriteLine($"Sorry no product found with ID: {convertedInput}");
    }
  }
}
