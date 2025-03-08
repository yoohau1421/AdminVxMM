using AdminV11.Models;
using System;

namespace AdminV11.Services
{
    public class db_DSVoucher
    {
        public List<DSVoucher> GetDSVouchers() 
        {
            List<DSVoucher> dSVoucher = new List<DSVoucher>();

            dSVoucher.Add(new DSVoucher { ID = "DS1", NAME = "TênABC", DESCRIPTION = "Mô Tả 1", VALUE = 5000, VOUCHERSTATUS = "1" });
            dSVoucher.Add(new DSVoucher { ID = "DS2", NAME = "TênVBN", DESCRIPTION = "Mô Tả 2", VALUE = 15000, VOUCHERSTATUS = "0" });
            dSVoucher.Add(new DSVoucher { ID = "DS3", NAME = "TênNMB", DESCRIPTION = "Mô Tả 3", VALUE = 25000, VOUCHERSTATUS = "1" });
            dSVoucher.Add(new DSVoucher { ID = "DS4", NAME = "TênACD", DESCRIPTION = "Mô Tả 4", VALUE = 35000, VOUCHERSTATUS = "0" });
            dSVoucher.Add(new DSVoucher { ID = "DS5", NAME = "TênWER", DESCRIPTION = "Mô Tả 5", VALUE = 45000, VOUCHERSTATUS = "1" });
            dSVoucher.Add(new DSVoucher { ID = "DS6", NAME = "TênYUI", DESCRIPTION = "Mô Tả 6", VALUE = 55000, VOUCHERSTATUS = "0" });

            return dSVoucher;
        }

    }
}
