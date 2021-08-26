using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.DataLayerSql;
using BH.Models;

namespace BH.BusinessLayer
{
    public class PaymentManager
    {
        public static List<PaymentModel> GetAllPayment()
        {
            SqlPaymentProvider provider = new SqlPaymentProvider();
            return provider.GetAllPayment();
        }

        public static PaymentModel GetPaymentById(long Id)
        {
            SqlPaymentProvider provider = new SqlPaymentProvider();
            return provider.GetPaymentById(Id);
        }

        public static long InsertPayment(PaymentModel Payment)
        {
            SqlPaymentProvider provider = new SqlPaymentProvider();
            return provider.InsertPayment(Payment);
        }

        public static bool UpdatePayment(PaymentModel payment)
        {
            SqlPaymentProvider provider = new SqlPaymentProvider();
            return provider.UpdatePayment(payment);
        }

        public static bool DeletePayment(long Id)
        {
            SqlPaymentProvider provider = new SqlPaymentProvider();
            return provider.DeletePayment(Id);
        }
    }
}
