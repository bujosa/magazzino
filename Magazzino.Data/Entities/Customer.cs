using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magazzino.Data.Entities
{
    [Table("Customer", Schema = "dbo")]
    public class Customer : BaseEntity
    {
        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string Location { get; set; }
        public string MetodoPago { get; set; }
    }
}
