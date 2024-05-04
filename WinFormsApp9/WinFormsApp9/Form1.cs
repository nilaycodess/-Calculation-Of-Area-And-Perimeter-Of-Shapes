
namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        private object seciliSekil;

        public Form1()
        {
            InitializeComponent();
            InitializeNotifyIcon();

        }
        private void InitializeNotifyIcon()
        {
            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = SystemIcons.Information;
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Programa Hoþ Geldiniz";
            notifyIcon1.BalloonTipText = "Nesne Yönelimli Programlama Ödev.";
            notifyIcon1.ShowBalloonTip(2000); // 2000 milisaniye (2 saniye) boyunca göster
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // secilen sekil kontrolü
            if (checkBox1.Checked) // Dikdortgen için
            {
                double boy, en;
                if (double.TryParse(textBox7.Text, out boy) && double.TryParse(textBox8.Text, out en))
                {
                    // dikdortgen nesnesi olusturma
                    Dikdortgen dikdortgen = new Dikdortgen(int.Parse(textBox1.Text), textBox2.Text, RenkSecimi(), boy, en);

                    // hesaplama ve yazdýrma 
                    dikdortgen.BilgiYazdir(richTextBox1);
                    richTextBox1.AppendText($"Alan: {dikdortgen.AlanHesapla()}\n");
                    richTextBox1.AppendText($"Çevre: {dikdortgen.CevreHesapla()}\n");
                }
                else
                {
                    MessageBox.Show("boy ve en için geçerli deðer giriniz");
                }
            }
            else if (checkBox2.Checked) // EskenarUcgen için
            {
                double kenar;
                if (double.TryParse(textBox4.Text, out kenar))
                {
                    // eskenarucgen nesne olusturma
                    EskenarUcgen eskenarUcgen = new EskenarUcgen(int.Parse(textBox1.Text), textBox2.Text, RenkSecimi(), kenar);

                    //hesaplama ve bilgileri yazdýrma

                    eskenarUcgen.BilgiYazdir(richTextBox1);
                    richTextBox1.AppendText($"Alan: {eskenarUcgen.AlanHesapla()}\n");
                    richTextBox1.AppendText($"Çevre: {eskenarUcgen.CevreHesapla()}\n");
                }
                else
                {
                    MessageBox.Show("kenar için geçerli deðer giriniz."); // uyarý ver
                }
            }
            else if (checkBox3.Checked) // Daire için
            {
                double cap, aci;
                if (double.TryParse(textBox5.Text, out cap) && double.TryParse(textBox6.Text, out aci))
                {
                    // daire nesnesi olusturma
                    Daire daire = new Daire(int.Parse(textBox1.Text), textBox2.Text, RenkSecimi(), cap);

                    // yazdýrma islemi
                    daire.BilgiYazdir(richTextBox1);
                    richTextBox1.AppendText($"Alan: {daire.AlanHesapla()}\n");
                    richTextBox1.AppendText($"Çevre: {daire.CevreHesapla()}\n");
                }
                else
                {
                    MessageBox.Show("çap ve açý için geçerli deðer giriniz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen þekil seçiniz.");
            }

        }

        private string RenkSecimi() //renk kontrolü yapma
        {
            if (checkBox4.Checked) return "Kýrmýzý";
            if (checkBox5.Checked) return "Siyah";
            if (checkBox6.Checked) return "Sarý";
            if (checkBox7.Checked) return "Mavi";
            return "Belirtilmemiþ";
        }
    }

}