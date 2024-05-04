using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class EskenarUcgen: Sekil //Sekil sınıfından türeyen EskenarUcgen sınıfı
    {
    
        public double Kenar { get; set; }

        public EskenarUcgen(int id, string ad, string renk, double kenar) : base(id, ad, renk)
        {
            // eskenar ücgen özelliklerini atama
            Kenar = kenar;
        }

        public override double AlanHesapla()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(Kenar, 2);
        }

        public override double CevreHesapla()
        {
            return 3 * Kenar;
        }

        public override void BilgiYazdir(RichTextBox richTextBox1)
        {
            // Sekilsınıfının BilgiYazdir metotunu çağırma
            base.BilgiYazdir(richTextBox1);
            richTextBox1.AppendText($"Kenar: {Kenar}\n");
        }
    }
}

