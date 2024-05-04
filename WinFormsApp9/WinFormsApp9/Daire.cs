using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class Daire : Sekil //Sekil sınıfından türeyen Daire sınıfı
    {
        public double Cap { get; set; }

        public Daire(int id, string ad, string renk, double cap) : base(id, ad, renk)
        {
            // Daire özelliklerini atama
            Cap = cap;
        }

        public override double AlanHesapla()
        {
            return Math.PI * Math.Pow(Cap / 2, 2);
        }

        public override double CevreHesapla()
        {
            return Math.PI * Cap;
        }

        public override void BilgiYazdir(RichTextBox richTextBox1)
        {
            // Sekilsınıfının BilgiYazdir metotunu çağırma
            base.BilgiYazdir(richTextBox1);
            richTextBox1.AppendText($"Cap: {Cap}\n");

        }
    }
}
