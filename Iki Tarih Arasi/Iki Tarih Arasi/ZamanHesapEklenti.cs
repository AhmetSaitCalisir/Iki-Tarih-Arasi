using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Tarih_Arasi
{
    class ZamanHesapEklenti
    {
        
        private TimeSpan FarkKalan;
        private TimeSpan FarkGecen;
        public int HesapKalanSaniye(DateTime Son)
        {
            FarkKalan = Son - DateTime.Now;
            return Convert.ToInt32(FarkKalan.TotalSeconds);
        }
        public int HesapGecenSaniye(DateTime Baslangic)
        {
            FarkGecen = DateTime.Now-Baslangic;
            return Convert.ToInt32(FarkGecen.TotalSeconds);
        }
    }
}
