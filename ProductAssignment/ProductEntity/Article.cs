using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductEntity
{
    [Table("Articles")]
    public class Article
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       
        public int ArticleId { get; set; }


       
        public string ArticleName { get; set; } 


       
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Size")]
        public int SizeId { get; set; }
        public Sizes Size { get; set; }
        [ForeignKey("Color")]
        public int ColorId { get; set; }
        public Colour Color { get; set; }
    } 
}
