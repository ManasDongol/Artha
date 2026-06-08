using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ArthaInventoryManagementSystem.Enums;

namespace ArthaInventoryManagementSystem.Models;

public class Product
{
    [Key]
    public Guid Id { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string Description { get; set; }
    [Column(TypeName = "decimal(18,2)")]    
    public decimal Price { get; set; }
    [MaxLength(100)]
    public string imageUrl { get; set; }
    public MaterialCategory material { get; set; }
    public ProductCategory category { get; set; }
    
}