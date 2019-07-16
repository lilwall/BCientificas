using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class ConsecutivosModel
    {
        public ConsecutivosModel()
        {
        }

        public ConsecutivosModel(int cod_Consecutivo, int cod_Tipo_Consecutivo, string descripcion, int valor, bool posee_Prefijo, string prefijo)
        {
            Cod_Consecutivo = cod_Consecutivo;
            Cod_Tipo_Consecutivo = cod_Tipo_Consecutivo;
            Descripcion = descripcion;
            Valor = valor;
            Posee_Prefijo = posee_Prefijo;
            Prefijo = prefijo;
        }

        public int Cod_Consecutivo { get; set; }
        public int Cod_Tipo_Consecutivo { get; set; }
        
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public Boolean Posee_Prefijo { get; set; }
        public string Prefijo { get; set; }
        

    }
}
