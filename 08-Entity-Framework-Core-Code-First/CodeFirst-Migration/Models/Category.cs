using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_Migration.Models
{
    [Table("Kategoriler")]
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string CategoryName { get; set; }

        [Column(TypeName = "nvarchar(300)")]
        public string CategoryDescription { get; set; }

        // Relational Property
        public virtual List<Product> Products { get; set; }
    }
}
