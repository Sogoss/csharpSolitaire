using CsharpSolitaire.Objects.CardObject;
using CsharpSolitaire.Objects.DeckObject;
using CsharpSolitaire.Objects.SeedStackObject;


SeedStack heartStack = new SeedStack(Suit.Hearts);
Deck deck = new Deck();

foreach (int rank in Enumerable.Range(1, 13)) {
    heartStack.Push(new Card() {
        Rank = (Rank)rank,
        Suit = Suit.Hearts,
        IsFaceUp = true
    });
}

foreach (Card card in deck.CardList) {
    card.IsFaceUp = true; // Set all cards to face up for printing
}


Console.WriteLine("Heart Stack:");
heartStack.Print();
deck.SeedShuffle(74852);

Console.WriteLine("--------------");
Console.WriteLine("Shuffled deck:");
deck.Print();

