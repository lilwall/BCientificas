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
    public class PrivilegiosData
    {
        public List<PrivilegiosModel> SelectData()
        {
            List<PrivilegiosModel> Privilegios_List = new List<PrivilegiosModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<PrivilegiosModel>(listParameters, "sp_Trae_Lista_Privilegios", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Privilegios_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Privilegios_List;
        }
    }
}