using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class DescargasModel
    {
        public DescargasModel()
        {
        }

        public DescargasModel(int cod_Descargas, int cod_Usuario, DateTime fecha, int cod_Proyecto)
        {
            Cod_Descargas = cod_Descargas;
            Cod_Usuario = cod_Usuario;
            Fecha = fecha;
            Cod_Proyecto = cod_Proyecto;
        }

        public int Cod_Descargas { get; set; }
        public int Cod_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int Cod_Proyecto { get; set; }
    }
}
