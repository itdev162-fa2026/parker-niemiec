using System.ComponentModel;

namespace Domain;

public class Product
{
    public int Id { get; set; } //primary key, auto-generated
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public bool IsOnSale { get; set; }
    public decimal? SalePrice { get; set; } //nullable(decimal?) since not all products will be on sale
    public int CurrentStock { get; set; }
    public string ImageUrl { get; set; } = string.Empty;
    // CreatedDate and LastUpdatedDate track when products are added/modified
    public DateTime CreatedDate { get; set; }
    public DateTime LastUpdatedDate { get; set; }
}