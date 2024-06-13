using Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab_PSD.Repositories
{
    public class SupplementTypeRepository
    {
        static MyDatabaseEntities3 db = new MyDatabaseEntities3();
        public static List<suplementTypeId> getAllType()
        {
            return db.suplementTypeIds.ToList();
        }
    }
}