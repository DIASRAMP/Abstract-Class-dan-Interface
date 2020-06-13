using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDanInterface
{
    public abstract class Hewan
    {
        private int _beratBadan;

        public int BeratBadan
        {
            get { return _beratBadan; }
            set
            {
                if (value <= 0)
                    _ = 1;
                else
                    _beratBadan = value;
            }
        }
        //Ini adalah abstract method
        public abstract void MempertahankanDiri();
    }
}

namespace AbstractClassDanInterface
{
    public interface IDapatTerbang
    {
        void Terbang();
    }
}

namespace AbstractClassDanInterface
{
    interface IDapatLoncat
    {
        void Loncat();
    }
}

namespace AbstractClassDanInterface
{
    class Ayam : Hewan, IDapatTerbang, IDapatLoncat
    {
        public Ayam()
        {
            BeratBadan = 5;
        }

        //Mengimplementasikan method MempertahankanDiri khas Ayam
        public override void MempertahankanDiri()
        {
            Console.WriteLine("Ayam mematuk dengan sangat keras ....!!!");
        }

        //Membuat method Terbang baru khas Ayam
        public void Terbang()
        {
            Console.WriteLine("Ayam sedang terbang ...!!!");
        }

        //Membuat method Loncat baru khas Ayam
        public void Loncat()
        {
            Console.WriteLine("Ayan sedang loncat ...!!!");
        }
    }
}

namespace AbstractClassDanInterface
{
    class Program
    {
        private static void Main(string[] agrs)
        {
            if (agrs is null)
            {
                throw new ArgumentNullException(nameof(agrs));
            }

            Ayam ayam = new Ayam();
            Ayam kate = ayam;

            kate.MempertahankanDiri();
            kate.Terbang();
            kate.Loncat();

            Console.WriteLine("Berat badan kate : {0}", kate.BeratBadan);
        }
    }
}

