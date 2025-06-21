using csharpSolitaire.objects.CardObject;
using csharpSolitaire.objects.CardSuitObject;

namespace csharpSolitaire.objects.DeckObject;

internal class Deck : IDeck
{
    HashSet<Card> CardSet = [];


    internal Deck()
    {
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
        {
            foreach (int rank in Enumerable.Range(1, 13))
            {
                CardSet.Add(new Card
                {
                    Suit = suit,
                    Rank = rank,
                    IsFaceUp = false
                });
            }
        }
    }

    public void Print()
    {
        foreach (var card in CardSet)
        {
            card.Print();
        }
    }
}
