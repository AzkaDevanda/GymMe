using Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab_PSD.Repositories
{
    public class SupplementRepository
    {

        static MyDatabaseEntities3 db = new MyDatabaseEntities3();

        public static List<MsSupplement> GetMsSupplements()
        {
            return db.MsSupplements.ToList();
        }

        public static void AddSupplement(MsSupplement supplement)
        {
            db.MsSupplements.Add(supplement);
            db.SaveChanges();
        }

        public static MsSupplement GetSupplementById(int id)
        {
            return db.MsSupplements.Find(id);
        }

        public static bool UpdateSupplement(MsSupplement newSupplement)
        {
            MsSupplement oldSupplement = db.MsSupplements.Find(newSupplement.SupplementID);

            if (oldSupplement == null) 
            {
                return false;
            }

            oldSupplement.SupplementName = newSupplement.SupplementName;
            oldSupplement.SupplementExpiryDate = newSupplement.SupplementExpiryDate;
            oldSupplement.SupplementPrice = newSupplement.SupplementPrice;
            oldSupplement.SupplementTypeID = newSupplement.SupplementTypeID;
            db.SaveChanges();

            return true;

        }

        public static bool DeleteSupplement(int summplementId)
        {
            MsSupplement deleted = db.MsSupplements.Find(summplementId);

            if(deleted == null)
            {
                return false ;
            }

            db.MsSupplements.Remove(deleted);
            db.SaveChanges();

            return true;
        }

    }
}