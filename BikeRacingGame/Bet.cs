using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRacingGame
{
    public class Bet
    {
        //global variables declaration
        public int Amount;
        public int Bike;
        public Guy Bettor;

        public Bet(int Amount, int Bike, Guy Bettor)//this is constructor
        {
            this.Amount = Amount;
            this.Bike = Bike;
            this.Bettor = Bettor;
        }

        public string GetDescription()//this function is for setting the description of labels when bet is placed and amount is changed
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets ${1} on bike #{2}", Bettor.Name, Amount, Bike);
            }
            else
            {
                description = String.Format("{0} hasn't placed any bets", Bettor.Name);
            }


            return description;
        }

        public int PayOut(int Winner)//this function is for payout to those who win the race
        {
            if (Bike == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
