using System.ComponentModel.DataAnnotations;

namespace ControlShopWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

public class Products
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [Column(TypeName = "ntext")]
    private string? ProductName { get; set; }

    [Required]
    [Column(TypeName = "ntext")]
    private string? Description { get; set; }

    [Required]
    [ForeignKey("CategoryID")]
    public Catagories CatagoryId { get; set; }

    [Required]
    [Column(TypeName = "money")]
    private decimal? Price { get; set; }

    [Required]
    [Column(TypeName = "int")]
    private int? StockQuantity { get; set; }

    [Required]
    [Column(TypeName = "DateTime")]
    private DateTime? CreateDate { get; set; }

    [Column(TypeName = "DateTime")]
    private DateTime? ModifiedDate { get; set; }
}