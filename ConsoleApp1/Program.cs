using T2204M.session1;
using T2204M.session2;
using System.Collections.Generic;
using T2204M.session3;
using T2204M.session4;
using System.Net.Http;
using T2204M.session5;
using Newtonsoft.Json;
using T2204M.Tiendien;
using T2204M.interfaceAssignment;
using T2204M.QLSinhvien;

public class Program
{
    public static void Main(string[] args)
    {
        QuanlySV quanLySinhVien = new QuanlySV();

        while (true)
        {
            Console.WriteLine("\nCHUONG TRINH QUAN LY SINH VIEN C#");
            Console.WriteLine("*************************MENU**************************");
            Console.WriteLine("**  1. Them sinh vien.                               **");
            Console.WriteLine("**  2. Cap nhat thong tin sinh vien boi ID.          **");
            Console.WriteLine("**  3. Xoa sinh vien boi ID.                         **");
            Console.WriteLine("**  4. Tim kiem sinh vien theo ten.                  **");
            Console.WriteLine("**  5. Sap xep sinh vien theo diem trung binh (GPA). **");
            Console.WriteLine("**  6. Sap xep sinh vien theo ten.                   **");
            Console.WriteLine("**  7. Sap xep sinh vien theo ID.                    **");
            Console.WriteLine("**  8. Hien thi danh sach sinh vien.                 **");
            Console.WriteLine("**  0. Thoat                                         **");
            Console.WriteLine("*******************************************************");
            Console.Write("Nhap tuy chon: ");
            int key = Convert.ToInt32(Console.ReadLine());
            switch (key)
            {
                case 1:
                    Console.WriteLine("\n1. Them sinh vien.");
                    quanLySinhVien.NhapSinhVien();
                    Console.WriteLine("\nThem sinh vien thanh cong!");
                    break;
                case 2:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n2. Cap nhat thong tin sinh vien. ");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        quanLySinhVien.UpdateSinhVien(id);
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 3:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        int id;
                        Console.WriteLine("\n3. Xoa sinh vien.");
                        Console.Write("\nNhap ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        if (quanLySinhVien.DeleteById(id))
                        {
                            Console.WriteLine("\nSinh vien co id = {0} da bi xoa.", id);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 4:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n4. Tim kiem sinh vien theo ten.");
                        Console.Write("\nNhap ten de tim kiem: ");
                        string name = Convert.ToString(Console.ReadLine());
                        List<Sinhvien> searchResult = quanLySinhVien.FindByName(name);
                        quanLySinhVien.ShowSinhVien(searchResult);
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 5:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n5. Sap xep sinh vien theo diem trung binh (GPA).");
                        quanLySinhVien.SortByDiemTB();
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 6:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n6. Sap xep sinh vien theo ten.");
                        quanLySinhVien.SortByName();
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 7:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n6. Sap xep sinh vien theo ID.");
                        quanLySinhVien.SortByID();
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 8:
                    if (quanLySinhVien.SoLuongSinhVien() > 0)
                    {
                        Console.WriteLine("\n7. Hien thi danh sach sinh vien.");
                        quanLySinhVien.ShowSinhVien(quanLySinhVien.getListSinhVien());
                    }
                    else
                    {
                        Console.WriteLine("\nSanh sach sinh vien trong!");
                    }
                    break;
                case 0:
                    Console.WriteLine("\nBan da chon thoat chuong trinh!");
                    return;
                default:
                    Console.WriteLine("\nKhong co chuc nang nay!");
                    Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                    break;
            }
        }
    }

    public static void Main7(string[] args)
    {
        Thread t = new Thread(RunThread); 
        t.Start("Xin chao");
        Thread t2 = new Thread(delegate ()
        {
            Console.WriteLine("demo anonymous function");
        });
        t2.Start();
        Console.WriteLine("Main done");
    }

    static async Task<Root> CallApi()
    {
        string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
        HttpClient http = new HttpClient();
        var rs = await http.GetAsync(url); //lay data ve

        if(rs.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string content = await rs.Content.ReadAsStringAsync();
            Root r = JsonConvert.DeserializeObject<Root>(content);
            return r;
        }
        return null;
    }

    static void RunThread()
    {
        for (int i = 0;i <20; i++)
        {
            Console.WriteLine("i = " + i);
            try
            {
                Thread.Sleep(1000);
            }
            catch(Exception e) { }
        }
    }

    public static void Main6(string[] args)
    {
        Print p = new Print(ShowDanger);

        p += new News().Display;
    }
    public static void Main5(string[] args)
    {
        //DemoDelegate.Alert("Cam thanh vien duoi 18 tuoi");
        //DemoDelegate d = new DemoDelegate();
        //d.ShowMessage("Canh bao lan thu nhat");
        PrintString ps = new PrintString(ShowDanger);
        //ps("Nguy hiem lam");
        //ShowDanger("Nguy hiem lam");
        //PrintString ps1 = new PrintString(DemoDelegate.Alert);
        //PrintString ps2 = new PrintString(new DemoDelegate().ShowMessage);

        ps += DemoDelegate.Alert;
        ps += new DemoDelegate().ShowMessage;

        ps("Nguy hiem lam");

        ps += (s) =>
        {
            Console.WriteLine("Anonymus1: " + s);
        };

        ps += delegate (string s)
        {
            Console.WriteLine("Anonymus2: " + s);
        };

        PrintString ps3 = delegate (string s)
        {

        };

        Button de = new Button(ps3);
        de.ckAction();
    }

    public static void ShowDanger(string msg) 
    {
        Console.WriteLine("Danger: " + msg); 
    }

    public static void Main4(string[] args)
    {
        KhachhangNN nn = new KhachhangNN("NN2", "Kidman", "01/01/2022", 50, "NN");
        Console.WriteLine(nn.caculatedMoney());
        KhachhangVN vn = new KhachhangVN("VN1", "Tuan", "02/02/2022", 100, "TN");
        Console.WriteLine(vn.caculatedMoney());
    }
    public static void Main3(string[] args)
    {
        Car c = new Car() { Brand = "Toyota", Type = "Sedan"};
        Console.WriteLine(c.machines[0]);
        Console.WriteLine(c[1]);
        //Console.WriteLine(c[2]);
        //c[2] = "Led";
        c.machines.Add("Led");
        try
        {
            int x = 10;
            int y = 0;
            if (y== 0)
            {
                throw new Exception("Error...");
            }
            Console.WriteLine("x/y = ");
            int z = x / y;
            Console.WriteLine(z);
        }catch(Exception e) 
        {
            Console.WriteLine(e.Message);
        }
    }

    public static void Main2(string[] args) 
    {
        //Dog d = new Dog();
        //d.Setkind("Dog");
        //d.Info();
        Dog d = new Dog("Dog", 12);
        d.Weight = 10;
        d.Color = "yellow";
        Console.WriteLine(d.Weight);
        Console.WriteLine(d.Color);
        Dog[] dd = new Dog[10];

        for(int i=0; i < dd.Length; i++)
        {
            dd[i] = new Dog();
        }
        //dd[0].Weight = 20;

        foreach(Dog o in dd)
        {
           
        }

        List<Dog> ls = new List<Dog>();
        ls.Add(new Dog());
        Console.WriteLine(ls.Count); // .Count -> Kich thuoc tap hop

        List<int> ints = new List<int>();
    }

    public static void Main1(string[] args)
    {
        int x = 10;
        double y = 3.14;
        Console.WriteLine("Hello World: " + x);
        string s = "T2204M";

        if (x >= 10)
        {
            Console.WriteLine("A");
        }else if (x>5)
        {
            Console.WriteLine("B");
        }else if(x>15)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("D");
        }

        int[] ns = new int[3];

        ns[0] = 15;
        ns[1] = 20;
        ns[2] = 25;

        foreach(int n in ns)
        {
            //n (chạy hết sạch 1 mảng)
        }

        for(int i = 0; i< ns.Length; i++)
        {
            //n[i] (chạy đến phần tử thứ i)
        }

        string input = Console.ReadLine(); //scan
        int num = Convert.ToInt32 (input);
        Console.WriteLine("num = " + num);

        Human h = new Human();
        h.name = "Nguyen Van An";
        h.Run();

        Fraction t1 = new Fraction(1, 2);
        Fraction t2 = new Fraction(3, 4);
        Fraction t = t1.add(t2);
        Fraction tt = t2.add(t1);
        Fraction ttt = t.add(tt);

        t.inphanSo();
        tt.inphanSo();
        ttt.inphanSo();
    }
}

namespace T2204M.session3
{
    public class Moto
    {

    }

    public class Bike
    {

    }
}
