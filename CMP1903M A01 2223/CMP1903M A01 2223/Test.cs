using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Test
    {
        //visual studio watch used to view the deck
        public static void Run() 
        {
            //constructor only initiliases the deck, the object itself however is more or less useless
            Pack pack = new Pack();

            Pack.shuffleCardPack(0); //none
            pack = new Pack(); // reset deck

            Pack.shuffleCardPack(1); // fisher yates
            pack = new Pack(); // reset deck

            Pack.shuffleCardPack(2); //riffle
            pack = new Pack(); // reset deck

            Pack.deal();
            Pack.dealCard(2);
        }


    }
}
