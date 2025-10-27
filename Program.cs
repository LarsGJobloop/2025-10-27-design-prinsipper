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

    Console.WriteLine("Please enter a Product ID");
    string? userInput = Console.ReadLine();

    Console.WriteLine($"You wrote: {userInput}");
  }
}

class Product
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public double Price { get; set; }
}
