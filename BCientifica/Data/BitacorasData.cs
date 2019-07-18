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
    public class Bitacoras
    {
        public List<BitacorasModel> SelectData()
        {
            List<BitacorasModel> Bitacoras_List = new List<BitacorasModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<BitacorasModel>(listParameters, "sp_Trae_Lista_Bitacoras", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    Bitacoras_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return Bitacoras_List;
        }
    }
}