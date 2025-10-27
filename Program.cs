class Program
{
  static void Main()
  {
    Console.WriteLine("Hello");
  }
}

class Product
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public double Price { get; set; }
}
