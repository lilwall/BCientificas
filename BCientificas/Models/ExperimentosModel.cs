using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class ExperimentosModel
    {
        public ExperimentosModel()
        {
        }

        public ExperimentosModel(int cod_Experimento, int cod_Proyecto, string nombre, int cod_Usuario)
        {
            Cod_Experimento = cod_Experimento;
            Cod_Proyecto = cod_Proyecto;
            Nombre = nombre;
            Cod_Usuario = cod_Usuario;
        }

        public int Cod_Experimento { get; set; }
        public int Cod_Proyecto { get; set; }
        public string Nombre { get; set; }
        public int Cod_Usuario { get; set; }


    }
}
