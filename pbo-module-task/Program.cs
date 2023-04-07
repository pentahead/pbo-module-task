using System.ComponentModel;
using System.Net.WebSockets;

namespace pbo_module_task
{

    class Processor
    {
        public string Merk;
        public string Tipe;
    }

   class amd : Processor
    {
        public amd()
        {
            base.Merk = "AMD";
        }
    }

    class Ryzen : amd
    {
        public Ryzen()
        {
            base.Tipe = "Rayzen";
        }
    }
    class Athlon : amd
    {
        public Athlon()
        {
            base.Tipe = "Athlon";
        }
    }

    class Intel : Processor
    {
        public Intel()
        {
            base.Merk = "Intel";
        }
    }

    class Corei3 : Intel
    {
        public Corei3()
        {
            base.Tipe = "Core i3";
        }
    }

    class Corei5 : Intel
    {
        public Corei5()
        {
            base.Tipe = "Core i5";
        }
    }
    class Corei7 : Intel
    {
        public Corei7()
        {
            base.Tipe = "Core i7";
        }
    }

    public class VGA
    {
        public string Merk;
    }

    class Nvidia : VGA
    {
        public Nvidia()
        {
            base.Merk = "Nvidia";
        }
    }

    class AMD : VGA
    {
        public AMD()
        {
            base.Merk = "AMD";
        }
    }

    class Laptop
    {
        public string Merk;
        public string Tipe;
        public VGA VGA;
        public Processor Processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} dinyalakan");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} dimatikan");
        }
    }

    class ASUS : Laptop
    {
        public ASUS()
        {
            base.Merk = "ASUS";
        }
    }
    class ACER : Laptop
    {
        public ACER()
        {
            base.Merk = "ACER";
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.Merk = "LENOVO";
        }
    }

    class ROG : ASUS
    {
        public ROG()
        {
            base.Tipe = "ROG";
        }
    }
    class VIVOBOOK : ASUS
    {
        public VIVOBOOK()
        {
            base.Tipe = "VIVOBOOK";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class Predator : ACER
    {
        public Predator()
        {
            base.Tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} seang memainkan game");
        }
    }

    class Swift : ACER
    {
        public Swift()
        {
            base.Tipe = "Swift";
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.Tipe = "IdeaPad";
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.Tipe = "Legion";
        }
    }
    //MAIN
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Laptop laptop1 = new VIVOBOOK();
            laptop1.VGA = new Nvidia();
            laptop1.Processor = new Corei5();

            Laptop laptop2 = new IdeaPad();
            laptop2.VGA = new AMD();
            laptop2.Processor = new Ryzen();

            Predator predator = new Predator();
            predator.VGA = new AMD();
            predator.Processor = new Corei7();

            Console.WriteLine("Soal no 1");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine("\n");

            //Console.WriteLine("Soal no 2");
            //Laptop laptop1.Ngoding();

            Console.WriteLine("Soal no 3");
            Console.WriteLine($"Merk VGA : {laptop1.VGA.Merk}");
            Console.WriteLine($"Merk Processor : {laptop1.Processor.Merk}");
            Console.WriteLine($"Tipe Processor : {laptop1.Processor.Tipe}");
            Console.WriteLine("\n");

            Console.WriteLine("Soal no 4");
            predator.BermainGame();
            Console.WriteLine("\n");

            Console.WriteLine("Soal no 5");
            ACER acer = new Predator();
            
        }
    }
}