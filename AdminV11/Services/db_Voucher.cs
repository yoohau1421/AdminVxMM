using AdminV11.Models;

namespace AdminV11.Services
{
    public class db_Voucher
    {
        public List<Voucher> GetVouchers() 
        {
            List<Voucher> voucher = new List<Voucher>();

            voucher.Add(new Voucher { CYCLE_CODE = "VQ1", PRODUCT_CODE = "SP1", PRODUCT_NAME = "Ti Vi", STATUS_CODE = "1", UPDATE_DATE = "1/1/1111" });
            voucher.Add(new Voucher { CYCLE_CODE = "VQ2", PRODUCT_CODE = "SP2", PRODUCT_NAME = "Tu Lanh", STATUS_CODE = "0", UPDATE_DATE = "1/1/2222" });
            voucher.Add(new Voucher { CYCLE_CODE = "VQ3", PRODUCT_CODE = "SP3", PRODUCT_NAME = "May Giat", STATUS_CODE = "1", UPDATE_DATE = "1/1/3333" });
            voucher.Add(new Voucher { CYCLE_CODE = "VQ4", PRODUCT_CODE = "SP4", PRODUCT_NAME = "Xe Dap", STATUS_CODE = "0", UPDATE_DATE = "1/1/4444" });
            voucher.Add(new Voucher { CYCLE_CODE = "VQ5", PRODUCT_CODE = "SP5", PRODUCT_NAME = "Xe May", STATUS_CODE = "1", UPDATE_DATE = "1/1/5555" });
            voucher.Add(new Voucher { CYCLE_CODE = "VQ6", PRODUCT_CODE = "SP6", PRODUCT_NAME = "Ghe", STATUS_CODE = "0", UPDATE_DATE = "1/1/6666" });

            return voucher;
        }
    }
}
