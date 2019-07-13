using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class RamasCientificasModel
    {
        public RamasCientificasModel()
        {
        }

        public RamasCientificasModel(int cod_Rama, string nombre)
        {
            Cod_Rama = cod_Rama;
            Nombre = nombre;
        }

        public int Cod_Rama { get; set; }
        public string Nombre { get; set; }

    }
}
