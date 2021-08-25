using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.DataLayerSql;
using BH.Models;

namespace BH.BusinessLayer 
{
    public class CartManager
    {
        public static List<CartModel> GetAllCart()
        {
            SqlCartProvider provider = new SqlCartProvider();
            return provider.GetAllCart();
        }

        public static CartModel GetCartById(long Id)
        {
            SqlCartProvider provider = new SqlCartProvider();
            return provider.GetCartById(Id);
        }

        public static long InsertCart(CartModel Cart)
        {
            SqlCartProvider provider = new SqlCartProvider();
            return provider.InsertCart(Cart);
        }

        public static bool UpdateCart(CartModel cart)
        {
            SqlCartProvider provider = new SqlCartProvider();
            return provider.UpdateCart(cart);
        }


        public static bool DeleteCart(long Id)
        {
            SqlCartProvider provider = new SqlCartProvider();
            return provider.DeleteCart(Id);
        }
    }
}
