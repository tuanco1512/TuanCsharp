using System;
namespace T2204M.houseAssignment.house.cm
{
    public class House : IHouse
    {
        private string soNha;
        private string diaChi;
        private string loaiNha;

        public House() { }

        public House(string soNha, string diaChi, string loaiNha)
        {
            this.soNha = soNha;
            this.diaChi = diaChi;
            this.loaiNha = loaiNha;
        }

        public string SoNha { get => soNha; set => soNha = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string LoaiNha { get => loaiNha; set => loaiNha = value; }

        public virtual void display()
        {
            throw new NotImplementedException();
        }

        public virtual void input()
        {
            throw new NotImplementedException();
        }
    }
}
