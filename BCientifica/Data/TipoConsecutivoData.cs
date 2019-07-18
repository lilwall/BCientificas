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
    public class TipoConsecutivoData
    {
        public List<TipoConsecutivoModel> SelectData()
        {
            List<TipoConsecutivoModel> TipoConsecutivos_List = new List<TipoConsecutivoModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<TipoConsecutivoModel>(listParameters, "sp_Trae_Lista_TipoConsecutivos", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    TipoConsecutivos_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return TipoConsecutivos_List;
        }
    }
}