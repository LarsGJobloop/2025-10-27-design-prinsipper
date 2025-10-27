class Program
{
  static void Main()
  {
    // Create some Mock Product entries, so we can verify the rest of the program
    Dictionary<int, Product> products = new Dictionary<int, Product>
    {
      {1, new Product {Id = 1, Name = "Barber Blades", Price = 9.99}},
      {2, new Product {Id = 2, Name = "Towels", Price = 19.99}},
      {3, new Product {Id = 3, Name = "Soap", Price = 0.99}},
    };

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

class Product
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public double Price { get; set; }
}
