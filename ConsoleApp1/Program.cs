using T2204M.session1;
using T2204M.session2;
using System.Collections.Generic;
using T2204M.session3;
using T2204M.session4;
using T2204M.Tiendien;
using T2204M.interfaceAssignment;

public class Program
{
    public static void Main(string[] args)
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
