using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayer
{
    public interface ICompanyDetailsProvider
    {
        CompanyDetailsModel GetCompanyDetails(long id);

    }
}
