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
    public class DescargasData
    {
        public List<DescargasModel> SelectData()
        {
            List<DescargasModel> Descargas_List = new List<DescargasModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<DescargasModel>(listParameters, "sp_Trae_Lista_Descargas", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Descargas_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Descargas_List;
        }
    }
}