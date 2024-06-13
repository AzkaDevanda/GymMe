using Project_Lab_PSD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_Lab_PSD.Repositories
{
    public class SupplementFactory
    {
        public static MsSupplement CreateSupplement(int id,string name, DateTime expiry, int price, int typeID) 
        {
            return new MsSupplement()
            {
                SupplementID = id,
                SupplementName = name,
                SupplementExpiryDate = expiry,
                SupplementPrice = price,
                SupplementTypeID = typeID
            };
        }
    }
}