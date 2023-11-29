using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Store.Model
{
    [Table("ProductsOrders")]
    public class ProductsOrders
    {
        [Key]
        [Required]
        public int Code { get; set; }
        [MaxLength(25)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }

        public int? ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Products Products { get; set; }

        public int? ProductOrder { get; set; }

        [ForeignKey(nameof(ProductOrder))]
        public Orders ProductofOrder { get; set; }
        private Orders orders;


    }
}
