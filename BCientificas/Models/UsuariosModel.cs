using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class UsuariosModel
    {
        #region Constructores
        public UsuariosModel()
        {
        }

        public UsuariosModel(int cod_Usuario, string nombre, string primer_Apellido, string segundo_Apellido, int telefono, string username, string pass, float easy_Pay, string rol, int cod_Nivel_Academico, int cod_Puesto)
        {
            Cod_Usuario = cod_Usuario;
            Nombre = nombre;
            Primer_Apellido = primer_Apellido;
            Segundo_Apellido = segundo_Apellido;
            Telefono = telefono;
            Username = username;
            Pass = pass;
            Easy_Pay = easy_Pay;
            Rol = rol;
            Cod_Nivel_Academico = cod_Nivel_Academico;
            Cod_Puesto = cod_Puesto;
        }
        #endregion

        #region A
        public int Cod_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Primer_Apellido { get; set; }
        public string Segundo_Apellido { get; set; }
        public int Telefono { get; set; }
        public string Username { get; set; }
        public string Pass { get; set; }
        public float Easy_Pay { get; set; }
        public string Rol { get; set; }
        public int Cod_Nivel_Academico { get; set; }
        public int Cod_Puesto { get; set; }

        #endregion



    }
}
