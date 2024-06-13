using Project_Lab_PSD.Modul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectPSD.Project_Lab_PSD.Controller
{
    public class TransactionController
    {
        public static Response<TransaactionHeader> getAllHeaders()
        {
            return transaction.Handler.GetAllHeaders();
        }

        public static Response<List<TransaactionHeader>> getUserHeader(int userId)
        {
            if (userId == 0)
            {
                return new Response<List<TransaactionHeader>>(false, "User ID is required", null)
            }

            return transactionhandler
        }
    }
}