using System;

namespace blackJack
{
    public class GameHandler
    {
        private ConsoleHandler consoleHandler;
        private Player player;
        private Dealer dealer;
        private bool continueGame = true;
        
        public void startGame()
        {
            
                
                consoleHandler = new ConsoleHandler();
                player = new Player();
                dealer = new Dealer();
                consoleHandler.printGame(player.getCardHand(), dealer.getFirstCard());
                consoleHandler.sum(player.Sum);

            
                // while the sum is under 21, and the user dont choose stay
            
                while (player.getsum() < 21 && continueGame == true)
                {
                    nextTurn();
                
                }
            
                // Dealer draws until 17, then shows his card and the sum
                dealer.draw();
                consoleHandler.showDealerCard(dealer.getCardHand());
                consoleHandler.dealerSum(dealer.getsum());
            
                // check if anyone won
                checkWin();
        }

        public void nextTurn()
        {
            
            int userInput = consoleHandler.getInputDrawOrStay();
            

            
            // If you choose draw a card

            if (userInput == 1)
            {
                string newcard;
               newcard = player.draw();
               
                consoleHandler.showTextDraw(newcard, player.getsum());
                
            }else if (userInput == 2)
            {
                // if user choose to stay
                continueGame = false;
            }
        }

        public void checkWin()
        {

            int playerSum = player.getsum();
            int dealerSum = dealer.getsum();
            
            // player wins
            if (playerSum < 21 && playerSum > dealerSum || dealerSum > 21 && playerSum < 21)
            {
                consoleHandler.showWin("Player");
                playAgain();
                
                
            }else if (dealerSum < 21 && dealerSum > playerSum || playerSum > 21 && dealerSum < 21)
            {
                // Dealer wins
                consoleHandler.showWin("Dealer");
                playAgain();
                
                
            }else if (dealerSum == playerSum && playerSum < 21)
            {
                // Draw
                consoleHandler.showDraw();
                playAgain();
            }else if (playerSum == 21 || dealerSum == 21)
            {
                // BlackJack
                if (playerSum == 21)
                {
                    consoleHandler.showBlackjack("Player");
                    playAgain();
                }
                if (dealerSum == 21)
                {
                    consoleHandler.showBlackjack("Dealer ");
                    playAgain();
                }
                {
                }
            }
            else
            {
                // Both loose
                consoleHandler.showLoose();
                playAgain();
                
            }
            
        }

        public void playAgain()
        {
            if (consoleHandler.playAgainText() == 1)
            {
                Console.WriteLine("YEAH BRUH");
                continueGame = true;
                startGame();
                

            }
            else
            {
                continueGame = false;
                return;
            }
        }
    }
}