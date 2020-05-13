using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iki_Tarih_Arasi
{
    public partial class Form_Giris : Form
    {
        public Form_Giris()
        {
            InitializeComponent();
        }
        Class_Hesapla class_Hesapla = new Class_Hesapla();
        private void Form_Giris_Load(object sender, EventArgs e)
        {
            dateTime_BaslangicGun.Value = DateTime.Now.AddDays(-1);
            dateTime_SonGun.Value = DateTime.Now.AddDays(1);
            dateTime_BaslangicSaat.Value = DateTime.Now;
            dateTime_SonSaat.Value = DateTime.Now;
            Hesapla();
        }
        private void Hesapla()
        {

            class_Hesapla.Hesapla(dateTime_BaslangicSaat.Value, dateTime_SonSaat.Value, label_KalanGun, label_GecenGun, label_KalanSaat, label_GecenSaat, label_KalanDakika, label_GecenDakika,label_KalanSaniye,label_GecenSaniye);
        }

        private void dateTime_BaslangicGun_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime_BaslangicGun.Value > DateTime.Now)
            {
                dateTime_BaslangicGun.Value = DateTime.Now;
            }
            else
            {
                dateTime_BaslangicSaat.Value = dateTime_BaslangicGun.Value;
            }
        }
        
        private void dateTime_SonGun_ValueChanged(object sender, EventArgs e)
        {
            if (dateTime_SonGun.Value < DateTime.Now)
            {
                dateTime_SonGun.Value = DateTime.Now;
            }
            else
            {
                dateTime_SonSaat.Value = dateTime_SonGun.Value;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Hesapla();
            if (dateTime_SonGun.Value < DateTime.Now)
            {
                dateTime_SonGun.Value = DateTime.Now;
            }
            if (dateTime_BaslangicGun.Value > DateTime.Now)
            {
                dateTime_BaslangicGun.Value = DateTime.Now;
            }
        }

        private void dateTime_BaslangicSaat_ValueChanged(object sender, EventArgs e)
        {
            dateTime_BaslangicGun.Value = dateTime_BaslangicSaat.Value;
        }

        private void dateTime_SonSaat_ValueChanged(object sender, EventArgs e)
        {
            dateTime_SonGun.Value = dateTime_SonSaat.Value;
        }

        private void button_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
