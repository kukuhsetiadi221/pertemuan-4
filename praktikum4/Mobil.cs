using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4
{
    internal class Mobil
    {
        //field
        private string _warna;
        private float _jumlahPintu;
        private string _merek;
        private string _model;
        private string _tahunKeluaran;
        private float _kecepatan;
        private string _suara;

        //properti
        public string Warna
        {
            get
            {
                return _warna;
            }
            set
            {
                _warna = value;
            }
        }
        public float JumlahPintu
        {
            get
            {
                return _jumlahPintu;
            }
            set
            {
                _jumlahPintu = value;
            }
        }
        public string Merek
        {
            get
            {
                return _merek;
            }
            set
            {
                _merek = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public string TahunKeluaran
        {
            get
            {
                return _tahunKeluaran;
            }
            set
            {
                _tahunKeluaran = value;
            }
        }
        public float Kecepatan
        {
            get
            {
                return _kecepatan;
            }
            set
            {
                _kecepatan = value;
            }
        }
        public string Suara
        {
            get
            {
                return _suara;
            }
            set
            {
                _suara = value;
            }
        }
        
        public void InfoMobil()
        {
            Console.WriteLine("***Info Mobil***");
            Console.WriteLine("Merek : {0}", Merek);
            Console.WriteLine("Model : {0}", Model);
            Console.WriteLine("Warna : {0}", Warna);
            Console.WriteLine("Tahun Keluaran : {0}", TahunKeluaran);
            Console.WriteLine("Jumlah Pintu : {0}", JumlahPintu);
            Console.WriteLine("Kecepatan : {0}", Kecepatan);
            Console.WriteLine("Suara : {0}", Suara);
        }
      
    }
}
