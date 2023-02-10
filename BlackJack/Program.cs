namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dealer dealer = new();
            Card card = new();
            List<Card> Hand = new();
            List<Card> Deck = card.MakeDeck();
            List<Card> DealerHand = new();
            char play = 'y';
            int playerPoints = 0;
            int dealerPoints = 0;


            Console.WriteLine("Lets play Blackjack!");
            //Second try
            while (play =='y' || playerPoints < 22 || dealerPoints < 22)
            {



            }

            //First try
            //while (play == 'y')
            //{
            //    int playerPoints = 0;
            //    int dealerPoints = 0;
            //    Hand.Add(card.PickCard(Deck));
            //    Hand.Add(card.PickCard(Deck));
            //    DealerHand.Add(card.PickCard(Deck));
            //    DealerHand.Add(card.PickCard(Deck));

            //    foreach (Card playerCard in Hand)
            //    {
            //        card.ShowCard(playerCard);
            //        playerPoints += playerCard.BJValue;
            //    }
            //    Console.WriteLine($"You have {playerPoints}");

            //    foreach (Card dealerCard in DealerHand)
            //    {
            //        dealerPoints += dealerCard.BJValue;
            //    }
            //    Console.WriteLine("One of the Dealers cards is:");
            //    card.ShowCard(DealerHand[1]);
            //    Console.WriteLine("Hit or stay? y/n");
            //    char drawCard = Console.ReadKey(intercept: true).KeyChar;
            //    while (drawCard == 'y')
            //    {
            //        Console.Clear();
            //        Hand.Add(card.PickCard(Deck));
            //        playerPoints = 0;

            //        foreach (Card playerCard in Hand)
            //        {
            //            card.ShowCard(playerCard);
            //            Thread.Sleep(500);
            //            playerPoints += playerCard.BJValue;
            //        }
            //        Console.WriteLine($"You have {playerPoints}");
            //        Console.WriteLine("Hit or stay? y/n");
            //        drawCard = Console.ReadKey(intercept: true).KeyChar;
            //    }
            //    if (drawCard == 'n')
            //    {
            //        while (dealerPoints < 18)
            //        {
            //            dealerPoints = 0;
            //            DealerHand.Add(card.PickCard(Deck));
            //            foreach (Card dealerCard in DealerHand)
            //            {
            //                dealerPoints += dealerCard.BJValue;
            //            }
            //        }
            //        dealer.WhoIsTheWinner(playerPoints, dealerPoints);
            //    }

            //    Console.WriteLine("Go again? y/n");
            //    play = Console.ReadKey(intercept: true).KeyChar;
            //    if (play == 'y')
            //    { dealer.NewRound(Hand, DealerHand); }


            //}


        }
    }
}