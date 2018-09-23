using System;
using System.Collections.Generic;
using System.Text;

namespace Magazzino.Models.Infraestruture
{
     public  class BaseViewModel
    {
        public int? Id { get; set; } // Comunica El viewModel, con la clase tipo tabla para
        //mandarla a eliminar modifica o hasta agregar un campo en esa tabla
        public string RowId { get; set; } // Para eliminar varias filas en tablas en general
    }
}
