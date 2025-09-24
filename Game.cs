namespace App;

public class Game
{
public List<string> deck_list = new List<string>();

      public void Start()
      {
            Console.Clear();
            Console.WriteLine("Play..");
            
                  DeckOfCards deck = new DeckOfCards();
                  deck.OneRandomCardFromDeck();
            Console.ReadLine();
      }
}