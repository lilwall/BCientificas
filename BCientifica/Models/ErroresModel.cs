using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class ErroresModel
    {
        public ErroresModel()
        {
        }

        public ErroresModel(int cod_Error, DateTime fecha_Hora, int numero_Error, string descripcion, int cod_Usuario)
        {
            Cod_Error = cod_Error;
            Fecha_Hora = fecha_Hora;
            Numero_Error = numero_Error;
            Descripcion = descripcion;
            Cod_Usuario = cod_Usuario;
        }

        public int Cod_Error { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public int Numero_Error { get; set; }
        public string Descripcion { get; set; }
        public int Cod_Usuario { get; set; }
         


    }
}
