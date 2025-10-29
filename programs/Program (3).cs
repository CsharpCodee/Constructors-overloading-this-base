using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10._3
{
    class Device
    {
        private string brand;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public Device(string brand)
        {
            this.brand = brand;
        }

        public void PowerOn()
        {
            Console.WriteLine($"{brand} включён.");
        }
    }
    class Laptop : Device
    {
        private int ram;
        private int battery;

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value >= 1 && value <= 64) { ram = value; }
                else Console.WriteLine("ОЗУ должно быть от 1 до 64!");
            }
        }
        public int Battery
        {
            get { return battery; }
            set { if (value >= 0 && value <= 100) { battery = value; }
                else Console.WriteLine("");
            }
        }

        public Laptop(int ram, int battery, string brand) : base(brand)
        {
            Ram=ram;
            Battery=battery;
            Brand = brand;
        }

        public void Work()
        {
            Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {ram} ГБ, заряд: {battery}%.");
        }

        static void Main(string[] args)
        {
            Laptop laptop = new Laptop(0, 30, "Asus");
            laptop.PowerOn();
            laptop.Work();

        }
    }
}
