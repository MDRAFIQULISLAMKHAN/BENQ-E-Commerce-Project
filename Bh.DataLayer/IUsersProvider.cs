using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;
namespace BH.DataLayerSql
{
    public interface IUsersProvider
    {
        List<UsersModel> GetAllUsers();
        UsersModel GetUsersById(long Id);
        long InsertUsers(UsersModel Users);
        bool UpdateUsers(UsersModel users);
        bool DeleteUsers(long Id);
    }
}
