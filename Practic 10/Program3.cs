using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic10_3
{
    internal class Device
    {
        private string brand;

        public string Brand
        { get { return brand; } set { brand = value; } }

        public Device(string brand)
        {
            Brand = brand;
        }
        public void PowerOn()
        {
            Console.WriteLine($"{brand} включён ");
        }
    }
    internal class Laptop : Device
    {
        private int ram;
        private int battery;
        private bool er_ram;
        private bool er_battery;

        public int Ram
        {
            get { return ram; }
            set
            {
                if (value < 0 || value > 1000000)
                {
                    Console.WriteLine("Ошибка.");
                    er_ram = true;
                }
                else
                {
                    ram = value;
                    er_ram = false;
                }

            }

        }
        public int Battery
        {
            get { return battery; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Ошибка.");
                    er_battery = true;
                }
                else
                {
                    battery = value;
                    er_battery = false;
                }

            }
        }
        public Laptop(string Brand, int ram, int battery) : base(Brand)
        {
            Ram = ram;
            Battery = battery;
        }
        public void Work()
        {
            Console.WriteLine($"Ноутбук {Brand}, ОЗУ {ram} ГБ, заряд: {battery}.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("f+", 3, 45);
            laptop.PowerOn();
            laptop.Work();
        }
    }
}
