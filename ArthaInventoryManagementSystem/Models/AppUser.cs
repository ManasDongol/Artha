using System.ComponentModel.DataAnnotations;

namespace ArthaInventoryManagementSystem.Models;

public class AppUser 
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(50)]
    public string Password { get; set; }
    
}