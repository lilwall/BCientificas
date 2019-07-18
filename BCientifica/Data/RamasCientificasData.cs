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
    public class RamasCientificasData
    {
        public List<RamasCientificasModel> SelectData()
        {
            List<RamasCientificasModel> RamasCientificas_List = new List<RamasCientificasModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<RamasCientificasModel>(listParameters, "sp_Trae_Lista_RamasCientificas", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    RamasCientificas_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return RamasCientificas_List;
        }
    }
}