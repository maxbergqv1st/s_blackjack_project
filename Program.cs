using App;

bool running = true;

while(running)
{
      Console.Clear();
      Console.WriteLine("===== BLACKJACK GAME  =====");
      Console.WriteLine("\n1. Play blackjack");
      Console.WriteLine("\n2. Rules of blackjack");
      Console.WriteLine("\n3. Show deck of cards");
      Console.WriteLine("\n4. Exit");

      string? input = Console.ReadLine();

      if(int.TryParse(input, out int option) && Enum.IsDefined(typeof(MenuOption), option))
      {
            MenuOption menuChoice = (MenuOption)option;
            switch(menuChoice)
            {
            case MenuOption.StartGame : 
                  Game game = new Game();
                  game.Start();
            break;
            case MenuOption.ShowRules : 
                  Console.Clear();
                  Console.WriteLine("Rules..");
                  
                  Console.ReadLine();
            break;  
            case MenuOption.ShowDeck : 
                  DeckOfCards deck = new DeckOfCards();
                  deck.AllCardsInDeck();
                  Console.ReadLine();
            break;  
            case MenuOption.Exit : 
                  Console.Clear();
                  Console.WriteLine("Exiting....");
                  running = false;
                  Console.ReadLine();
                  Console.Clear();
            break;        
            }
      }
      else
      {
            Console.Clear();
            Console.WriteLine("invalid option... PRESS enter to continue");
            Console.ReadLine();
      }
}

