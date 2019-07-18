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
    public class ErroresData
    {
        public List<ErroresModel> SelectData()
        {
            List<ErroresModel> Errores_List = new List<ErroresModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<ErroresModel>(listParameters, "sp_Trae_Lista_Errores", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Errores_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Errores_List;
        }
    }
}