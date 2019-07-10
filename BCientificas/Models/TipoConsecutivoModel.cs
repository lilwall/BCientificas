using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class TipoConsecutivoModel
    {
        public TipoConsecutivoModel()
        {
        }

        public TipoConsecutivoModel(int cod_Tipo_Consecutivo, string tipo_Consecutivo)
        {
            Cod_Tipo_Consecutivo = cod_Tipo_Consecutivo;
            Tipo_Consecutivo = tipo_Consecutivo;
        }

        public int Cod_Tipo_Consecutivo { get; set; }
        public string Tipo_Consecutivo { get; set; }

    }
}
