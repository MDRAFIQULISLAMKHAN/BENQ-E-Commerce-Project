using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  BH.Models;

namespace BH.DataLayer
{
    public interface ITokenProvider
    {
        List<TokenModel> GetAllToken();
        TokenModel GetTokenById(long Id);
        long InsertToken(TokenModel Token);
        bool UpdateToken(TokenModel token);
        bool DeleteToken(long Id);
    }
}
