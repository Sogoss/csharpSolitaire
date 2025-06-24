using csharpSolitaire.objects.CardObject;
using csharpSolitaire.objects.CardSuitObject;

namespace csharpSolitaire.objects.DeckObject;

internal class Deck : IDeck {
    List<Card> CardSet = [];

    internal Deck() {
        foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit))) {
            foreach (int rank in Enumerable.Range(1, 13)) {
                CardSet.Add(new Card {
                    Suit = suit,
                    Rank = rank,
                    IsFaceUp = false
                });
            }
        }
    }


    public void Print() {
        foreach (var card in CardSet) {
            card.Print();
        }
    }

    public void SeedShuffle(uint seed) {
        if (seed == 0) {
            seed = (uint)DateTime.Now.Ticks;
        }

        List<Card> cardList = CardSet.OrderBy(Card => Card.Suit)
                     .ThenBy(Card => Card.Rank)
                     .ToList();

        List<Card> shuffledDeck = [];

        while (cardList.Count > 0) {
            Card card = cardList[(int)(seed % cardList.Count)];
            cardList.Remove(card);

            shuffledDeck.Add(card);

            seed ^= seed >> 13;
            seed ^= seed >>> 17;
            seed ^= seed << 5;

        }

        CardSet = shuffledDeck;
    }
}
