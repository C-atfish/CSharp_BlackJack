using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace blackJack
{
    public class Person
    {
        
        public Card[] cardStack = new Card[13];
        public List<Card> cardHand;

        private string[] nameArray = new string[] {"Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King"};

        

        public int Sum { get; private set; } = 0;

        public int getSpecificValue(int i)
        {


            return cardHand[i].getValue();
        }


        public Person()
        {
           
            
              cardHand  = new List<Card>();
              makeCardStack();

              get2Cards();
              

        }


        public void makeCardStack()
        {
            Random randNumb = new Random();
            int cardvalueTemp = 1;
            for (int i = 0; i < cardStack.Length; i++)
            {
                cardStack[i] = new Card(nameArray[i], cardvalueTemp);

                if (cardvalueTemp < 10)
                {
                    cardvalueTemp++;
                }
            }
            
        }
        
        

        public string getCardHand()
        {
            string cardValueTest = "";

            foreach (Card caard in cardHand)
            {
                cardValueTest += caard.getName() + " ";
            }

            return cardValueTest;
        }


        public void get2Cards()
        {
            
            Random random = new Random(Guid.NewGuid().GetHashCode());
            this.cardHand.Add(cardStack[random.Next(0, 12)]);
            this.cardHand.Add(cardStack[random.Next(0, 12)]);
            getsum();


        }

        public int getsum()
        {
            Sum = 0;
            
                // Loops through cardHand and checks if there is any aces

                for (int i = 0; i < cardHand.Count; i++)
                {
                    if (Sum < 11 && cardHand[i].getName().Equals("Ace"))
                    {
                        Sum += 11;
                    }else if (cardHand[i].getName().Equals("Ace"))
                    {
                        Sum += 1;
                    }
                    else
                    {
                        Sum += cardHand[i].getValue();
                    }
                    
                    
                }






                    return Sum;
        }
        
        
    }
}