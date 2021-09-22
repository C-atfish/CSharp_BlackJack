using System;
using System.Runtime.InteropServices;

namespace blackJack
{
    public class Dealer : Person
    {
        public Dealer() : base()
        {
        }

         public string getFirstCard()
        {
            return cardHand[0].getName();
        }
        
        

        public string draw()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            string cardsPicked = "";
            while (base.getsum() < 17)
            {
                
                base.cardHand.Add(cardStack[random.Next(0, 12)]);
            }

            return cardsPicked;
        }
    }
}