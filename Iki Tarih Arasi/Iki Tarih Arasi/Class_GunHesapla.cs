using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Tarih_Arasi
{
    class Class_GunHesapla : ITarihHesapla
    {
        private TimeSpan GecenFark;
        private TimeSpan KalanFark;
        public (int, int) Hesapla(DateTime Baslangic, DateTime Son)
        {
            GecenFark = DateTime.Now - Baslangic;
            KalanFark = Son - DateTime.Now;
            return (Convert.ToInt32(KalanFark.TotalDays), Convert.ToInt32(GecenFark.TotalDays));
        }
    }
}
