using System;
namespace T2204M.Tiendien
{
    public class KhachhangVN : Khachhang
    {
        private string doiTuong;
        private string DoiTuong { get => doiTuong; set => doiTuong = value; }

        public KhachhangVN(string code, String fullName, String invoiceDate, int qty, String doiTuong) : base(code, fullName, invoiceDate, qty)
        {
        }

        public override double caculatedMoney()
        {
            if(Qty < 50)
            return Qty * 1000;
        else if (Qty < 100)
                return 50 * 1000 + (Qty - 50) * 1200;
            else if (Qty < 200)
                return 50 * 1000 + 50 * 1200 + (Qty - 100) * 1500;
            else
                return 50 * 1000 + 50 * 1200 + 100 * 1500 + (Qty - 200) * 2000;
        }
    }
}
