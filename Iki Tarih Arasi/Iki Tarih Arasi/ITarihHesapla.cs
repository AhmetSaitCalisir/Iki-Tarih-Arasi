using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iki_Tarih_Arasi
{
    interface ITarihHesapla
    {
        (int, int) Hesapla(DateTime Baslangic, DateTime Son);
    }
}
