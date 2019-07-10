﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BCientificas.Models
{
    public class BitacoraExperimentalModel
    {
        public BitacoraExperimentalModel()
        {
        }

        public BitacoraExperimentalModel(int cod_Bitacora_Experimental, string objetivos, string descripcion, string equipo, string procedimientos, int cod_Experimentos, DateTime fecha)
        {
            Cod_Bitacora_Experimental = cod_Bitacora_Experimental;
            Objetivos = objetivos;
            Descripcion = descripcion;
            Equipo = equipo;
            Procedimientos = procedimientos;
            Cod_Experimentos = cod_Experimentos;
            Fecha = fecha;
        }

        public int Cod_Bitacora_Experimental { get; set; }
        public string Objetivos { get; set; }
        public string Descripcion { get; set; }
        public string Equipo { get; set; }
        public string Procedimientos { get; set; }
        public int Cod_Experimentos { get; set; }
        public DateTime Fecha { get; set; }
    }
}
