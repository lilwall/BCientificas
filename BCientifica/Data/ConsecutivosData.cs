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
    public class ConsecutivosData
    {
        public List<ConsecutivosModel> SelectData()
        {
            List<ConsecutivosModel> Consecutivos_List = new List<ConsecutivosModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<ConsecutivosModel>(listParameters, "sp_Trae_Lista_Consecutivos", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Consecutivos_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Consecutivos_List;
        }
    }
}