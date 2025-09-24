using System.Runtime.CompilerServices;

namespace App;

public class DeckOfCards
{
public List<string> suit_cards = new List<string>{"♠","♥","♦","♣",};
public List<string> rank_cards = new List<string>{"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};
public List<string> deck_list = new List<string>();

public Random rnd = new Random();

public bool second_round = false;

      public void AllCardsInDeck()
      {
            deck_list.Clear();
            foreach(var suit in suit_cards)
            {
                  foreach(var rank in rank_cards)
                  {
                        deck_list.Add(suit + rank);                        
                  }
            }
      }
      public string OneRandomCardFromDeck()
      {
            if (deck_list.Count == 0)
            {
                  Console.WriteLine("deck of cards is empty");
            }
            int RandomIndex = rnd.Next(deck_list.Count);
            string RandomCard = deck_list[RandomIndex];
            deck_list.RemoveAt(RandomIndex);
            return RandomCard;
      }
      public void TwoRandomCardFromDeck()

      {
             string card1 = OneRandomCardFromDeck();
            string card2 = OneRandomCardFromDeck();
            //             ╭────────────────────────╮
            // │                        │
            // │     Hej, världen!       │
            // │                        │
            // ╰────────────────────────╯
            Console.WriteLine("╭────────────────────────╮─────────╮");
            Console.WriteLine($"│                      {card1}│       {card2}│");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine("│                        │         │");
            Console.WriteLine($"│{card1}                      │         │");
            Console.WriteLine("╰────────────────────────╯─────────╯");

           
      }
      public void SecondRandomCardFromDeck()
      {
            if (!second_round)
            {
                  Console.ReadLine();

                  second_round = true;

                  int RandomIndex = rnd.Next(deck_list.Count);
                  string RandomCard = deck_list[RandomIndex];
                  deck_list.RemoveAt(RandomIndex);
                  Console.WriteLine(RandomCard);
            }
      }
};













