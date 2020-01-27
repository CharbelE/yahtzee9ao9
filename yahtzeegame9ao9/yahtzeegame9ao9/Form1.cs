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

        int scoreYahtzee = 0;
        int scoreFullHouse = 0;
        int scoreSmallStreet = 0;
        int scoreLargeStreet = 0;
        int scoreThree = 0;
        int scoreFour = 0;

        int eye1 = 0;
        int eye2 = 0;
        int eye3 = 0;
        int eye4 = 0;
        int eye5 = 0;
        int eye6 = 0;

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

        private void btnRoll_Click_1(object sender, EventArgs e)
        {
            Random r = new Random();
            int iRnd = new int();

            eye1 = 0;
            eye2 = 0;
            eye3 = 0;
            eye4 = 0;
            eye5 = 0;
            eye6 = 0;
            if (count > 0)
            {
                count--;
                counter++;
                tbRoll.Text = count.ToString();

                if (counter < 4)
                {
                    countAlls();

                    if (hold1 != true)
                    {
                        iRnd = r.Next(1, 7);
                        if (iRnd == 1)
                        {
                            pbDice1.Image = pdDiceIns1.Image;
                            countAllOnes++;
                            eye1++;
                        }
                        else if (iRnd == 2)
                        {
                            pbDice1.Image = pdDiceIns2.Image;
                            countAllTwos++;
                            eye2++;
                        }
                        else if (iRnd == 3)
                        {
                            pbDice1.Image = pdDiceIns3.Image;
                            countAllThrees++;
                            eye3++;
                        }
                        else if (iRnd == 4)
                        {
                            pbDice1.Image = pdDiceIns4.Image;
                            countAllFours++;
                            eye4++;
                        }
                        else if (iRnd == 5)
                        {
                            pbDice1.Image = pdDiceIns5.Image;
                            countAllFives++;
                            eye5++;
                        }
                        else
                        {
                            pbDice1.Image = pdDiceIns6.Image;
                            countAllSixs++;
                            eye6++;
                        }
                    }

                    if (hold2 != true)
                    {
                        iRnd = r.Next(1, 7);
                        if (iRnd == 1)
                        {
                            pbDice2.Image = pdDiceIns1.Image;
                            countAllOnes++;
                            eye1++;
                        }
                        else if (iRnd == 2)
                        {
                            pbDice2.Image = pdDiceIns2.Image;
                            countAllTwos++;
                            eye2++;
                        }
                        else if (iRnd == 3)
                        {
                            pbDice2.Image = pdDiceIns3.Image;
                            countAllThrees++;
                            eye3++;
                        }
                        else if (iRnd == 4)
                        {
                            pbDice2.Image = pdDiceIns4.Image;
                            countAllFours++;
                            eye4++;
                        }
                        else if (iRnd == 5)
                        {
                            pbDice2.Image = pdDiceIns5.Image;
                            countAllFives++;
                            eye5++;
                        }
                        else
                        {
                            pbDice2.Image = pdDiceIns6.Image;
                            countAllSixs++;
                            eye6++;
                        }
                    }
                }

                if (hold3 != true)
                {
                    iRnd = r.Next(1, 7);
                    if (iRnd == 1)
                    {
                        pbDice3.Image = pdDiceIns1.Image;
                        countAllOnes++;
                        eye1++;
                    }
                    else if (iRnd == 2)
                    {
                        pbDice3.Image = pdDiceIns2.Image;
                        countAllTwos++;
                        eye2++;
                    }
                    else if (iRnd == 3)
                    {
                        pbDice3.Image = pdDiceIns3.Image;
                        countAllThrees++;
                        eye3++;
                    }
                    else if (iRnd == 4)
                    {
                        pbDice3.Image = pdDiceIns4.Image;
                        countAllFours++;
                        eye4++;
                    }
                    else if (iRnd == 5)
                    {
                        pbDice3.Image = pdDiceIns5.Image;
                        countAllFives++;
                        eye5++;
                    }
                    else
                    {
                        pbDice3.Image = pdDiceIns6.Image;
                        countAllSixs++;
                        eye6++;
                    }
                }

                if (hold4 != true)
                {
                    iRnd = r.Next(1, 7);
                    iRnd = r.Next(1, 7);
                    if (iRnd == 1)
                    {
                        pbDice4.Image = pdDiceIns1.Image;
                        countAllOnes++;
                        eye1++;
                    }
                    else if (iRnd == 2)
                    {
                        pbDice4.Image = pdDiceIns2.Image;
                        countAllTwos++;
                        eye2++;
                    }
                    else if (iRnd == 3)
                    {
                        pbDice4.Image = pdDiceIns3.Image;
                        countAllThrees++;
                        eye3++;
                    }
                    else if (iRnd == 4)
                    {
                        pbDice4.Image = pdDiceIns4.Image;
                        countAllFours++;
                        eye4++;
                    }
                    else if (iRnd == 5)
                    {
                        pbDice4.Image = pdDiceIns5.Image;
                        countAllFives++;
                        eye5++;
                    }
                    else
                    {
                        pbDice4.Image = pdDiceIns6.Image;
                        countAllSixs++;
                        eye6++;
                    }
                }

                if (hold5 != true)
                {
                    iRnd = r.Next(1, 7);
                    if (iRnd == 1)
                    {
                        pbDice5.Image = pdDiceIns1.Image;
                        countAllOnes++;
                        eye1++;
                    }
                    else if (iRnd == 2)
                    {
                        pbDice5.Image = pdDiceIns2.Image;
                        countAllTwos++;
                        eye2++;
                    }
                    else if (iRnd == 3)
                    {
                        pbDice5.Image = pdDiceIns3.Image;
                        countAllThrees++;
                        eye3++;
                    }
                    else if (iRnd == 4)
                    {
                        pbDice5.Image = pdDiceIns4.Image;
                        countAllFours++;
                        eye4++;
                    }
                    else if (iRnd == 5)
                    {
                        pbDice5.Image = pdDiceIns5.Image;
                        countAllFives++;
                        eye5++;
                    }
                    else
                    {
                        pbDice5.Image = pdDiceIns6.Image;
                        countAllSixs++;
                        eye6++;
                    }
                }
            }

            street();
            FullHouse();
            threeofakind();
            fourofakind();
            countNumber();
            yatzee();
            totalAll();
            totalscore();
            totalChance();
        }

        private void totalscore()
        {
            int total = 0;
            total = scoreThree + scoreLargeStreet + scoreYahtzee + scoreSmallStreet + scoreFour + scoreFullHouse;

            tbtotalscore.Text = total.ToString();
        }

        private void yatzee()
        {

            if (!yahtzee && (countAllOnes == 5 || countAllTwos == 5 || countAllThrees == 5 || countAllFours == 5 || countAllFives == 5 || countAllSixs == 6))
            {
                yahtzee = true;
                countYahtzee++;
                scoreYahtzee += 50;
                tbYahtzee.Text = countYahtzee.ToString();
            }
        }

        private void street()
        {
            if (((countAllOnes == 1 || countAllOnes == 2) && (countAllTwos == 1 || countAllTwos == 2) && (countAllThrees == 1 || countAllThrees == 2) && (countAllFours == 1 || countAllFours == 2) || (countAllTwos == 1 || countAllTwos == 2) && (countAllThrees == 1 || countAllThrees == 2) && (countAllFours == 1 || countAllFours == 2) && (countAllFives == 1 || countAllFives == 2) || (countAllThrees == 1 || countAllThrees == 2) && (countAllFours == 1 || countAllFours == 2) && (countAllFives == 1 || countAllFives == 2) && (countAllSixs == 1 || countAllSixs == 2)))
            {
                countsmallstreet++;
                scoreSmallStreet += 30;

            }
            tbSmallStreet.Text = countsmallstreet.ToString();

            if ((countAllOnes == 1 && countAllTwos == 1 && countAllThrees == 1 && countAllFours == 1 && countAllFives == 1 || countAllTwos == 1 && countAllThrees == 1 && countAllFours == 1 && countAllFives == 1 && countAllSixs == 1))
            {
                countlargestreet++;
                scoreLargeStreet += 40;

            }
            tbLargeStreet.Text = countlargestreet.ToString();


        }

        private void totalAll()
        {
            tbTotalAll.Text = totalalll(countYahtzee, countlargestreet, countsmallstreet, threekind, fourkind, volhuis).ToString();
        }
        private double totalalll(double a, double b, double c, double d, double e, double f)
        {
            return a + b + c + d + e + f;
        }

        private void FullHouse()
        {
            if (((countAllOnes == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllFours == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllTwos == 3 && (countAllOnes == 2 || countAllThrees == 2 || countAllFours == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllThrees == 3 && (countAllTwos == 2 || countAllOnes == 2 || countAllFours == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllFours == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllOnes == 2 || countAllFives == 2 || countAllSixs == 2)) ||
                (countAllFives == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllFours == 2 || countAllOnes == 2 || countAllSixs == 2)) ||
                (countAllSixs == 3 && (countAllTwos == 2 || countAllThrees == 2 || countAllFours == 2 || countAllFives == 2 || countAllOnes == 2))))
            {

                volhuis++;
                scoreFullHouse += 25;
            }
            tbFullHouse.Text = volhuis.ToString();
        }

        private void threeofakind()
        {

            if (countAllOnes == 3)
            {
                scoreThree += 3 * 1;
                threekind++;
            }
            else if (countAllTwos == 3)
            {
                scoreThree += 3 * 2;
                threekind++;
            }

            else if (countAllThrees == 3)
            {
                scoreThree += 3 * 3;
                threekind++;
            }
            else if (countAllFours == 3)
            {
                scoreThree += 3 * 4;
                threekind++;
            }
            else if (countAllFives == 3)
            {
                scoreThree += 3 * 5;
                threekind++;
            }
            else if (countAllSixs == 3)
            {
                scoreThree += 3 * 6;
                threekind++;
            }


            tb3OfAKind.Text = threekind.ToString();
        }

        private void totalChance()
        {
            int total = 0;
            total = (1 * eye1) + (2 * eye2) + (3 * eye3) + (4 * eye4) + (5 * eye5) + (6 * eye6);

            tbchance.Text = total.ToString();
        }

        private void fourofakind()
        {
            if (countAllOnes == 4)
            {
                scoreThree += 4 * 1;

                fourkind++;
            }
            else if (countAllTwos == 4)
            {
                scoreThree += 4 * 2;

                fourkind++;
            }

            else if (countAllThrees == 4)
            {
                scoreThree += 4 * 3;

                fourkind++;
            }
            else if (countAllFours == 4)
            {
                scoreThree += 4 * 4;

                fourkind++;
            }
            else if (countAllFives == 4)
            {
                scoreThree += 4 * 5;

                fourkind++;
            }
            else if (countAllSixs == 4)
            {
                scoreThree += 4 * 6;

                fourkind++;
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


        private void btnHold_Click_1(object sender, EventArgs e)
        {
            hold1 = true;
            btnHold.Text = "Holded";
        }

        private void btnHold2_Click_1(object sender, EventArgs e)
        {
            hold2 = true;
            btnHold2.Text = "Holded";
        }

        private void btnHold3_Click_1(object sender, EventArgs e)
        {
            hold3 = true;
            btnHold3.Text = "Holded";
        }

        private void btnHold4_Click_1(object sender, EventArgs e)
        {
            hold4 = true;
            btnHold4.Text = "Holded";
        }

        private void btnHold5_Click_1(object sender, EventArgs e)
        {
            hold5 = true;
            btnHold5.Text = "Holded";
        }

        public void btnReset_Click_1(object sender, EventArgs e)
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

