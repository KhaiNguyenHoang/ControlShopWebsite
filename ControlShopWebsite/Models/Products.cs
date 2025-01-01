using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlShopWebsite.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string ProductName { get; set; }

        [Required]
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        [Required]
        public int CategoryID { get; set; } // Khóa ngoại thực tế (cột lưu giá trị ID)

        [ForeignKey("CategoryID")]
        public Categories Category { get; set; } // Điều hướng đến bảng Categories

        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; } // Không nullable

        [Required]
        public int StockQuantity { get; set; } // Không nullable

        [Required]
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; } // Không nullable

        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; } // Nullable
    }
}