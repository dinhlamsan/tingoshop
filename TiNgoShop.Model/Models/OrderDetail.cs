using System.ComponentModel.DataAnnotations.Schema;

namespace TiNgoShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}