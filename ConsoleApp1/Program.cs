using T2204M.session1;

public class Program
{
    public static void Main(string[] args)
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
    }
}