using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Product : BaseEntity
{
  
    public int Id { get; set; }
    public required string Name { get; set; }
    public int Description { get; set; }
    public decimal Price { get; set; }  
    public required string PictureUrl { get; set; }
    public required string Type { get; set; }
    public required string Brand { get; set; }
    public int QuantityInStock { get; set; }
}