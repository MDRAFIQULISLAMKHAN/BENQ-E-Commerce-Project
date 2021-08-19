using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface IManufacturersProvider
    {
        List<ManufacturersModel> GetAllManufacturers();
        ManufacturersModel GetManufacturersById(long Id);
        long InsertManufacturers(ManufacturersModel Manufacturers);
        bool UpdateManufacturers(ManufacturersModel manuFacturers);
        bool DeleteManufacturers(long Id);
    }
}
