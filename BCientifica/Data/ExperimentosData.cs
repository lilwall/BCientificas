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
    public class ExperimentosData
    {
        public List<ExperimentosModel> SelectData()
        {
            List<ExperimentosModel> Experimentos_List = new List<ExperimentosModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<ExperimentosModel>(listParameters, "sp_Trae_Lista_Experimentos", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Experimentos_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Experimentos_List;
        }
    }
}