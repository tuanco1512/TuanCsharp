using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.QLSinhvien
{
    internal class QuanlySV
    {
        private List<Sinhvien> ListSinhVien = null;
        public QuanlySV()
        {
            ListSinhVien = new List<Sinhvien>();
        }
        private int GenerateID()
        {
            int max = 1;
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach(Sinhvien sv in ListSinhVien)
                {
                    if (max < sv.ID)
                    {
                        max = sv.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public int SoLuongSinhVien()
        {
            int Count = 0;
            if(ListSinhVien != null)
            {
                Count = ListSinhVien.Count;
            }
            return Count;
        }
        public void NhapSinhVien()
        {
            Sinhvien sv = new Sinhvien();
            sv.ID = GenerateID();
            Console.Write("Nhap ten sinh vien: ");
            sv.Name = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap gioi tinh sinh vien: ");
            sv.Gender = Convert.ToString(Console.ReadLine());

            Console.Write("Nhap tuoi sinh vien: ");
            sv.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap diem toan: ");
            sv.Math = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem ly: ");
            sv.Physics = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem hoa: ");
            sv.Chemistry = Convert.ToDouble(Console.ReadLine());

            TinhDTB(sv);
            XepLoaiHocLuc(sv);

            ListSinhVien.Add(sv);
        }
        public void UpdateSinhVien(int ID)
        {
            Sinhvien sv = FindByID(ID);
            if (sv != null)
            {
                Console.Write("Nhap ten sinh vien: ");
                String name = Convert.ToString(Console.ReadLine());
                if(name != null && name.Length > 0)
                {
                    sv.Name = name;
                }

                Console.Write("Nhap gioi tinh sinh vien: ");
                String gender = Convert.ToString(Console.ReadLine());
                if (gender != null && gender.Length > 0)
                {
                    sv.Gender = gender;
                }

                Console.Write("Nhap tuoi sinh vien: ");
                String ageStr = Convert.ToString(Console.ReadLine());
                if(ageStr != null && ageStr.Length > 0)
                {
                    sv.Age = Convert.ToInt32(ageStr);
                }

                Console.Write("Nhap diem toan: ");
                String mathStr = Convert.ToString(Console.ReadLine());
                if(mathStr != null && mathStr.Length > 0)
                {
                    sv.Math = Convert.ToInt32(mathStr);
                }

                Console.Write("Nhap diem ly: ");
                string physicsStr = Convert.ToString(Console.ReadLine());
                if (physicsStr != null && physicsStr.Length > 0)
                {
                    sv.Physics = Convert.ToDouble(physicsStr);
                }

                Console.Write("Nhap diem hoa: ");
                string chemistryStr = Convert.ToString(Console.ReadLine());
                if (chemistryStr != null && chemistryStr.Length > 0)
                {
                    sv.Chemistry = Convert.ToDouble(chemistryStr);
                }

                TinhDTB(sv);
                XepLoaiHocLuc(sv);
            }
            else
            {
                Console.WriteLine("Sinh vien co ID = {0} khong ton tai.", ID);
            }
        }
        public void SortByID()
        {
            ListSinhVien.Sort(delegate (Sinhvien sv1, Sinhvien sv2)
            {
                return sv1.ID.CompareTo(sv2.ID);
            });
        }
        public void SortByName()
        {
            ListSinhVien.Sort(delegate (Sinhvien sv1, Sinhvien sv2)
            {
                return sv1.Name.CompareTo(sv2.Name);
            });
        }
        public void SortByDiemTB()
        {
            ListSinhVien.Sort(delegate (Sinhvien sv1, Sinhvien sv2)
            {
                return sv1.Average_score.CompareTo(sv2.Average_score);
            });
        }
        public Sinhvien FindByID(int ID)
        {
            Sinhvien searchResult = null;
            if (ListSinhVien != null && ListSinhVien.Count > 0) 
            {
                foreach(Sinhvien sv in ListSinhVien)
                {
                    if (sv.ID == ID)
                    {
                        searchResult = sv;
                    }
                }
            }
            return searchResult;
        }
        public List<Sinhvien> FindByName(String keyword)
        {
            List<Sinhvien> searchResult = new List<Sinhvien>();
            if (ListSinhVien != null && ListSinhVien.Count > 0)
            {
                foreach(Sinhvien sv in ListSinhVien)
                {
                    if (sv.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(sv);
                    }
                }
            }
            return searchResult;
        }
        public bool DeleteById(int ID)
        {
            bool IsDeleted = false;
            Sinhvien sv = FindByID(ID);
            if(sv != null)
            {
                IsDeleted = ListSinhVien.Remove(sv);
            }
            return IsDeleted;
        }
        private void TinhDTB(Sinhvien sv)
        {
            double DiemTB = (sv.Math + sv.Physics + sv.Chemistry) / 3;
            sv.Average_score = Math.Round(DiemTB, 2, MidpointRounding.AwayFromZero);
        }
        private void XepLoaiHocLuc(Sinhvien sv)
        {
            if(sv.Average_score >= 8)
            {
                sv.Rate = "Gioi";
            }
            else if(sv.Average_score >= 6.5)
            {
                sv.Rate = "Kha";
            }
            else if(sv.Average_score >= 5)
            {
                sv.Rate = "Trung Binh";
            }
            else
            {
                sv.Rate = "Yeu";
            }
        }
        public void ShowSinhVien(List<Sinhvien> listSV)
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}", "ID", "Name", "Gender", "Age", "Math", "Physics", "Chemistry", "Average score", "Rate");
            if(listSV != null && listSV.Count > 0)
            {
                foreach(Sinhvien sv in listSV)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}", sv.ID, sv.Name, sv.Gender, sv.Age, sv.Math, sv.Physics, sv.Chemistry, sv.Average_score, sv.Rate);
                }
            }
            Console.WriteLine();
        }
        public List<Sinhvien> getListSinhVien()
        {
            return ListSinhVien;
        }
    }
}
