using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeRacingGame
{
    public partial class Form1 : Form
    {
        //This Bike race Code developed by Sukhman Singh
        //Creating the objects of classes
        Greyhound[] lovebikes = new Greyhound[4];//instance of greyhound class
        Guy[] guys = new Guy[3];//object of guy class
        public Form1()
        {
            InitializeComponent();
            RaceTrackSetting();//calling the set race track funtion
        }

        private void buttonBets_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

            if (radioButtonJoe.Checked)
            {
                GuyNumber = 0;//when radio button joe is checked then set its id is 0
            }
            if (radioButtonBob.Checked)
            {
                GuyNumber = 1;//when radio button bob is checked then set its id is 1
            }
            if (radioButtonAI.Checked)
            {
                GuyNumber = 2;//when radio button ai is checked then set its id is 2
            }

            guys[GuyNumber].PlaceBet((int)numericUpDownBets.Value, (int)numericUpDownCar.Value);//when any radio button is checked then place bet function is called and bet is placed and show amount and car number
            guys[GuyNumber].UpdateLabels();//with this code line the labels are updated
        }

        //private void buttonReset_Click(object sender, EventArgs e)
        //{

        //}

        private void buttonRace_Click(object sender, EventArgs e)
        {
            BikeRacingStart();//calling the function of car race start with this function when we click on the race button the race will start
        }

        private void radioButtonJoe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBob_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAI_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void RaceTrackSetting()//this funtion is for setting the race track
        {
            MinimumBet.Text = string.Format("Minimum Bet $1", (int)numericUpDownBets.Minimum);//Showing the minimum bet rate in label

            int startingPosition = Racer1.Right - RaceTrack.Left; //Setting the variable for starting position from car 1
            int raceTrackLength = RaceTrack.Size.Width;//Setting the variable of length of racetrack

            //Setting values of the array of the class greyhound for racing for the first part of the game as suggested in assignment
            lovebikes[0] = new Greyhound()
            {
                MyPictureBox = Racer1,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };

            lovebikes[1] = new Greyhound()
            {
                MyPictureBox = Racer2,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            lovebikes[2] = new Greyhound()
            {
                MyPictureBox = Racer3,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            lovebikes[3] = new Greyhound()
            {
                MyPictureBox = Racer4,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };

            //this part is for assigning the constructor values which is created in guy class
            guys[0] = new Guy("Joe", null, 50, radioButtonJoe, labelJoesBet);
            guys[1] = new Guy("Bob", null, 75, radioButtonBob, labelBobsBet);
            guys[2] = new Guy("Al", null, 45, radioButtonAI, labelAlsBet);

            foreach (Guy guy in guys)
            {
                guy.UpdateLabels();//using the foreach loop for assigning the values of labels for bet
            }
        }

        private void BikeRacingStart()//this is function for starting the race
        {
            bool NoWinner = true;
            int winningBike;
            buttonRace.Enabled = false;//Button will be false whenever race is continue

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < lovebikes.Length; i++)//loop start and it will continue whenever length of greyhound class or track is not finished
                {
                    Thread.Sleep(1);//sleep function for the speed of cars
                    if (lovebikes[i].Run())//here run function is called from greyhound class for running the cars and condition is checked for three random cars
                    {
                        winningBike = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - Bike #" + winningBike);
                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)//condition is checked for betting
                            {
                                guy.Collect(winningBike);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }

                        foreach (Greyhound car in lovebikes)
                        {
                            car.TakeStartingPosition();
                        }

                        break;
                    }
                }

            }

            buttonRace.Enabled = true;//here race button is enabled when race is finished

        }
    }
}
