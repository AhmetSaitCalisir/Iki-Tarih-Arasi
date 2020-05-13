using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iki_Tarih_Arasi
{
    class Class_Hesapla
    {
        private Class_GunHesapla class_GunHesapla = new Class_GunHesapla();
        private Class_SaatHesapla class_SaatHesapla = new Class_SaatHesapla();
        private Class_DakikaHesapla class_DakikaHesapla = new Class_DakikaHesapla();
        private Class_SaniyeHesapla class_SaniyeHesapla = new Class_SaniyeHesapla();
        public void Hesapla(DateTime Baslangic, DateTime Son, Label KalanGun, Label GecenGun, Label KalanSaat, Label GecenSaat, Label KalanDakika, Label GecenDakika, Label KalanSaniye, Label GecenSaniye)
        {
            KalanGun.Text = class_GunHesapla.Hesapla(Baslangic, Son).Item1.ToString();
            GecenGun.Text = class_GunHesapla.Hesapla(Baslangic, Son).Item2.ToString();
            KalanSaat.Text = class_SaatHesapla.Hesapla(Baslangic, Son).Item1.ToString();
            GecenSaat.Text = class_SaatHesapla.Hesapla(Baslangic, Son).Item2.ToString();
            KalanDakika.Text = class_DakikaHesapla.Hesapla(Baslangic, Son).Item1.ToString();
            GecenDakika.Text = class_DakikaHesapla.Hesapla(Baslangic, Son).Item2.ToString();
            KalanSaniye.Text = class_SaniyeHesapla.Hesapla(Baslangic, Son).Item1.ToString();
            GecenSaniye.Text = class_SaniyeHesapla.Hesapla(Baslangic, Son).Item2.ToString();
        }
    }
}
