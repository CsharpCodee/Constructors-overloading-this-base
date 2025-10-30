using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10._5
{
    class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal(string name)
        {
            this.name = name;
        }

        public void Speak()
        {
            Console.WriteLine($"{name} издаёт звук.");
        }
    }

    class Cat:Animal
    {
        private int lives;

        public int Lives
        {
            get { return lives; }
            set { lives = (value >= 1 && value <= 9) ? value : 0; }
        }

        public Cat(int lives, string name) : base(name)
        {
            this.lives = lives;
            this.Name = name;
        }

        public Cat(string name) : base(name)
        {
            this.Name = name;
            this.lives = 9;
        }

        public void Meow()
        {
            if (lives >= 1)
            {
                lives -= 1;
                Console.WriteLine($"{Name} мяукнул, осталось жизней: {lives}.");
            }
            else
            {
                Console.WriteLine($"Недостаточнно жизней.");
            }
        }

        static void Main(string[] args)
        {
            Cat cat1 = new Cat(6, "Dril");
            cat1.Speak();
            cat1.Meow();
            cat1.Meow();

            Cat cat2 = new Cat("Блиня");
            cat2.Speak();
            cat2.Meow();


        }
    }
}
