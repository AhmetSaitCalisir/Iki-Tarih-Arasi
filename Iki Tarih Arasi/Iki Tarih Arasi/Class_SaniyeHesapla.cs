using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Tarih_Arasi
{
    class Class_SaniyeHesapla : ITarihHesapla
    {
        private ZamanHesapEklenti zamanHesapEklenti = new ZamanHesapEklenti();
        public (int, int) Hesapla(DateTime Baslangic, DateTime Son)
        {
            return (zamanHesapEklenti.HesapKalanSaniye(Son), zamanHesapEklenti.HesapGecenSaniye(Baslangic));
        }
    }
}
