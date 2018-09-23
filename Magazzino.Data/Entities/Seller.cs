using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Magazzino.Data.Entities
{
    [Table("Seller", Schema = "dbo")]
    public  class Seller : BaseEntity
    {
        public int IdSeller { get; set; }
        public string Company { get; set; }
        public string Tel { get; set; }
        public string Location { get; set; }
        public string Cal { get; set; }
        public string Post { get; set; }
        public string Policy { get; set; }
    }
}
