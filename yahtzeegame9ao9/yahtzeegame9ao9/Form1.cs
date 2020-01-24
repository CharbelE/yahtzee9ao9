﻿using System;
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
        int counter = 0;
        int count = 3;
        int countAllOnes = 0;
        int countAllTwos = 0;
        int countAllThrees = 0;
        int countAllFours = 0;
        int countAllFives = 0;
        int countAllSixs = 0;
        int fourkind = 0;
        int threekind = 0;
        int countsmallstreet = 0;
        int countlargestreet = 0;
        int volhuis = 0;
        int countYahtzee = 0;
        bool hold1 = false;
        bool hold2 = false;
        bool hold3 = false;
        bool hold4 = false;
        bool hold5 = false;
        bool threek = false;
        bool fourk = false;
        bool sstreet = true;
        bool lstreet = false;
        bool volhouse = false;
        bool yahtzee = false;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnRegels_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.spelregels.eu/PDF/spelregels-yahtzee.pdf");
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int iRnd = new int();
            if (count > 0)
            {


                count--;

                counter++;

                tbRoll.Text = count.ToString();


                if (counter < 4)
                {
                    if (!hold1)
                        resetTotals();
                    if (hold1 != true)
                    {
                        iRnd = r.Next(1, 7);
                        if (iRnd == 1)
                        {
                            pbDice1.Image = pdDiceIns1.Image;
                            countAllOnes++;
                        }
                        else if (iRnd == 2)
                        {
                            pbDice1.Image = pdDiceIns2.Image;
                            countAllTwos++;
                        }
                        else if (iRnd == 3)
                        {
                            pbDice1.Image = pdDiceIns3.Image;
                            countAllThrees++;
                        }
                        else if (iRnd == 4)
                        {
                            pbDice1.Image = pdDiceIns4.Image;
                            countAllFours++;
                        }
                        else if (iRnd == 5)
                        {
                            pbDice1.Image = pdDiceIns5.Image;
                            countAllFives++;
                        }
                        else
                        {
                            pbDice1.Image = pdDiceIns6.Image;
                            countAllSixs++;
                        }
                    }

                    if (hold2 != true)
                    {
                        iRnd = r.Next(1, 7);
                        if (iRnd == 1)
                        {
                            pbDice2.Image = pdDiceIns1.Image;
                            countAllOnes++;
                        }
                        else if (iRnd == 2)
                        {
                            pbDice2.Image = pdDiceIns2.Image;
                            countAllTwos++;
                        }
                        else if (iRnd == 3)
                        {
                            pbDice2.Image = pdDiceIns3.Image;
                            countAllThrees++;
                        }
                        else if (iRnd == 4)
                        {
                            pbDice2.Image = pdDiceIns4.Image;
                            countAllFours++;
                        }
                        else if (iRnd == 5)
                        {
                            pbDice2.Image = pdDiceIns5.Image;
                            countAllFives++;
                        }
                        else
                        {
                            pbDice2.Image = pdDiceIns6.Image;
                            countAllSixs++;
                        }
                    }

                    if (hold3 != true)
                    {
                        iRnd = r.Next(1, 7);
                        if (iRnd == 1)
                        {
                            pbDice3.Image = pdDiceIns1.Image;
                            countAllOnes++;
                        }
                        else if (iRnd == 2)
                        {
                            pbDice3.Image = pdDiceIns2.Image;
                            countAllTwos++;
                        }
                        else if (iRnd == 3)
                        {
                            pbDice3.Image = pdDiceIns3.Image;
                            countAllThrees++;
                        }
                        else if (iRnd == 4)
                        {
                            pbDice3.Image = pdDiceIns4.Image;
                            countAllFours++;
                        }
                        else if (iRnd == 5)
                        {
                            pbDice3.Image = pdDiceIns5.Image;
                            countAllFives++;
                        }
                        else
                        {
                            pbDice3.Image = pdDiceIns6.Image;
                            countAllSixs++;
                        }
                    }

                    if (hold4 != true)
                    {
                        iRnd = r.Next(1, 7);
                        if (iRnd == 1)
                        {
                            pbDice4.Image = pdDiceIns1.Image;
                            countAllOnes++;
                        }
                        else if (iRnd == 2)
                        {
                            pbDice4.Image = pdDiceIns2.Image;
                            countAllTwos++;
                        }
                        else if (iRnd == 3)
                        {
                            pbDice4.Image = pdDiceIns3.Image;
                            countAllThrees++;
                        }
                        else if (iRnd == 4)
                        {
                            pbDice4.Image = pdDiceIns4.Image;
                            countAllFours++;
                        }
                        else if (iRnd == 5)
                        {
                            pbDice4.Image = pdDiceIns5.Image;
                            countAllFives++;
                        }
                        else
                        {
                            pbDice4.Image = pdDiceIns6.Image;
                            countAllSixs++;
                        }
                    }

                    if (hold5 != true)
                    {
                        iRnd = r.Next(1, 7);
                        if (iRnd == 1)
                        {
                            pbDice5.Image = pdDiceIns1.Image;
                            countAllOnes++;
                        }
                        else if (iRnd == 2)
                        {
                            pbDice5.Image = pdDiceIns2.Image;
                            countAllTwos++;
                        }
                        else if (iRnd == 3)
                        {
                            pbDice5.Image = pdDiceIns3.Image;
                            countAllThrees++;
                        }
                        else if (iRnd == 4)
                        {
                            pbDice5.Image = pdDiceIns4.Image;
                            countAllFours++;
                        }
                        else if (iRnd == 5)
                        {
                            pbDice5.Image = pdDiceIns5.Image;
                            countAllFives++;
                        }
                        else
                        {
                            pbDice5.Image = pdDiceIns6.Image;
                            countAllSixs++;
                        }
                    }
                }
            }
            street();
            FullHouse();
            threeofakind();
            fourofakind();
            countNumber();
            yatzee();
        }

        private void yatzee()
        {

            if (!yahtzee && (countAllOnes == 5 || countAllTwos == 5 || countAllThrees == 5 || countAllFours == 5 || countAllFives == 5 || countAllSixs == 6))
            {
                yahtzee = true;
                countYahtzee++;
                tbYahtzee.Text = countYahtzee.ToString();
            }
        }

        private void street()
        {
            if (sstreet && (countAllOnes == 1 && countAllTwos == 1 && countAllThrees == 1 && countAllFours == 1 && countAllFives == 1 || countAllTwos == 1 && countAllThrees == 1 && countAllFours == 1 && countAllFives == 1 && countAllSixs == 1))
            {
                countlargestreet++;
                sstreet = false;
            }
            tbLargeStreet.Text = countlargestreet.ToString();

            if (!lstreet && ((countAllOnes == 1 || countAllOnes == 2) && (countAllTwos == 1 || countAllTwos == 2) && (countAllThrees == 1 || countAllThrees == 2) && (countAllFours == 1 || countAllFours == 2) || (countAllTwos == 1 || countAllTwos == 2) && (countAllThrees == 1 || countAllThrees == 2) && (countAllFours == 1 || countAllFours == 2) && (countAllFives == 1 || countAllFives == 2) || (countAllThrees == 1 || countAllThrees == 2) && (countAllFours == 1 || countAllFours == 2) && (countAllFives == 1 || countAllFives == 2) && (countAllSixs == 1 || countAllSixs == 2)))
            {
                countsmallstreet++;
                lstreet = true;
            }
            tbSmallStreet.Text = countsmallstreet.ToString();
        }

        private void FullHouse()
        {
            if (!volhouse && ((countAllOnes == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllFours == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllTwos == 3 && (countAllOnes == 2 || countAllThrees == 2 || countAllFours == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllThrees == 3 && (countAllTwos == 2 || countAllOnes == 2 || countAllFours == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllFours == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllOnes == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllFives == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllFours == 2 || countAllOnes == 2 || countAllSixs == 2)) ||
                (countAllSixs == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllFours == 2 || countAllFives == 2 || countAllOnes == 2))))
            {
                volhouse = true;
                volhuis++;
            }
            tbFullHouse.Text = volhuis.ToString();
        }

        private void threeofakind()
        {

            if (!threek && (countAllOnes == 3 || countAllTwos == 3 || countAllThrees == 3 || countAllFours == 3 || countAllFives == 3 || countAllSixs == 3))
            {
                threekind++;
                threek = true;
            }
            tb3OfAKind.Text = threekind.ToString();
        }

        private void fourofakind()
        {
            if (!fourk && (countAllOnes == 4 || countAllTwos == 4 || countAllThrees == 4 || countAllFours == 4 || countAllFives == 4 || countAllSixs == 4))
            {
                fourkind++;
                fourk = true;
            }
            tb4OfAKind.Text = fourkind.ToString();
        }

        private void countNumber()
        {
            tbTotal1.Text = countAllOnes.ToString();
            tbTotal2.Text = countAllTwos.ToString();
            tbTotal3.Text = countAllThrees.ToString();
            tbTotal4.Text = countAllFours.ToString();
            tbTotal5.Text = countAllFives.ToString();
            tbTotal6.Text = countAllSixs.ToString();
        }
        private void btnHold_Click(object sender, EventArgs e)
        {
            hold1 = true;
            btnHold.Text = "Holded";
        }

        private void btnHold2_Click(object sender, EventArgs e)
        {
            hold2 = true;
            btnHold2.Text = "Holded";
        }

        private void btnHold3_Click(object sender, EventArgs e)
        {
            hold3 = true;
            btnHold3.Text = "Holded";
        }

        private void btnHold4_Click(object sender, EventArgs e)
        {
            hold4 = true;
            btnHold4.Text = "Holded";
        }

        private void btnHold5_Click(object sender, EventArgs e)
        {
            hold5 = true;
            btnHold5.Text = "Holded";
        }

        public void btnReset_Click(object sender, EventArgs e)
        {
            btnHoldsReset();
            threek = false;
            fourk = false;
            sstreet = true;
            lstreet = false;
            volhouse = false;
            yahtzee = false;
            HoldstextReset();
            pbDicesReset();
            countAlls();
            counter = 0;
            count = 3;
            tbRoll.Text = "3";
            resetTotals();
        }

        private void btnHoldsReset()
        {
            hold1 = false;
            hold2 = false;
            hold3 = false;
            hold4 = false;
            hold5 = false;
        }

        private void HoldstextReset()
        {
            btnHold.Text = "Hold";
            btnHold2.Text = "Hold";
            btnHold3.Text = "Hold";
            btnHold4.Text = "Hold";
            btnHold5.Text = "Hold";
        }

        private void pbDicesReset()
        {
            pbDice1.Image = pdDiceInsb.Image;
            pbDice2.Image = pdDiceInsb.Image;
            pbDice3.Image = pdDiceInsb.Image;
            pbDice4.Image = pdDiceInsb.Image;
            pbDice5.Image = pdDiceInsb.Image;
        }

        private void countAlls()
        {
            countAllOnes = 0;
            countAllTwos = 0;
            countAllThrees = 0;
            countAllFours = 0;
            countAllFives = 0;
            countAllSixs = 0;
            countlargestreet = 0;
            countsmallstreet = 0;
            countYahtzee = 0;
            volhuis = 0;
            threekind = 0;
            fourkind = 0;
        }

        private void resetTotals()
        {
            tbTotal1.Text = "";
            tbTotal2.Text = "";
            tbTotal3.Text = "";
            tbTotal4.Text = "";
            tbTotal5.Text = "";
            tbTotal6.Text = "";
            tb3OfAKind.Text = "";
            tb4OfAKind.Text = "";
            tbFullHouse.Text = "";
            tbLargeStreet.Text = "";
            tbSmallStreet.Text = "";
            tbTotalAll.Text = "";
            tbYahtzee.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}