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
                  DeckOfCards all_cards_in_deck = new DeckOfCards();
                  all_cards_in_deck.AllCardsInDeck();

                  Console.Clear();
                  Console.WriteLine("mode : play");
                        Console.WriteLine("Dealer");
                  all_cards_in_deck.TwoRandomCardFromDeck();
                  Console.WriteLine("Player");

                  all_cards_in_deck.TwoRandomCardFromDeck();
                  

                  Console.ReadLine();
                  
                  
            break;
            case MenuOption.ShowRules : 
                  Console.Clear();
                  Console.WriteLine("Rules..");
                  Console.ReadLine();
            break;  

            case MenuOption.ShowDeck : 
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

