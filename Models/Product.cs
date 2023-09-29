namespace blazorappdemo;

public class Product
{
    public int Id { get; set; }
    public string title { get; set; }
    public decimal? price { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public string[] Images { get; set; }
    public string? image { get; set; }
}