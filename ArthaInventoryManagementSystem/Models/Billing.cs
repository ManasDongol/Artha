using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArthaInventoryManagementSystem.Models;

public class Billing
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    public Guid SellerId { get; set; }
    
    //Nav propertiess
    [ForeignKey("SellerId")]
    public AppUser Seller { get; set; }
}