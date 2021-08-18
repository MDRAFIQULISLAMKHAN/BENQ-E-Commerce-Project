using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
     public interface ICompanyDetailsProvider
    {
        List<CompanyDetailsModel> GetAllCompanyDetails();
        CompanyDetailsModel GetCompanyDetailsById(long Id);
        long InsertCompanyDetails(CompanyDetailsModel Company);
        bool UpdateCompanyDetails(CompanyDetailsModel company);
        bool DeleteCompanyDetails(long Id);
    }
}
