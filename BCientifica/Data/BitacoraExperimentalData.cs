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
    public class BitacoraExperimentalData
    {
        public List<BitacoraExperimentalModel> SelectData()
        {
            List<BitacoraExperimentalModel> BitacoraExperimental_List = new List<BitacoraExperimentalModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<BitacoraExperimentalModel>(listParameters, "sp_Trae_Lista_BitacoraExperimental", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    BitacoraExperimental_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return BitacoraExperimental_List;
        }
    }
}