using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_odev
{
    public partial class checksum : Form
    {
        public checksum()
        {
            InitializeComponent();
        }
        int sonuc;
        int toplam = 0;
        int yenitoplam = 0;
        int toplam2 = 0;
        int yenicheck = 0;
        int elde = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            toplam = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text);
            if(toplam<10000)
            {
                yenitoplam = toplam;
                
            }
            else
            {
                elde = toplam / 10000;
                yenitoplam = (toplam % 10000) + elde;
                
            }
            yenicheck = 9999 - yenitoplam;
            
            toplam2 = int.Parse(textBox1.Text) + int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox4.Text);
            toplam2 = toplam2 + yenicheck;
            if (toplam2 < 10000)
            {
                yenitoplam = toplam2;

            }
            else
            {
                elde = toplam2 / 10000;
                yenitoplam = (toplam2 % 10000) + elde;

            }
            sonuc = 9999 - yenitoplam;
            label2.Text = sonuc.ToString();
        }
    }
}
