using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PG.CONNECTOR;
using BCientificas.Models;
using System.Data;
using System.Configuration;

namespace BCientificas.Data
{
    public class ProyectosData
    {
        public List<ProyectosModel> SelectData()
        {
            List<ProyectosModel> Proyectos_List = new List<ProyectosModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<ProyectosModel>(listParameters, "sp_Trae_Lista_Proyectos", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Proyectos_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Proyectos_List;
        }
    }
}