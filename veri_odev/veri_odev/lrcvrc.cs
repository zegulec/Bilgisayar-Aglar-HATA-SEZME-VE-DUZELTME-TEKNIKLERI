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
    public partial class lrcvrc : Form
    {
        public lrcvrc()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lrcvrc_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veri_1 = veri1.Text.ToString();
            string veri_2 = veri2.Text.ToString();
            string veri_3 = veri3.Text.ToString();
            string veri_4 = veri4.Text.ToString();
            string[] lrcdizi=new string[8];
            int sayac = 0;
            for(int i=0;i<7;i++)
            {
                if (veri_1[i] == '1')
                    sayac++;
            }
            if (sayac % 2 == 0)
            {
                vrc1.Text = "0";
                sayac = 0;
            }
            else
            {
                vrc1.Text = "1";
                sayac = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                if (veri_2[i] == '1')
                    sayac++;
            }

            if (sayac % 2 == 0)
            {
                vrc2.Text = "0";
                sayac = 0;
            }
            else
            {
                vrc2.Text = "1";
                sayac = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                if (veri_3[i] == '1')
                    sayac++;
            }
            if (sayac % 2 == 0)
            {
                vrc3.Text = "0";
                sayac = 0;
            }
            else
            {
                vrc3.Text = "1";
                sayac = 0;
            }

            for (int i = 0; i < 7; i++)
            {
                if (veri_4[i] == '1')
                    sayac++;
            }

            if (sayac % 2 == 0)
            {
                vrc4.Text = "0";
                sayac = 0;
            }
            else
            {
                vrc4.Text = "1";
                sayac = 0;
            }
            for (int i = 0; i < 7; i++)
            {
                 if (veri_1[i] == '1')
                    sayac++;
                if (veri_2[i] == '1')
                    sayac++;
                if (veri_3[i] == '1')
                    sayac++;
                if (veri_4[i] == '1')
                    sayac++;
                if (sayac % 2 == 1 && i==0)
                { 
                    lrc1.Text = "1";
                    sayac = 0;
                }
                else if (sayac % 2 == 0 && i == 0)
                {
                    lrc1.Text = "0";
                    sayac = 0;
                }
                if (sayac % 2 == 1 && i == 1)
                {
                    lrc2.Text = "1";
                    sayac = 0;
                }
                else if (sayac % 2 == 0 && i == 1)
                {
                    lrc2.Text = "0";
                    sayac = 0;
                }
                if (sayac % 2 == 1 && i == 2)
                {
                    lrc3.Text = "1";
                    sayac = 0;
                }
                else if (sayac % 2 == 0 && i == 2)
                {
                    lrc3.Text = "0";
                    sayac = 0;
                }
                if (sayac % 2 == 1 && i == 3)
                {
                    lrc4.Text = "1";
                    sayac = 0;
                }
                else if (sayac % 2 == 0 && i == 3)
                {
                    lrc4.Text = "0";
                    sayac = 0;
                }
                if (sayac % 2 == 1 && i == 4)
                {
                    lrc5.Text = "1";
                    sayac = 0;
                }
                else  if (sayac % 2 == 0 && i == 4)
                {
                    lrc5.Text = "0";
                    sayac = 0;
                }
                if (sayac % 2 == 1 && i == 5)
                {
                    lrc6.Text = "1";
                    sayac = 0;
                }
                else if (sayac % 2 == 0 && i == 5)
                {
                    lrc6.Text = "0";
                    sayac = 0;
                }
                if (sayac % 2 == 1 && i == 6)
                {
                    lrc7.Text = "1";
                    sayac = 0;
                }
                else if (sayac % 2 == 0 && i == 6)
                {
                    lrc7.Text = "0";
                    sayac = 0;
                }

            }
            if (vrc1.Text == "1")
                sayac++;
            if (vrc2.Text == "1")
                sayac++;
            if (vrc3.Text == "1")
                sayac++;
            if (vrc4.Text == "1")
                sayac++;
            if (sayac % 2 == 0)
                lrc8.Text = "0";
            else
                lrc8.Text = "1";


            
        }
    }
}
