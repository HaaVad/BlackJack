using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Player
    {
        Card card = new();
        public int PlayerScoreKeeper(List<Card>hand)
        {
            int score = 0;
            foreach (Card playerCard in hand)
            {
                score += playerCard.BJValue;
            }
            
            return score;
        }

        public void ShowHand(List<Card>hand) 
        {
        foreach (Card playerCard in hand) 
            {
            card.ShowCard(playerCard);
            Thread.Sleep(700);
            }
        }
    }
}
