using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.DataLayer;
using BH.Models;
using BH.Utility;

namespace BH.DataLayerSql
{
    public class SqlTokenProvider : ITokenProvider
    {
        public List<TokenModel> GetAllToken()
        {
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.GetAllToken, connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    List<TokenModel> tokenList = new List<TokenModel>();
                    tokenList = UtilityManager.DataReaderMapToList<TokenModel>(dataReader);
                    return tokenList;
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

        public TokenModel GetTokenById(long Id)
        {
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.GetTokenById, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TokenID", Id));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    TokenModel token = new TokenModel();
                    token = UtilityManager.DataReaderMap<TokenModel>(reader);
                    return token;
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

        public long InsertToken(TokenModel Token)
        {
            long id = 0;
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.InsertToken, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter returnValue = new SqlParameter("@" + "TokenID", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.Output;
                command.Parameters.Add(returnValue);
                foreach (var item in Token.GetType().GetProperties())
                {
                    if (item.Name != "TokenID")
                    {
                        string name = item.Name;
                        var value = item.GetValue(Token, null);

                        command.Parameters.Add(new SqlParameter("@" + name, value == null ? DBNull.Value : value));
                    }
                }
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    id = (int)command.Parameters["@TokenID"].Value;
                }
                catch (Exception ex)
                {
                    throw new Exception("Execption Adding Data. " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return id;
        }

        public bool UpdateToken(TokenModel token)
        {
            bool isUpdate = true;

            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.UpdateToken, connection);
                command.CommandType = CommandType.StoredProcedure;

                foreach (var item in token.GetType().GetProperties())
                {
                    string name = item.Name;
                    var value = item.GetValue(token, null);
                    command.Parameters.Add(new SqlParameter("@" + name, value == null ? DBNull.Value : value));
                }

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    isUpdate = false;
                    throw new Exception("Exception Updating Data." + e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return isUpdate;
        }

        public bool DeleteToken(long Id)
        {
            bool isDelete = true;
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.DeleteToken, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TokenID", Id));

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    isDelete = false;
                    throw new Exception("Exception Updating Data." + e.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return isDelete;
        }
    }
}
