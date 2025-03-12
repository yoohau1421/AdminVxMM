using AdminV11.Models;

namespace AdminV11.Services
{
    public class db_DSKhachHang
    {
        public List<DSKhachHang> GetKH()
        {
            List<DSKhachHang> KhachHang = new List<DSKhachHang>();

            KhachHang.Add(new DSKhachHang
            {
                CUSTOMER_ID = "KH1",
                CYCLE_CODE = "VQ1",
                PRODUCT_CODE = "SP1",
                PRODUCT_NAME = "Dien Thoai",
                CUSTOMER_NAME = "Thien Hien",
                PHONE = 0123456789,
                EMAIL = "ThienHien@gmail.comn",
                SHORT_DESCRIPTION = "Yeu Nhau Tham Thiet",
                REWARD_STATUS = "1",
                REWARD_PROVIDER = "Nhân Viên A",
                WINNING_DATE = "1/1/2024",
                PROCESS_DATE = "5/5/2025"
            });
            KhachHang.Add(new DSKhachHang
            {
                CUSTOMER_ID = "KH2",
                CYCLE_CODE = "VQ2",
                PRODUCT_CODE = "SP2",
                PRODUCT_NAME = "Dien Dien",
                CUSTOMER_NAME = "Thien Hien Duyen",
                PHONE = 0546721342,
                EMAIL = "DuyenBeTi@gmail.comn",
                SHORT_DESCRIPTION = "Con Dau",
                REWARD_STATUS = "0",
                REWARD_PROVIDER = "Nhân Viên B",
                WINNING_DATE = "1/1/2031",
                PROCESS_DATE = "9/10/2031"
            });
            KhachHang.Add(new DSKhachHang
            {
                CUSTOMER_ID = "KH3",
                CYCLE_CODE = "VQ3",
                PRODUCT_CODE = "SP3",
                PRODUCT_NAME = "Ti Vi",
                CUSTOMER_NAME = "Ac",
                PHONE = 0565435433,
                EMAIL = "Ac@gmail.comn",
                SHORT_DESCRIPTION = "Con thu hai",
                REWARD_STATUS = "1",
                REWARD_PROVIDER = "Nhân Viên C",
                WINNING_DATE = "1/1/2032",
                PROCESS_DATE = "5/5/2032"
            });

            return KhachHang;
        }
    }
}
