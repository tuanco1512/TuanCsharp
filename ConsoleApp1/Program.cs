using T2204M.session1;
using T2204M.session2;
using System.Collections.Generic;
public class Program
{
    public static void Main(string[] args) 
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

    public static void Main2(string[] args)
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