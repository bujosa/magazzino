using System;
using System.Collections.Generic;
using Magazzino.Models.Infraestruture;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Magazzino.Models
{
    public class ProductViewModel : BaseViewModel
    {
		public int IdProductM { get; set; }
		[MaxLength(50)]
		public string ProductNameM { get; set; }
		[MaxLength(50)]
		public String DetailsM { get; set; }
		[MaxLength(50)]
		public int MoneyM { get; set; }
		public int IdSellersM { get; set; }
		[MaxLength(50)]
		public String CalM { get; set; }
		public byte?[] ImgM { get; set; }
		[MaxLength(50)]
		public String CategoryM { get; set; }
			
	}
}
