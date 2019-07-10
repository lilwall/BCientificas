using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class PrivilegiosUsuariosModel
    {
        public int Cod_Privilegio { get; set; }
        public int Cod_Usuario { get; set; }
        public int Activo { get; set; }
        /// Activo es un bit en la base, se representa como bool?


    }
}
