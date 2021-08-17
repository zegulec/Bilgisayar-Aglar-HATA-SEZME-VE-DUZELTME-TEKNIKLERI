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
    public partial class hamming : Form
    {
        public hamming()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char [] tumveri = new char [11];
            string verim = txtyanlis.Text.ToString();
            tumveri[2] = verim[0];
            tumveri[4] = verim[1];
            tumveri[5] = verim[2];
            tumveri[6] = verim[3];
            tumveri[8] = verim[4];
            tumveri[9] = verim[5];
            tumveri[10] = verim[6];
            int sayac = 1;
            int i,j;
            for( i=0;i<11;)
            {
                if (tumveri[i] == '1')
                    sayac++;
                i = i + 2;
            }
            if (sayac % 2 == 0)
                tumveri[0] = '0';
            else
                tumveri[0] = '1';
            sayac = 1;


            for (i = 1; i < 11; )
            {
                for (j = i; j < i+2; )
                {
                    if (tumveri[j] == '1')
                        sayac++;
                    if (j <= 10)
                        j = j + 1;
                    else break;
                }
                i = i + 4;
            }

            if (sayac % 2 == 0)
                tumveri[1] = '0';
            else
                tumveri[1] = '1';
            sayac = 1;

            for (i = 3; i < 11; )
            {
                for (j = i; j < i + 4; )
                {
                    if (tumveri[j] == '1')
                        sayac++;
                    if (j <= 10)
                        j = j + 1;
                    else break;
                }
                i = i + 8;
            }

            if (sayac % 2 == 0)
                tumveri[3] = '0';
            else
                tumveri[3] = '1';
            sayac = 1;

            for (i = 7; i < 11; )
            {
                for (j = i; j < 11; )
                {
                    if (tumveri[j] == '1')
                        sayac++;
                    if (j <= 10)
                        j = j + 1;
                    else break;
                }
                i = i + 8;
            }

            if (sayac % 2 == 0)
                tumveri[7] = '0';
            else
                tumveri[7] = '1';
            

            txtonuc.Text = tumveri[0].ToString() + tumveri[1].ToString() + tumveri[3].ToString() + tumveri[7].ToString();

        }
    }
}
