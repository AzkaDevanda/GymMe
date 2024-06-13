using Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectPSD.Project_Lab_PSD.Factory
{
    public class TransactionFactory
    {
        public static TransaactionHeader createHeader(int userID, DateTime transactionDate, string status)
        {
            return new TransaactionHeader()
            {
                UserId = userID,
                TransactionDate = transactionDate,
                Status = status
            };
        }

        public static TransactionDetail createDetail(int transactionID, int supplementID, int quantity)
        {
            return new TransactionDetail()
            {
                TransactionID = transactionID,
                SupplementID = supplementID,
                Quantity = quantity
            };
        }
    }
}