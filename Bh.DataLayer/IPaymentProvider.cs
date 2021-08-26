using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.Models;

namespace BH.DataLayer
{
    public interface IPaymentProvider
    {
        List<PaymentModel> GetAllPayment();
        PaymentModel GetPaymentById(long Id);
        long InsertPayment(PaymentModel Payment);
        bool UpdatePayment(PaymentModel payment);
        bool DeletePayment(long Id);
    }
}
