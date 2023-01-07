using System;
namespace T2204M.Tiendien
{
    public abstract class Khachhang
    {
        private string code;
        private string fullName;
        private string invoiceDate;
        private int qty;

        public string Code { get => code; set => code = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string InvoiceDate { get => invoiceDate; set => invoiceDate = value; }
        public int Qty { get => qty; set => qty = value; }

        public Khachhang(String code, String fullName, String invoiceDate, int qty)
        {
            this.code = code;
            this.fullName = fullName;
            this.invoiceDate = invoiceDate;
            this.qty = qty;
        }

        public abstract double caculatedMoney();
    }
}
