using System;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace KadoKokMikir
{
    // CLASS VGA
    public class Vga
    {
        public string merk;
    }

    public class Nvidia : Vga
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }

    public class Amd : Vga
    {
        public Amd()
        {
            base.merk = "AMD";
        }
    }

    // CLASS PROCESSOR
    public class Processor
    {
        public string merk;
        public string tipe;
    }

    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }

    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }

    public class Corei3 : Intel
    {
        public Corei3()
        {
            base.tipe = "Corei3";
        }
    }

    public class Corei5 : Intel
    {
        public Corei5()
        {
            base.tipe = "Corei5";
        }
    }

    public class Corei7 : Intel
    {
        public Corei7()
        {
            base.tipe = "Corei7";
        }
    }

    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "Ryzen";
        }
    }

    public class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "Athlon";
        }
    }

    // CLASS LAPTOP
    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine(string.Format("Laptop {0} {1} menyala", merk, tipe));
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine(string.Format("Laptop {0} {1} mati", merk, tipe));
        }

        public void BermainGame()
        {
            Console.WriteLine(string.Format("Laptop {0} {1}", merk, tipe));
        }

        public void Ngoding()
        {
            Console.WriteLine(string.Format("Ctak Ctak Ctak, error lagi!!"));
        }
    }

    public class Asus : Laptop
    {
        public Asus()
        {
            base.merk = "Asus";
        }
    }

    public class Acer : Laptop
    {
        public Acer()
        {
            base.merk = "Acer";
        }
    }

    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            base.merk = "Lenovo";
        }
    }

    public class ROG : Laptop
    {
        public ROG()
        {
            base.tipe = "ROG";
        }
    }

    public class VivoBook : Laptop
    {
        public VivoBook()
        {
            base.tipe = "VivoBook";
        }

        public void Ngoding()
        {
            Console.WriteLine(string.Format("Ctak Ctak Ctak, error lagi!!"));
        }
    }

    public class Swift : Laptop
    {
        public Swift()
        {
            base.tipe = "Swift";
        }
    }

    public class Predator : Acer
    {
        public Predator()
        {
            base.tipe = "Predator";
        }

        public void BermainGame()
        {
            Console.WriteLine(string.Format("Laptop {0} {1} sedang memainkan game", merk, tipe));
        }
    }

    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            base.tipe = "IdeaPad";
        }
    }

    public class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }

    internal class Program
    {
        public static Laptop laptop1;
        public static Laptop laptop2;
        public static Predator predator;
        public static Acer acer;

        static void Main(string[] args)
        {
            laptop1 = new VivoBook();
            laptop1.vga = new Nvidia();
            laptop1.processor = new Corei5();

            laptop2 = new IdeaPad();
            laptop2.vga = new Amd();
            laptop2.processor = new Ryzen();

            predator = new Predator();
            predator.vga = new Amd();
            predator.processor = new Corei7();

            //SOAL 1
            Console.WriteLine("SOAL 1");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();
            Console.WriteLine("\n");

            //SOAL 2
            Console.WriteLine("SOAL 2");
            Console.WriteLine("\n");

            //SOAL 3
            Console.WriteLine("SOAL 3");
            Console.WriteLine(laptop1.vga.merk);
            Console.WriteLine(laptop1.processor.merk);
            Console.WriteLine(laptop1.processor.tipe);
            Console.WriteLine("\n");

            //SOAL 4
            Console.WriteLine("SOAL 4");
            predator.BermainGame();
            Console.WriteLine("\n");

            //SOAL 5
            Console.WriteLine("SOAL 5");
            Console.WriteLine("\n");
        }
    }
}
