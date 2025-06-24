using CsharpSolitaire.Objects.CardObject;

namespace CsharpSolitaire.Objects.DeckObject;

public class Deck : IDeck {
    internal List<Card> CardList = [];

    public Deck() {
        foreach (Suit suit in Enum.GetValues(typeof(Suit))) {
            foreach (int rank in Enumerable.Range(1, 13)) {
                CardList.Add(new Card {
                    Suit = suit,
                    Rank = (Rank)rank,
                    IsFaceUp = false
                });
            }
        }
    }

    public void Print() {
        foreach (var card in CardList) {
            card.Print();
        }
    }

    public void SeedShuffle(uint seed) {
        if (seed == 0) {
            seed = (uint)DateTime.Now.Ticks;
        }

        List<Card> cardList = CardList.OrderBy(Card => Card.Suit)
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

        CardList = shuffledDeck;
    }
}
