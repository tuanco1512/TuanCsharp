using System;
using System.Transactions;

namespace T2204M.Tiendien
{
    public class KhachhangNN : Khachhang
    {
        public string country;

        public string Country { get => country; set => country = value; }

        public KhachhangNN(string code, string fullName, string invoiceDate, int qty, string country) : base(code, fullName, invoiceDate, qty)
        {
            this.country = country;
        }

        public override double caculatedMoney()
        {
            double caculate = 0;
            caculate = this.Qty * 2000;
            return caculate;
        }
    }
}
