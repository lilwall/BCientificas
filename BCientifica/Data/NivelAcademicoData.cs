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
    public class NivelAcademicoData
    {
        public List<NivelAcademicoModel> SelectData()
        {
            List<NivelAcademicoModel> NivelAcademico_List = new List<NivelAcademicoModel>();
            ConnectorDB connectorDB = new ConnectorDB();
            try
            {
                string connectionString = ConfigurationManager.AppSettings["connectionString"];
                List<Parameter<object>> listParameters = new List<Parameter<object>>();
                var requestDB = connectorDB.RequestData<NivelAcademicoModel>(listParameters, "sp_Trae_Lista_NivelAcademico", connectionString);
                if (requestDB.MessageCode == 0)
                {
                    NivelAcademico_List = requestDB.ObjectReturned;
                }

            }
            catch (Exception oEx)
            {
                Console.WriteLine(oEx.ToString());

            }
            return NivelAcademico_List;
        }
    }
}