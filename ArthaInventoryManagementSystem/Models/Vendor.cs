using System.ComponentModel.DataAnnotations;

namespace ArthaInventoryManagementSystem.Models;

public class Vendor
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(50)]
    public string Number { get; set; }
    [Required]
    [MaxLength(100)]
    public string Address { get; set; }
    public string? email  { get; set; }
    
}