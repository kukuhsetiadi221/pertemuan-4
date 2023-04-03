using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mobil mobil1 = new Mobil();
            mobil1.Merek = "Jeep";
            mobil1.JumlahPintu = 4f;
            mobil1.Warna = "Putih";
            mobil1.Model = "Rubicon";
            mobil1.Kecepatan = 180f;
            mobil1.TahunKeluaran = "2003";
            mobil1.Suara = "brum brum";
            mobil1.InfoMobil();
            Console.ReadLine();

        }
    }
}
