using System;
using System.Collections.Generic;
using System.Text;

namespace Magazzino.Models.Infraestruture
{
   public class ServiceResult
    {
        public Boolean Success { get; set; }
        public dynamic ResultObject { get; set; }
        public string ResultTitle { get; set; }
        public List<string> Messages { get; set; }

    }
}
