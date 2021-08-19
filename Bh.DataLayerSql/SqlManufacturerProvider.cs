using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayer;
using System.Data.SqlClient;

namespace BH.DataLayerSql
{
    public class SqlManufacturerProvider
    {
        public List<ManufacturersModel> GetAllManufacturers()
        {
            using (SqlConnection connection = new SqlConnection(CommonUtility.ConnectionString))
            {
                SqlCommand command = new SqlCommand(StoreProcedure.Get)
            }
        }
    }
}
