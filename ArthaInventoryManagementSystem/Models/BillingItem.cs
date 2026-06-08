using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArthaInventoryManagementSystem.Models;

public class BillingItem
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    public Guid ProductId { get; set; }
    [Required]
    public Guid BillingId { get; set; }
    
    //nav properties
    [ForeignKey("ProductId")]
    public Product Product { get; set; }
    
    [ForeignKey("BillingId")]
    public Billing Billing { get; set; }
}