using System;
using T2204M.houseAssignment.house.cm;

namespace T2204M.houseAssignment.house.hanoi
{
    public class HaNoiHouse : House
    {
        private string tenQuan;

        public HaNoiHouse() { }

        public HaNoiHouse(string soNha, string diaChi, string loaiNha, string tenQuan) : base (soNha, diaChi, loaiNha)
        {
            this.SoNha = soNha;
            this.DiaChi = diaChi;
            this.LoaiNha = loaiNha;
            this.tenQuan= tenQuan;
        }

        public string TenQuan { get => tenQuan; set => tenQuan = value; }

        public override void display()
        {
            base.display();
        }

        public override void input()
        {
            base.input();
        }
    }
}
