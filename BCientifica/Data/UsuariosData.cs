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
    public class UsuariosData
    {
        public List<UsuariosModel> SelectData()
        {
            List<UsuariosModel> Usuarios_List = new List<UsuariosModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<UsuariosModel>(listParameters, "sp_Trae_Lista_Usuarios", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Usuarios_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Usuarios_List;
        }
    }
}