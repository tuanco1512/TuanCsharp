using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.interfaceAssignment
{
    public delegate void Print(string p);
    public class News : Inews
    {
        private int id;
        private string title;
        private string publishDate;
        private string author;
        private string content;
        private float averageRate;

        public int ID { get => id; set => id= value; }
        public string Title { get => title; set=> title= value; }
        public string PublishDate { get => publishDate; set => publishDate= value; }
        public string Author { get => author; set => author= value; }
        public string Content { get => content; set => content= value; }
        public float AverageRate { get => averageRate;}

        public void Display(string s)
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("PublishDate" + publishDate);
            Console.WriteLine("Author" + author);
            Console.WriteLine("Content" + content);
            Console.WriteLine("AverageRate" + averageRate);
        }

        private int[] RateList = new int[3];

        public float Caculate(int rate) 
        {
           averageRate = (RateList[0] + RateList[1] + RateList[2])/3;
           return averageRate;
        }
    }
}
