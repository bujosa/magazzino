using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Models.Infraestruture;
using System.ComponentModel.DataAnnotations;

namespace Magazzino.Models
{
    public class UserViewModel : BaseViewModel
    {
		public int IdUserM { get; set; }
		[MaxLength(50)]
		public string UserNameM { get; set; }
        [MaxLength(50)]
        public string PassowordM { get; set; }
		[MaxLength(50)]
		public string TypeM { get; set; }
	}
}
