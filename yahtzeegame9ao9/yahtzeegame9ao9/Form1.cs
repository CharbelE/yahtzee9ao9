using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yahtzeegame9ao9
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = (byte)objRandom.Next(1, 7);
            }
        }

        private void btnHold_Click(object sender, EventArgs e)
        {

        }

        private void btnHold2_Click(object sender, EventArgs e)
        {

        }

        private void btnHold3_Click(object sender, EventArgs e)
        {

        }

        private void btnHold4_Click(object sender, EventArgs e)
        {

        }

        private void btnHold5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegels_Click(object sender, EventArgs e)
        {

        }
    }
}
