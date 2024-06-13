using Project_Lab_PSD.Model;
using projectPSD.Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projectPSD.Project_Lab_PSD.Repositories
{
    public class TransactionRepository
    {
        public static List<TransaactionHeader> getAllHeaders()
        {
            MyDatabaseEntities3 db = new MyDatabaseEntities3();
            return db.TransaactionHeaders.ToList();
        }

        public static List<TransaactionHeader> getAllUserHeaders(int userID)
        {
            MyDatabaseEntities3 db = new MyDatabaseEntities3();
            return db.TransaactionHeaders.Where(testc => t.transaactionID == userID).ToList();
        }

        public static List<TransactionDetail> getDailyById(int transactionID)
        {
            MyDatabaseEntities3 db = new MyDatabaseEntities3();
            return db.TransactionDetails.Where(testc => t.transactionID.Equals(transactionID)).ToList();
        }

        public static TransaactionHeader getHeaderById(int id)
        {
            MyDatabaseEntities3 db = new MyDatabaseEntities3();
            return db.TransactionDetails.Find(id);
        }

        public static bool UpdateTransactionHeader(TransaactionHeader newTransaction)
        {
            MyDatabaseEntities3 db = new MyDatabaseEntities3 ();
            TransaactionHeader oldTransaction = db.TransaactionHeaders.Find(newTransaction.TransactionID);

            if (oldTransaction != null)
            {
                return false;
            }

            oldTransaction.UserId = newTransaction.UserId;
            oldTransaction.TransactionDate = newTransaction.TransactionDate;
            oldTransaction.Status = newTransaction.Status;
            db.SaveChanges();

            return true;
        }

        public static void AddHeader(TransaactionHeader header)
        {
            MyDatabaseEntities3 db = new MyDatabaseEntities3 ();
            db.TransaactionHeaders.Add(header);
            db.SaveChanges();

            return true;
        }

        public static void AddDetail(TransactionDetail detail)
        {
            MyDatabaseEntities3 db = new MyDatabaseEntities3();
            db.TransactionDetails.Add(detail);
            db.SaveChanges();
        }
    }
}