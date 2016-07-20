using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TiNgoShop.Model.Abstract;

namespace TiNgoShop.Model.Models
{
    [Table("Orders")]
    public class Order:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(250)]
        public string CustomerName { get; set; }
        [MaxLength(250)]
        public string CustomerAddress { get; set; }
        [MaxLength(250)]
        public string CustomerEmail { get; set; }
        [MaxLength(50)]
        public string CustomerMobile { get; set; }
        [MaxLength(250)]
        public string CustomerMessage { get; set; }
        [MaxLength(250)]
        public string PaymentMethod { get; set; }
        [MaxLength(50)]
        public string PaymentStatus { get; set; }
    }
}