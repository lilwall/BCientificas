using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class PrivilegiosUsuariosModel
    {
        public PrivilegiosUsuariosModel()
        {
        }

        public PrivilegiosUsuariosModel(int cod_Privilegio, int cod_Usuario, bool activo)
        {
            Cod_Privilegio = cod_Privilegio;
            Cod_Usuario = cod_Usuario;
            Activo = activo;
        }

        public int Cod_Privilegio { get; set; }
        public int Cod_Usuario { get; set; }
        public Boolean Activo { get; set; }
        

    }
}
