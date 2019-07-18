using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BCientificas.Models
{
    public class BitacoraExperimentalModel
    {
        public BitacoraExperimentalModel()
        {
        }

        public BitacoraExperimentalModel(int cod_Bitacora_Experimental, string objetivos, string descripcion, string equipo, string procedimientos, int cod_Experimentos, DateTime fecha, bool firma)
        {
            Cod_Bitacora_Experimental = cod_Bitacora_Experimental;
            Objetivos = objetivos;
            Descripcion = descripcion;
            Equipo = equipo;
            Procedimientos = procedimientos;
            Cod_Experimentos = cod_Experimentos;
            Fecha = fecha;
            Firma = firma;
        }

        [DataMember]
        public int Cod_Bitacora_Experimental { get; set; }
        [DataMember]
        public string Objetivos { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
        [DataMember]
        public string Equipo { get; set; }
        [DataMember]
        public string Procedimientos { get; set; }
        [DataMember]
        public int Cod_Experimentos { get; set; }
        [DataMember]
        public DateTime Fecha { get; set; }
        [DataMember]
        public Boolean Firma { get; set; }
    }
}
