using BlackJack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        Random random = new();
        public string Color { get; set; }
        public string Value { get; set; }
        public int BJValue { get; set; }
        public Card() { }
        public Card(string value,string color, int bJValue) 
        {
            Value= value;
            Color = color;
            BJValue= bJValue;
        }
        public List<Card> MakeDeck()
        {
            List<Card> cards = new();
            cards.Add(new Card("A", "Hearts",11));
            cards.Add(new Card("2", "Hearts",2));
            cards.Add(new Card("3", "Hearts",3));
            cards.Add(new Card("4", "Hearts",4));
            cards.Add(new Card("5", "Hearts",5));
            cards.Add(new Card("6", "Hearts",6));
            cards.Add(new Card("7", "Hearts",7));
            cards.Add(new Card("8", "Hearts",8));
            cards.Add(new Card("9", "Hearts",9));
            cards.Add(new Card("X", "Hearts",10));
            cards.Add(new Card("J", "Hearts",10));
            cards.Add(new Card("Q", "Hearts",10));
            cards.Add(new Card("K", "Hearts",10));
            cards.Add(new Card("A", "Spades",11));
            cards.Add(new Card("2", "Spades",2));
            cards.Add(new Card("3", "Spades",3));
            cards.Add(new Card("4", "Spades",4));
            cards.Add(new Card("5", "Spades",5));
            cards.Add(new Card("6", "Spades",6));
            cards.Add(new Card("7", "Spades",7));
            cards.Add(new Card("8", "Spades",8));
            cards.Add(new Card("9", "Spades",9));
            cards.Add(new Card("X", "Spades",10));
            cards.Add(new Card("J", "Spades",10));
            cards.Add(new Card("Q", "Spades",10));
            cards.Add(new Card("K", "Spades",10));
            cards.Add(new Card("A", "Diamonds",11));
            cards.Add(new Card("2", "Diamonds",2));
            cards.Add(new Card("3", "Diamonds",3));
            cards.Add(new Card("4", "Diamonds",4));
            cards.Add(new Card("5", "Diamonds",5));
            cards.Add(new Card("6", "Diamonds",6));
            cards.Add(new Card("7", "Diamonds",7));
            cards.Add(new Card("8", "Diamonds",8));
            cards.Add(new Card("9", "Diamonds",9));
            cards.Add(new Card("X", "Diamonds",10));
            cards.Add(new Card("J", "Diamonds",10));
            cards.Add(new Card("Q", "Diamonds",10));
            cards.Add(new Card("K", "Diamonds",10));
            cards.Add(new Card("A", "Clovers",11));
            cards.Add(new Card("2", "Clovers",2));
            cards.Add(new Card("3", "Clovers",3));
            cards.Add(new Card("4", "Clovers",4));
            cards.Add(new Card("5", "Clovers",5));
            cards.Add(new Card("6", "Clovers",6));
            cards.Add(new Card("7", "Clovers",7));
            cards.Add(new Card("8", "Clovers",8));
            cards.Add(new Card("9", "Clovers",9));
            cards.Add(new Card("X", "Clovers",10));
            cards.Add(new Card("J", "Clovers",10));
            cards.Add(new Card("Q", "Clovers",10));
            cards.Add(new Card("K", "Clovers",10));

            return cards;
        }

        //public List<Card> Cards = new()
        //{
        //new Card("A", "Hearts",11), 
        //new Card("2", "Hearts",2),
        //new Card("3", "Hearts",3),
        //new Card("4", "Hearts",4),
        //new Card("5", "Hearts",5),
        //new Card("6", "Hearts",6),
        //new Card("7", "Hearts",7),
        //new Card("8", "Hearts",8),
        //new Card("9", "Hearts",9),
        //new Card("X", "Hearts",10),
        //new Card("J", "Hearts",10),
        //new Card("Q", "Hearts",10),
        //new Card("K", "Hearts",10),
        //new Card("A", "Spades",11),
        //new Card("3", "Spades",3),
        //new Card("4", "Spades",4),
        //new Card("5", "Spades",5),
        //new Card("6", "Spades",6),
        //new Card("7", "Spades",7),
        //new Card("8", "Spades",8),
        //new Card("9", "Spades",9),
        //new Card("X", "Spades",10),
        //new Card("J", "Spades",10),
        //new Card("Q", "Spades",10),
        //new Card("K", "Spades",10),
        //new Card("A", "Diamonds",11),
        //new Card("2", "Diamonds",2),
        //new Card("3", "Diamonds",3),
        //new Card("4", "Diamonds",4),
        //new Card("5", "Diamonds",5),
        //new Card("6", "Diamonds",6),
        //new Card("7", "Diamonds",7),
        //new Card("8", "Diamonds",8),
        //new Card("9", "Diamonds",9),
        //new Card("X", "Diamonds",10),
        //new Card("J", "Diamonds",10),
        //new Card("Q", "Diamonds",10),
        //new Card("K", "Diamonds",10),
        //new Card("A", "Clovers",11),
        //new Card("2", "Clovers",2),
        //new Card("3", "Clovers",3),
        //new Card("4", "Clovers",4),
        //new Card("5", "Clovers",5),
        //new Card("6", "Clovers",6),
        //new Card("7", "Clovers",7),
        //new Card("8", "Clovers",8),
        //new Card("9", "Clovers",9),
        //new Card("X", "Clovers",10),
        //new Card("J", "Clovers",10),
        //new Card("Q", "Clovers",10),
        //new Card("K", "Clovers",10),
        //};



        public void ShowCard(Card card)
        {
            //int value = random.Next(1,9);
            //int color = random.Next(1,4);
            Color = card.Color;
            Value = card.Value;
            if (Color == "Hearts")
            {
                Console.WriteLine(" _____");
                Console.WriteLine($"|{Value}_ _ |");
                Console.WriteLine("|( V )|");
                Console.WriteLine("| \\ / |");
                Console.WriteLine("|  .  |");
                Console.WriteLine($"|____{Value}|");
            }

            else if (Color == "Spades")
            {
                Console.WriteLine(" _____");
                Console.WriteLine($"|{Value} .  |");
                Console.WriteLine("| /.\\ |");
                Console.WriteLine("|(_._)|");
                Console.WriteLine("|  |  |");
                Console.WriteLine($"|____{Value}|");
            }

            else if (Color == "Diamonds")
            {
                Console.WriteLine(" _____");
                Console.WriteLine($"|{Value} ^  |");
                Console.WriteLine("| / \\ |");
                Console.WriteLine("| \\ / |");
                Console.WriteLine("|  .  |");
                Console.WriteLine($"|____{Value}|");
            }
            else if (Color == "Clovers")
            {
                Console.WriteLine(" _____");
                Console.WriteLine($"|{Value} _  |");
                Console.WriteLine("| (.) |");
                Console.WriteLine("|(_._)|");
                Console.WriteLine("|  |  |");
                Console.WriteLine($"|____{Value}|");
            }

        }
        public override string ToString()
        {
            return $"{Value} of {Color}";
        }

        public Card PickCard(List<Card> cards)
        {
            //Card card = new Card("A", "Hearts", 11);
            Card card = cards[_ = random.Next(0, 51)];
            return card;
        }

    }


}
//Enum Deck
//public enum DeckOfCards
//{
//    AceofHearts = 11,
//    Twoofhearts = 2,
//    ThreeofHearts = 3,
//    Fourofhearts = 4,
//    FiveofHearts = 5,
//    Sixofhearts = 6,
//    Sevenofhearts = 7,
//    EigthofHearts = 8,
//    NineofHearts = 9,
//    Tenofhearts = 10,
//    JackofHearts = 10,
//    QueenofHearts = 10,
//    KingofHearts = 10,
//    AceofSpades = 11,
//    TwoofSpades = 2,
//    ThreeofSpades = 3,
//    FourofSpades = 4,
//    FiveofSpades = 5,
//    SixofSpades = 6,
//    SevenofSpades = 7,
//    EigthofSpades = 8,
//    NineofSpades = 9,
//    TenofSpades = 10,
//    JackofSpades = 10,
//    QueenofSpades = 10,
//    KingofSpades = 10,
//    AceofDiamonds = 11,
//    TwoofDiamonds = 2,
//    ThreeofDiamonds = 3,
//    FourofDiamonds = 4,
//    FiveofDiamonds = 5,
//    SixofDiamonds = 6,
//    SevenofDiamonds = 7,
//    EigthofDiamonds = 8,
//    NineofDiamonds = 9,
//    TenofDiamonds = 10,
//    JackofDiamonds = 10,
//    QueenofDiamonds = 10,
//    KingofDiamonds = 10,
//    AceofClovers = 11,
//    TwoofClovers = 2,
//    ThreeofClovers = 3,
//    FourofClovers = 4,
//    FiveofClovers = 5,
//    SixofClovers = 6,
//    SevenofClovers = 7,
//    EigthofClovers = 8,
//    NineofClovers = 9,
//    TenofClovers = 10,
//    JackofClovers = 10,
//    QueenofClovers = 10,
//    KingofClovers = 10,

//}

//public List<Card> MakeDeck()
//{
//    List<Card> cards = new();
//    cards.Add(new Card("A", "Hearts"));
//    cards.Add(new Card("2", "Hearts"));
//    cards.Add(new Card("3", "Hearts"));
//    cards.Add(new Card("4", "Hearts"));
//    cards.Add(new Card("5", "Hearts"));
//    cards.Add(new Card("6", "Hearts"));
//    cards.Add(new Card("7", "Hearts"));
//    cards.Add(new Card("8", "Hearts"));
//    cards.Add(new Card("9", "Hearts"));
//    cards.Add(new Card("X", "Hearts"));
//    cards.Add(new Card("J", "Hearts"));
//    cards.Add(new Card("Q", "Hearts"));
//    cards.Add(new Card("K", "Hearts"));
//    cards.Add(new Card("A", "Spades"));
//    cards.Add(new Card("2", "Spades"));
//    cards.Add(new Card("3", "Spades"));
//    cards.Add(new Card("4", "Spades"));
//    cards.Add(new Card("5", "Spades"));
//    cards.Add(new Card("6", "Spades"));
//    cards.Add(new Card("7", "Spades"));
//    cards.Add(new Card("8", "Spades"));
//    cards.Add(new Card("9", "Spades"));
//    cards.Add(new Card("X", "Spades"));
//    cards.Add(new Card("J", "Spades"));
//    cards.Add(new Card("Q", "Spades"));
//    cards.Add(new Card("K", "Spades"));
//    cards.Add(new Card("A", "Diamonds"));
//    cards.Add(new Card("2", "Diamonds"));
//    cards.Add(new Card("3", "Diamonds"));
//    cards.Add(new Card("4", "Diamonds"));
//    cards.Add(new Card("5", "Diamonds"));
//    cards.Add(new Card("6", "Diamonds"));
//    cards.Add(new Card("7", "Diamonds"));
//    cards.Add(new Card("8", "Diamonds"));
//    cards.Add(new Card("9", "Diamonds"));
//    cards.Add(new Card("X", "Diamonds"));
//    cards.Add(new Card("J", "Diamonds"));
//    cards.Add(new Card("Q", "Diamonds"));
//    cards.Add(new Card("K", "Diamonds"));
//    cards.Add(new Card("A", "Clovers"));
//    cards.Add(new Card("2", "Clovers"));
//    cards.Add(new Card("3", "Clovers"));
//    cards.Add(new Card("4", "Clovers"));
//    cards.Add(new Card("5", "Clovers"));
//    cards.Add(new Card("6", "Clovers"));
//    cards.Add(new Card("7", "Clovers"));
//    cards.Add(new Card("8", "Clovers"));
//    cards.Add(new Card("9", "Clovers"));
//    cards.Add(new Card("X", "Clovers"));
//    cards.Add(new Card("J", "Clovers"));
//    cards.Add(new Card("Q", "Clovers"));
//    cards.Add(new Card("K", "Clovers"));

//    return cards;
//}
// Graphics
//  _____
// |# ^  |  
// | / \ | 
// | \ / |
// |  .  |
// |____@| 

//  _____
// |# .  |  
// | /.\ | 
// |(_._)|
// |  |  |
// |____@| 
//  _____
// |# _  |  
// | (.) | 
// |(_._)|
// |  |  |
// |____@| 
//  _____
// |#_ _ |  
// |( V )| 
// | \ / |
// |  .  |
// |____@| 
//  _____
// |.. ..|  
// |() ()| 
// |  0  |
// | \_/ |
// |_____| 
