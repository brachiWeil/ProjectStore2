using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Model
{
    [Table("Products")]
    public class Products
    {
        [Key]
        [Required]

        public int Code { get; set; }
        [MaxLength(10)]
        public string Barkode { get; set; }
        [MaxLength(24)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int MinSize { get; set; }
        public int MaxSize { get; set; }
        //כמות במלאי
        public int QtyInventory { get; set; }

      





    }
}
