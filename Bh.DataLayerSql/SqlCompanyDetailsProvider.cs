using System;
using System.Data;
using System.Data.SqlClient;
using BH.DataLayer;
using BH.DataLayerSql;
using BH.Utility;
using BH.Models;

namespace BH.DataLayerSql
{
    public class SqlCompanyDetailsProvider : ICompanyDetailsProvider
    {


        public CompanyDetailsModel GetCompanyDetails(long Id)
        {
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.GetCompanyDetails, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@CompanyDetailsID", Id));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    CompanyDetailsModel client = new CompanyDetailsModel();
                    client = UtilityManager.DataReaderMap<CompanyDetailsModel>(reader);
                    return client;
                }
                catch (Exception e)
                {
                    throw new Exception("Exception retrieving reviews. " + e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }

}
