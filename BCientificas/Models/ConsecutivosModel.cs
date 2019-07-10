using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class ConsecutivosModel
    {
        //Hacer constructores

        public int Cod_Consecutivo { get; set; }
        public int Tipo { get; set; }
        //Tipo es int?
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public int Posee_Prefijo { get; set; }
        public string Prefijo { get; set; }
        //posee prefijo bit o   int ?

    }
}
