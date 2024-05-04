
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
            notifyIcon1.BalloonTipTitle = "Programa Ho� Geldiniz";
            notifyIcon1.BalloonTipText = "Nesne Y�nelimli Programlama �dev.";
            notifyIcon1.ShowBalloonTip(2000); // 2000 milisaniye (2 saniye) boyunca g�ster
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
            // secilen sekil kontrol�
            if (checkBox1.Checked) // Dikdortgen i�in
            {
                double boy, en;
                if (double.TryParse(textBox7.Text, out boy) && double.TryParse(textBox8.Text, out en))
                {
                    // dikdortgen nesnesi olusturma
                    Dikdortgen dikdortgen = new Dikdortgen(int.Parse(textBox1.Text), textBox2.Text, RenkSecimi(), boy, en);

                    // hesaplama ve yazd�rma 
                    dikdortgen.BilgiYazdir(richTextBox1);
                    richTextBox1.AppendText($"Alan: {dikdortgen.AlanHesapla()}\n");
                    richTextBox1.AppendText($"�evre: {dikdortgen.CevreHesapla()}\n");
                }
                else
                {
                    MessageBox.Show("boy ve en i�in ge�erli de�er giriniz");
                }
            }
            else if (checkBox2.Checked) // EskenarUcgen i�in
            {
                double kenar;
                if (double.TryParse(textBox4.Text, out kenar))
                {
                    // eskenarucgen nesne olusturma
                    EskenarUcgen eskenarUcgen = new EskenarUcgen(int.Parse(textBox1.Text), textBox2.Text, RenkSecimi(), kenar);

                    //hesaplama ve bilgileri yazd�rma

                    eskenarUcgen.BilgiYazdir(richTextBox1);
                    richTextBox1.AppendText($"Alan: {eskenarUcgen.AlanHesapla()}\n");
                    richTextBox1.AppendText($"�evre: {eskenarUcgen.CevreHesapla()}\n");
                }
                else
                {
                    MessageBox.Show("kenar i�in ge�erli de�er giriniz."); // uyar� ver
                }
            }
            else if (checkBox3.Checked) // Daire i�in
            {
                double cap, aci;
                if (double.TryParse(textBox5.Text, out cap) && double.TryParse(textBox6.Text, out aci))
                {
                    // daire nesnesi olusturma
                    Daire daire = new Daire(int.Parse(textBox1.Text), textBox2.Text, RenkSecimi(), cap);

                    // yazd�rma islemi
                    daire.BilgiYazdir(richTextBox1);
                    richTextBox1.AppendText($"Alan: {daire.AlanHesapla()}\n");
                    richTextBox1.AppendText($"�evre: {daire.CevreHesapla()}\n");
                }
                else
                {
                    MessageBox.Show("�ap ve a�� i�in ge�erli de�er giriniz.");
                }
            }
            else
            {
                MessageBox.Show("L�tfen �ekil se�iniz.");
            }

        }

        private string RenkSecimi() //renk kontrol� yapma
        {
            if (checkBox4.Checked) return "K�rm�z�";
            if (checkBox5.Checked) return "Siyah";
            if (checkBox6.Checked) return "Sar�";
            if (checkBox7.Checked) return "Mavi";
            return "Belirtilmemi�";
        }
    }

}