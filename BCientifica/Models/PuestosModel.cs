using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class PuestosModel
    {
        public PuestosModel()
        {
        }

        public PuestosModel(int cod_Puesto, string nombre)
        {
            Cod_Puesto = cod_Puesto;
            Nombre = nombre;
        }

        public int Cod_Puesto { get; set; }
        public string Nombre { get; set; }

    }
}
