using System;
using System.Runtime.InteropServices;

namespace blackJack
{
   
    public class Player : Person
    {
        
       
        public Player() : base()
        {

        }
        
        public string draw()
        {
            Random random = new Random();
            base.cardHand.Add(cardStack[random.Next(0, 12)]);
            int lastDrawn = cardHand.Count - 1;
            string lastCard = cardHand[lastDrawn].getName();
            return lastCard;

        }
        
       
        
        
    }
}