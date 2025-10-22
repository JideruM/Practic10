using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10_5
{
    class Animal
    {
        private string name;
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }

        public Animal(string name) { this.name = name; }
        public void Speak()
        {
            Console.WriteLine($"{name} издает звук.");
        }

    }
    class Cat : Animal
    {
        private int lives;
        public int Lives
        {
            get { return lives; }
            set
            {
                if (value >= 1 && value <= 9)
                    lives = value; ;
            }
        }
        public Cat(string name, int lives) : base(name)
        {
            this.lives = lives;
        }
        public Cat(string name) : this(name, 9) { }
        public void Meow()
        {
            if (lives > 1)
            {
                lives--;
            }
            Console.WriteLine($"{Name} мяукнул, осталось жизней: {lives}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кузя", 9);
            Cat cat1 = new Cat("Маркиз");
            cat.Speak();
            cat.Meow();
            cat1.Speak();
            cat1.Meow();


        }
    }
}
