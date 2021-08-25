using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayer
{
    public interface ICartProvider
    {
        List<CartModel> GetAllCart();
        CartModel GetCartById(long Id);
        long InsertCart(CartModel Cart);
        bool UpdateCart(CartModel cart);
        bool DeleteCart(long Id);
    }
}
