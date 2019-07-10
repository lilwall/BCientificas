using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class BitacorasModel
    {
        #region Constructor

        public BitacorasModel()
        {
        }

        public BitacorasModel(int cod_Usuario, DateTime fecha_Inicio, DateTime fecha_Final, int tipo, string descripcion, string link, DateTime fecha_Hora, string consecutivo, string registro_Detalle, int cod_Bitacora)
        {
            Cod_Usuario = cod_Usuario;
            Fecha_Inicio = fecha_Inicio;
            Fecha_Final = fecha_Final;
            Tipo = tipo;
            Descripcion = descripcion;
            Link = link;
            Fecha_Hora = fecha_Hora;
            Consecutivo = consecutivo;
            Registro_Detalle = registro_Detalle;
            Cod_Bitacora = cod_Bitacora;
        }
        #endregion 

        public int Cod_Usuario { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Final { get; set; }
        public int Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Link { get; set; }
        public DateTime Fecha_Hora { get; set; }
        public string Consecutivo { get; set; }
        public string Registro_Detalle { get; set; }
        public int Cod_Bitacora { get; set; }

    }
}
