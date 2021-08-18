using BH.DataLayerSql;
using BH.Models;

namespace BH.BusinessLayer
{
    public class CompanyDetailsManager
    {
        public static CompanyDetailsModel GetCompanyDetails(long Id)
        {
            SqlCompanyDetailsProvider provider = new SqlCompanyDetailsProvider();
            return provider.GetCompanyDetails(Id);
        }
    }
}