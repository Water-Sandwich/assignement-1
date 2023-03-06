using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    //class is entirely static, creating objects is pointless
    class Pack
    {
        public static List<Card> deck { get; } = new List<Card>();

        //calling this resets the deck
        public Pack()
        {
            //Initialise the card pack here
            //Value: numbers 1 - 13
            //Suit: numbers 1 - 4
            deck.Clear();

            for (int s = 1; s < 5; s++)
            {
                for (int v = 1; v < 14; v++)
                {
                    deck.Add(new Card() { Value = v, Suit = s });
                }
            }
        }

        //1: fisher yates, 2: riffle, 3: none
        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            switch (typeOfShuffle)
            {
                case 1:
                    FisherYates();
                    return true;

                case 2:
                    RiffleShuffle();
                    return true;

                case 3: return true;

                default: return false;
            }
        }

        //assuming dealing a card removes it from the deck
        public static Card deal()
        {
            //Deals one card
            Card card = deck.First();
            deck.RemoveAt(0);
            return card;
        }

        //assuming dealing a card removes it from the deck
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();
            for(int i = 0; i < amount; i++)
            {
                cards.Add(deal());
            }
            return cards;
        }

        static void FisherYates() 
        {
            //copy the deck
            //take a random number from n to deck size
            //take nth card from copy and replace 1st on real, pop the copy
            //repet until empty

            List<Card> copy = deck.ToList();
            Random r = new Random(); //0-100 = 0 - 101

            for(int i = 0; i < deck.Count; i++)
            {
                int num = r.Next(0, copy.Count);
                deck[i] = copy[num];
                copy.RemoveAt(num);
            }
        }

        static void RiffleShuffle(int iterations = 104 /* 2x deck */) 
        {
            //swap 2 random cards for n interations

            Random r = new Random();
            Card temp;

            for(int i = 0; i < iterations; i++)
            {
                int a = r.Next(0, deck.Count);
                int b = a;
                //prevent duplicates, a and b MUST be different
                while(a == b)
                {
                    b = r.Next(0, deck.Count);
                }

                temp = deck[a];
                deck[a] = deck[b];
                deck[b] = temp;
            }
        }
    }
}