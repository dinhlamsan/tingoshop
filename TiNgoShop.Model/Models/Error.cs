using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiNgoShop.Model.Models
{
    [Table("Errors")]
    public class Error
    {
        [Key]
        public int Id { get; set; }

        public string Message { set; get; }
        public string StackTrace { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}