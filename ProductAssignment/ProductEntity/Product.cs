using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProductEntity
{
    [Table("Products")]
    public class Product
    {
        [Key]
       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }

        public int ProductYear { get; set; }

        public int ChannelId { get; set; } 

        public DateTime CreatedDate { get; set; }
        
       public string CreatedBy { get; set; }
    }
   
}
