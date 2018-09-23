using System;
using System.Collections.Generic;
using System.Text;
using Magazzino.Models.Infraestruture;
using System.ComponentModel.DataAnnotations;

namespace Magazzino.Models
{
    public class SalesViewModel : BaseViewModel
    {
		public int IdProductM { get; set; }
		public int IdClientM { get; set; }
		public int IdSaleM { get; set; }
		public int IdSellerM { get; set; }
		[MaxLength(50)]
		public string ProductNameM { get; set; }
		[MaxLength(50)]
		public string PriceM { get; set; }
		[MaxLength(50)]
		public String LocationClientM { get; set; }
		[MaxLength(50)]
		public String StatusM { get; set; }
		[MaxLength(50)]
		public DateTime ShoppingDateM { get; set; }
		[MaxLength(50)]
		public DateTime ArrivalDateM { get; set; }
	}
}
