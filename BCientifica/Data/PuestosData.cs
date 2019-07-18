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
    public class PuestosData
    {
        public List<PuestosModel> SelectData()
        {
            List<PuestosModel> Puestos_List = new List<PuestosModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<PuestosModel>(listParameters, "sp_Trae_Lista_Puestos", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Puestos_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Puestos_List;
        }
    }
}