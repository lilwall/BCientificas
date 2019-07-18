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
    public class PrivilegiosUsuario
    {
        public List<PrivilegiosUsuariosModel> SelectData()
        {
            List<PrivilegiosUsuariosModel> PrivilegiosUsuario_List = new List<PrivilegiosUsuariosModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<PrivilegiosUsuariosModel>(listParameters, "sp_Trae_Lista_PrivilegiosUsuario", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    PrivilegiosUsuario_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return PrivilegiosUsuario_List;
        }
    }
}