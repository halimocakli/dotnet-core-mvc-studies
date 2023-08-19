using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Data_Annotations.Models
{
    [Table("Ürünler")]      // Tablo database'de açılırken "Ürünler" adı ile açılacak
    public class Product : BaseEntity
    {
        [Column("ÜrünAdı", TypeName = "nvarchar(50)")]     // Sütun tabloya eklenirken "ÜrünAdı" şeklinde eklenecek ve tipi nvarchar(50) olacak.
        [MinLength(5)]
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        [Column("BirimFiyat", TypeName = "numeric(18,1)")]
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }

        // Foreign Key for Product - Category : ONE-TO-MANY relationship.
        public int CategoryID { get; set; }

        // Relational Property
        public virtual Category Category { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
