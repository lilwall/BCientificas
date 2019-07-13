using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class PrivilegiosModel
    {
        public PrivilegiosModel()
        {
        }

        public PrivilegiosModel(int cod_Privilegio, string privilegio)
        {
            Cod_Privilegio = cod_Privilegio;
            Privilegio = privilegio;
        }

        public int Cod_Privilegio { get; set; }
        public string Privilegio { get; set; }
    }
}
