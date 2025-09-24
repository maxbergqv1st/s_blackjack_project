// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, github!");

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
      foreach(var deck in deck_list)
      {
            Console.WriteLine(deck);
      }
      Console.ReadLine();
}