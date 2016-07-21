using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiNgoShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]        
        public int OrderId { get; set; }
        [Key]        
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Orders { set; get; }
        [ForeignKey("ProductId")]
        public virtual Product Products { set; get; }
    }
}
