using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magazzino.Data.Entities
{
    [Table("Product", Schema = "dbo")]
   public class Product : BaseEntity
    {
        public int IdProduct { get; set; }
        public string ProductName { get; set; }
        public String Details { get; set; }
        public int Money { get; set; }
        public int IdSellers { get; set; }
        public String Cal { get; set; }
        public byte?[] Img { get; set; }
        public String Category { get; set; }
    }
}
