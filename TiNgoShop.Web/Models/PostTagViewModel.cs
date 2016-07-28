using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiNgoShop.Web.Models
{
    public class PostTagViewModel
    {
        public int PostId { get; set; }
        public string TagId { get; set; }        
        public virtual PostViewModel Post { set; get; }        
        public virtual TagViewModel Tags { set; get; }
    }
}