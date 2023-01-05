using System;
namespace T2204M.session2
{
    public class Animal : AbstractAnimal
    {
        private string kind;

        public Animal(string kind)
        {
            this.kind = kind;
        }

        public virtual void Setkind(string k)
        {
            kind = k;
        }

        public string Getkind()
        {
            return kind;
        }

        public override void Eat()
        {
            Console.WriteLine("Eating...");
        }

        public override void Run()
        {
            Console.WriteLine("Running...");
        }
    }
}
