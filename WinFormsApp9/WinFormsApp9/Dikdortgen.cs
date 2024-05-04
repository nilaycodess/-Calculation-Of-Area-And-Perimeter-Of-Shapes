using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class Dikdortgen:Sekil // Sekil sınıfından türeyen Dikdortgen sınıfı
    {
        public double Boy { get; set; }
        public double En { get; set; }

        public Dikdortgen(int id, string ad, string renk, double boy, double en) : base(id, ad, renk)
        {
            //dikdortgenin özelliklerini atama
            Boy = boy;
            En = en;
        }

        public override double AlanHesapla()
        {
            return Boy * En;
        }

        public override double CevreHesapla()
        {
            return 2 * (Boy + En);
        }

        public override void BilgiYazdir(RichTextBox richTextBox1)
        {
            // Sekilsınıfının BilgiYazdir metotunu çağırma
            base.BilgiYazdir(richTextBox1);
            richTextBox1.AppendText($"Boy: {Boy}\n");
            richTextBox1.AppendText($"En: {En}\n");
        }

    }
}
