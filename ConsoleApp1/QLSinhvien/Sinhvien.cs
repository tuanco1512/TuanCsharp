using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2204M.QLSinhvien
{
    internal class Sinhvien
    {
        private int id;
        private string name;
        private string gender;
        private int age;
        private double math;
        private double physics;
        private double chemistry;
        private double average_score;
        private string rate;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public double Math { get => math; set => math = value; }
        public double Physics { get => physics; set => physics = value; }
        public double Chemistry { get => chemistry; set => chemistry = value; }
        public double Average_score { get => average_score; set => average_score = value; }
        public string Rate { get => rate; set => rate = value;}

    }
}
