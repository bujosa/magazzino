using System;
using System.Collections.Generic;
using System.Text;

namespace Magazzino.Data.StoreProcedures
{
	class ValidateUser
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public bool Check { get; set; }
	}
}
