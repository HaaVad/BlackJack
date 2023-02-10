using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Dealer
    {
        public Random random = new();


        public void WhoIsTheWinner(int playerPoints, int dealerPoints)
        {
            if (playerPoints > 21)
                Console.WriteLine($"You have {playerPoints} points.... thats a lose.");
            else if (dealerPoints > 21 && playerPoints < 22)
                Console.WriteLine($"Dealer havs {dealerPoints} points.... you win!");
            else
            {
                if (playerPoints < dealerPoints)
                {
                    Console.WriteLine($"Dealer points: {dealerPoints}");
                    Console.WriteLine($"Player points: {playerPoints}");
                    Console.WriteLine("You lose!");
                }
                else if (playerPoints == dealerPoints)
                {
                    Console.WriteLine("Its a draw! Or an error... who can tell?!");
                }
                else if (playerPoints == 21)
                {
                    Console.WriteLine("BLACKJAAAACK! YOU WIIIIN!");
                }
                else
                {
                    Console.WriteLine($"Dealer points: {dealerPoints}");
                    Console.WriteLine($"Player points: {playerPoints}");
                    Console.WriteLine("You Win!");
                }
            }
        }


        public void NewRound(List<Card>handOne,List<Card>handTwo)
        {
            Console.Clear();
            handOne.Clear();
            handTwo.Clear();
            Console.WriteLine("Shuffling Cards...");
            Thread.Sleep(1000);
            Console.Clear();
        }



    }
}
                 