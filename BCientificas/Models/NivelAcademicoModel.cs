using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class NivelAcademicoModel
    {
        public NivelAcademicoModel()
        {
        }

        public NivelAcademicoModel(int cod_Nivel_Academico, int tipo, string nombre, bool completado, string detalle)
        {
            Cod_Nivel_Academico = cod_Nivel_Academico;
            Tipo = tipo;
            Nombre = nombre;
            Completado = completado;
            Detalle = detalle;
        }

        public int Cod_Nivel_Academico { get; set; }
        public int Tipo { get; set; }
        public string Nombre { get; set; }
        public Boolean Completado { get; set; }
        public string Detalle { get; set; }

    }
}
