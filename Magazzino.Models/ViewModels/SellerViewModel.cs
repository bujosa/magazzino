using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Magazzino.Models.Infraestruture;

namespace Magazzino.Models
{
    public class SellerViewModel : BaseViewModel
    {
		public int IdSellerM { get; set; }
		[MaxLength(50)]
		public string CompanyM { get; set; }
		[MaxLength(50)]
		public string TelM { get; set; }
		[MaxLength(150)]
		public string LocationM { get; set; }
		[MaxLength(50)]
		public string CalM { get; set; }
		[MaxLength(150)]
		public string PostM { get; set; }
		[MaxLength(250)]
		public string PolicyM { get; set; }
	}
}
