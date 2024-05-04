using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    public class Sekil
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Renk { get; set; }
        public Sekil(int id, string ad, string renk)
        {
            Id = id;
            Ad = ad;
            Renk = renk;
        }

        public virtual double AlanHesapla()
        {
            return 0;
        }

        public virtual double CevreHesapla()
        {
            return 0;
        }

        public virtual void BilgiYazdir(RichTextBox richTextBox1)
        {
            richTextBox1.AppendText($"Sekil Bilgileri:\nID: {Id}\nAd: {Ad}\nRenk: {Renk}\n");
        }
    }
}
