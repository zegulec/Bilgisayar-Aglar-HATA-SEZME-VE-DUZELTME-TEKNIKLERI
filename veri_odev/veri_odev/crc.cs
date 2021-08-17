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
    public partial class crc : Form
    {
        public crc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void crc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sonuc = new string[4];
            string data1=tbdata.Text.ToString();
            string data = tbdata.Text.ToString();
            string divisor = tbdivisor.Text.ToString();
            //string bak;
            string sifirdivisor = "0000";
            string kullanilan_divisor;
            for (int j = 0; j < 4; j++)
            {
                if (data[0] == '1')
                {
                    kullanilan_divisor = divisor;
                }
                else
                {
                    kullanilan_divisor = sifirdivisor;
                }
                for (int i = 3; i >= 0; i--)
                {
                    if (data[i] == kullanilan_divisor[i])
                        sonuc[i] = "0";
                    else
                        sonuc[i] = "1";
                }
                if (j != 3)
                    data = sonuc[1] + sonuc[2] + sonuc[3] + "0";
                else
                    data = sonuc[1] + sonuc[2] + sonuc[3];
            }
            textBox3.Text = data.ToString();
            textBox4.Text = data1 + "  |  " + data;
        }
    }
}
