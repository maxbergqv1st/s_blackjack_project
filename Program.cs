using App;

List<string> suit_cards = new List<string>{"♠","♥","♦","♣",};

List<string> rank_cards = new List<string>{"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};

List<string> deck_list = new List<string>();

foreach(var suit in suit_cards)
{
      foreach(var rank in rank_cards)
      {
            deck_list.Add(suit + rank);
      }
}



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
                  Console.Clear();
                  Console.WriteLine("Play..");
                  
                  Console.ReadLine();
            break;
            case MenuOption.ShowRules : 
                  Console.Clear();
                  Console.WriteLine("Rules..");
                  
                  Console.ReadLine();
            break;  
            case MenuOption.ShowDeck : 
                  foreach(var deck in deck_list)
                  {
                        Console.WriteLine(deck);
                  }
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

