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
    public class SqlPaymentProvider : IPaymentProvider
    {

        public List<PaymentModel> GetAllPayment()
        {
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.GetAllPayment, connection);
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    List<PaymentModel> paymentList = new List<PaymentModel>();
                    paymentList = UtilityManager.DataReaderMapToList<PaymentModel>(dataReader);
                    return paymentList;
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

        public PaymentModel GetPaymentById(long Id)
        {
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.GetPaymentById, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PaymentID", Id));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    PaymentModel payment = new PaymentModel();
                    payment = UtilityManager.DataReaderMap<PaymentModel>(reader);
                    return payment;
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

        public long InsertPayment(PaymentModel Payment)
        {
            long id = 0;
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.InsertPayment, connection);
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter returnValue = new SqlParameter("@" + "PaymentID", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.Output;
                command.Parameters.Add(returnValue);
                foreach (var item in Payment.GetType().GetProperties())
                {
                    if (item.Name != "PaymentID")
                    {
                        string name = item.Name;
                        var value = item.GetValue(Payment, null);

                        command.Parameters.Add(new SqlParameter("@" + name, value == null ? DBNull.Value : value));
                    }
                }
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    id = (int)command.Parameters["@PaymentID"].Value;
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

        public bool UpdatePayment(PaymentModel payment)
        {
            bool isUpdate = true;

            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.UpdatePayment, connection);
                command.CommandType = CommandType.StoredProcedure;

                foreach (var item in payment.GetType().GetProperties())
                {
                    string name = item.Name;
                    var value = item.GetValue(payment, null);
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

        public bool DeletePayment(long Id)
        {
            bool isDelete = true;
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.DeletePayment, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PaymentID", Id));

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
