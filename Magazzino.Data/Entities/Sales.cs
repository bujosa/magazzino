using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace Magazzino.Data.Entities
{
    [Table("Sales", Schema = "dbo")]
    public class Sales : BaseEntity
    {
        public int IdProduct { get; set; }
        public int IdClient { get; set; }
        public int IdSale { get; set; }
        public int IdSeller { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public String LocationClient { get; set; }
        public String Status { get; set; }
        public DateTime ShoppingDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string Transation { get; set; }
    }
}
