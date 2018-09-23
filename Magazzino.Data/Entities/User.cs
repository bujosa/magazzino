using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Magazzino.Data.Entities
{
    [Table("User", Schema = "dbo")]
    public class User : BaseEntity
    {
        public int IdUser { get; set; }
        public string  UserName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
    }
}
