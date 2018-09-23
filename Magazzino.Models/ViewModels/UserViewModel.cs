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
		public DateTime? DateOfBirthM { get; set; }
		public string BirthPlaceM { get; set; }
		public byte?[] PictureM { get; set; }
		[MaxLength(50)]
		public string TypeM { get; set; }
	}
}
