using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
using BH.DataLayerSql;

namespace BH.BusinessLayer
{
    public class ManufacturerManager
    {
        public static List<ManufacturersModel> GetAllManufacturers()
        {
            SqlManufacturerProvider provider = new SqlManufacturerProvider;
            return provider.GetAllManufacturers();
        }

        public static ManufacturersModel GetManufacturersById(long Id)
        {
            SqlManufacturerProvider provider = new SqlManufacturerProvider;
            return provider.GetManufacturersById(Id);
        }

        public static long InsertManufacturers(ManufacturersModel Manufacturers)
        {
            SqlManufacturerProvider provider = new SqlManufacturerProvider;
            return provider.InsertManufacturers(Manufacturers);
        }

        public static bool UpdateManufacturers(ManufacturersModel manuFacturers)
        {
            SqlManufacturerProvider provider = new SqlManufacturerProvider;
            return provider.UpdateManufacturers(manuFacturers);
        }

        public static bool DeleteManufacturers(long Id)
        {
            SqlManufacturerProvider provider = new SqlManufacturerProvider;
            return provider.DeleteManufacturers(Id);
        }
    }
}
