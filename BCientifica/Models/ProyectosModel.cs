using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class ProyectosModel
    {
        public ProyectosModel()
        {
        }

        public ProyectosModel(int cod_Proyecto, string nombre, string descripcion, int cod_Rama, float precio, string autor, DateTime fecha_Creacion, string idioma)
        {
            Cod_Proyecto = cod_Proyecto;
            Nombre = nombre;
            Descripcion = descripcion;
            Cod_Rama = cod_Rama;
            Precio = precio;
            Autor = autor;
            Fecha_Creacion = fecha_Creacion;
            Idioma = idioma;
        }

        public int Cod_Proyecto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cod_Rama { get; set; }
        public float Precio { get; set; }
        public string Autor { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Idioma { get; set; }



    }
}
