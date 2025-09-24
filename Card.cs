namespace App;

public class DeckOfCards
{
public List<string> suit_cards = new List<string>{"♠","♥","♦","♣",};
public List<string> rank_cards = new List<string>{"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
public List<string> deck_list = new List<string>();

public Random rnd = new Random();

      public void AllCardsInDeck()
      {
            foreach(var suit in suit_cards)
            {
                  foreach(var rank in rank_cards)
                  {
                        deck_list.Add(suit + rank);                        
                  }
            }
            foreach(var card in deck_list)
                        {
                              Console.WriteLine(card);
                        }
      }

      public void OneRandomCardFromDeck()
      {
            foreach(var suit in suit_cards)
            {
                  foreach(var rank in rank_cards)
                  {
                        deck_list.Add(suit + rank);                        
                  }
            }
            if(deck_list.Count == 0)
            {
                  Console.WriteLine("hello");
            }
            else
            {
                  int RandomIndex = rnd.Next(deck_list.Count);
                  string RandomCard = deck_list[RandomIndex];
                  Console.WriteLine(RandomCard);
            }
            
      }
};
