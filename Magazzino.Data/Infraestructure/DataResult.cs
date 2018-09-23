using System;
using System.Collections.Generic;
using System.Text;

namespace Magazzino.Data.Infraestructure
{
    public class DataResult
    {
        public Boolean Successfull { get; set; } = true;
        public dynamic Data { get; set; }

        public void LogError(Exception ex)
        {
            this.Successfull = false; // cambio mal hecho o hasta compra no procesada
            this.Data = ex.Message;
        }
    }
}
