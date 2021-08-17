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
    public partial class acilis : Form
    {
        public acilis()
        {
            InitializeComponent();
        }

        private void CHECKSUM_Click(object sender, EventArgs e)
        {
            checksum cs = new checksum();
            cs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lrcvrc lv = new lrcvrc();
            lv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hamming h = new hamming();
            h.ShowDialog();
        }

        private void CRC_Click(object sender, EventArgs e)
        {
            crc c = new crc();
            c.ShowDialog();
        }
    }
}
