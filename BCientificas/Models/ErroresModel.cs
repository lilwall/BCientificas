using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class ErroresModel
    {
        //Hacer constructores cuando se tengan todas las propiedades 

        public int Cod_Error { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public int Numero_Error { get; set; }
        public string Descripcion { get; set; }
        public int Cod_Usuario { get; set; }
         ///Faltan Propiedades, no se ve en la foto


    }
}
