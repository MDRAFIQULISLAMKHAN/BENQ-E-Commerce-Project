using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.DataLayerSql;
using BH.Models;

namespace BH.BusinessLayer
{
    public class TokenManager
    {
        public static List<TokenModel> GetAllToken()
        {
            SqlTokenProvider provider = new SqlTokenProvider();
            return provider.GetAllToken();
        }

        public static TokenModel GetTokenById(long Id)
        {
            SqlTokenProvider provider = new SqlTokenProvider();
            return provider.GetTokenById(Id);
        }

        public static long InsertToken(TokenModel Token)
        {
            SqlTokenProvider provider = new SqlTokenProvider();
            return provider.InsertToken(Token);
        }

        public static bool UpdateToken(TokenModel token)
        {
            SqlTokenProvider provider = new SqlTokenProvider();
            return provider.UpdateToken(token);
        }

        public static bool DeleteToken(long Id)
        {
            SqlTokenProvider provider = new SqlTokenProvider();
            return provider.DeleteToken(Id);
        }
    }
}
