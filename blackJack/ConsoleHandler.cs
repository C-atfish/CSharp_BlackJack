using System;

namespace blackJack
{
    public class ConsoleHandler
    {

        public void printGame(string cardHand, string dealerHand)
        {
            Console.WriteLine("Welcome\n");
            Console.WriteLine("The dealers first card is: " + dealerHand + "\n");
            Console.WriteLine("You got the cards: " + cardHand + "\n");
            
        }

        public void sum(int sum)
        {
            Console.WriteLine("Your sum is: " + sum + "\n");
        }

        public void dealerSum(int sum)
        {
            Console.WriteLine("The dealers new sum is: " + sum);
        }


        public void printValue(int i)
        {
            Console.WriteLine("Your total sum is: " + i);
        }

        public int getInputDrawOrStay()
        {
            Console.WriteLine("1: Draw a card");
            Console.WriteLine("2: Stay");
            int userInput = Int32.Parse(Console.ReadLine());

            return userInput;


        }

        public void showTextDraw(string cardName, int sum)
        {
            Console.WriteLine("\nYou drew " + cardName);
            Console.WriteLine("Your new sum is " + sum + "\n");
        }

        public void showDealerCard(string dCard)
        {
            Console.WriteLine("\nThe dealer drew: " + dCard);
        }

        public void showWin(string personWin)
        {
            Console.WriteLine("\n" + personWin + " WINS!!!");
        }

        public void showDraw()
        {
            Console.WriteLine("\nIts a draw!");
        }

        public void showBlackjack(string personType)
        {
            Console.WriteLine("\nDAAMN! " + personType + " got blackjack!!!");
        }

        public void showLoose()
        {
            Console.WriteLine("\nIm sorry, you both lost!");
        }

        public int playAgainText()
        {
            Console.WriteLine("Play again? 1: Yes 2: No");
            int playAgain = Int32.Parse(Console.ReadLine());
            return playAgain;
        }
        
    }
}