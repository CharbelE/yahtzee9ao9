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
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        bool hold1 = false;
        bool hold2 = false;
        bool hold3 = false;
        bool hold4 = false;
        bool hold5 = false;
        public Form1()
        {
            InitializeComponent();

            player.SoundLocation = "bensound-theelevatorbossanova.wav";
        }
         private void btnRegels_Click(object sender, EventArgs e)
                {
                    System.Diagnostics.Process.Start("https://www.spelregels.eu/PDF/spelregels-yahtzee.pdf");
                }
        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int iRnd = new int();

            iRnd = r.Next(0, 6);
            if (hold1 != true)
            {

                if (iRnd == 0)
                { pbDice1.Image = pdDiceIns1.Image; }
                else if (iRnd == 1)
                { pbDice1.Image = pdDiceIns2.Image; }
                else if (iRnd == 2)
                { pbDice1.Image = pdDiceIns3.Image; }
                else if (iRnd == 3)
                { pbDice1.Image = pdDiceIns4.Image; }
                else if (iRnd == 4)
                { pbDice1.Image = pdDiceIns5.Image; }
                else
                { pbDice1.Image = pdDiceIns6.Image; }
            }

            if (hold2 != true)
            {
                iRnd = r.Next(0, 6);
                if (iRnd == 0)
                { pbDice2.Image = pdDiceIns1.Image; }
                else if (iRnd == 1)
                { pbDice2.Image = pdDiceIns2.Image; }
                else if (iRnd == 2)
                { pbDice2.Image = pdDiceIns3.Image; }
                else if (iRnd == 3)
                { pbDice2.Image = pdDiceIns4.Image; }
                else if (iRnd == 4)
                { pbDice2.Image = pdDiceIns5.Image; }
                else
                { pbDice2.Image = pdDiceIns6.Image; }
            }

            if (hold3 != true)
            {
                iRnd = r.Next(0, 6);
                if (iRnd == 0)
                { pbDice3.Image = pdDiceIns1.Image; }
                else if (iRnd == 1)
                { pbDice3.Image = pdDiceIns2.Image; }
                else if (iRnd == 2)
                { pbDice3.Image = pdDiceIns3.Image; }
                else if (iRnd == 3)
                { pbDice3.Image = pdDiceIns4.Image; }
                else if (iRnd == 4)
                { pbDice3.Image = pdDiceIns5.Image; }
                else
                { pbDice3.Image = pdDiceIns6.Image; }
            }

            if (hold4 != true)
            {
                iRnd = r.Next(0, 6);
                if (iRnd == 0)
                { pbDice4.Image = pdDiceIns1.Image; }
                else if (iRnd == 1)
                { pbDice4.Image = pdDiceIns2.Image; }
                else if (iRnd == 2)
                { pbDice4.Image = pdDiceIns3.Image; }
                else if (iRnd == 3)
                { pbDice4.Image = pdDiceIns4.Image; }
                else if (iRnd == 4)
                { pbDice4.Image = pdDiceIns5.Image; }
                else
                { pbDice4.Image = pdDiceIns6.Image; }
            }

            if (hold5 != true)
            {
                iRnd = r.Next(0, 6);
                if (iRnd == 0)
                { pbDice5.Image = pdDiceIns1.Image; }
                else if (iRnd == 1)
                { pbDice5.Image = pdDiceIns2.Image; }
                else if (iRnd == 2)
                { pbDice5.Image = pdDiceIns3.Image; }
                else if (iRnd == 3)
                { pbDice5.Image = pdDiceIns4.Image; }
                else if (iRnd == 4)
                { pbDice5.Image = pdDiceIns5.Image; }
                else
                { pbDice5.Image = pdDiceIns6.Image; }
            }


        }

        private void btnHold_Click(object sender, EventArgs e)
        {
            hold1 = true;
        }

        private void btnHold2_Click(object sender, EventArgs e)
        {
            hold2 = true;
        }
        private void btnHold3_Click(object sender, EventArgs e)
        {
            hold3 = true;
        }
        private void btnHold4_Click(object sender, EventArgs e)
        {
            hold4 = true;
        }
        private void btnHold5_Click(object sender, EventArgs e)
        {
            hold5 = true;
        }

        private void btnHold4_Click_1(object sender, EventArgs e)
        {
            hold4 = true;
        }

        private void btnHold3_Click_1(object sender, EventArgs e)
        {
            hold3 = true;
        }

        private void btnHold5_Click_1(object sender, EventArgs e)
        {
            hold5 = true;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            hold1 = false;
            hold2 = false;
            hold3 = false;
            hold4 = false;
            hold5 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

