using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }

        public override string ToString()
        {
            //cast ints to enums as string
            return $"{(Val)Value} of {(Suits)Suit}";
        }
    }

    enum Suits
    {
        Diamonds = 1,
        Clubs = 2,
        Hearts = 3,
        Spades = 4,
    }

    enum Val
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Eleven,
        Jack,
        Queen,
        King,
    }
}
