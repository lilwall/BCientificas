using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class NivelAcademicoModel
    {
        // hacer constructores 
        public int Cod_Nivel_Academico { get; set; }
        public int Tipo { get; set; }
        public string Nombre { get; set; }
        public string Completado { get; set; }

        /// Completado es bit o boolean?
        public string Detalle { get; set; }

    }
}
