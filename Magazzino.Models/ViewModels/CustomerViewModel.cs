using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

using Magazzino.Models.Infraestruture;

namespace Magazzino.Models
{
    public class CustomerViewModel : BaseViewModel
    {
        public int IdCustomerM { get; set; }
        [MaxLength(50)]
        public string NameM { get; set; }
        [MaxLength(50)]
        public string LastNameM { get; set; }
        [MaxLength(50)]
        public string MailM { get; set; }
        [MaxLength(150)]
        public string LocationM { get; set; }
        [MaxLength(50)]
        public string MetodoPagoM { get; set; }
    }
}
