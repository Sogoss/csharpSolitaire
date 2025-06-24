using CsharpSolitaire.Objects.CardObject;
using CsharpSolitaire.Objects.SeedStackObject;


SeedStack heartStack = new SeedStack(Suit.Hearts);
SeedStack diamondStack = new SeedStack(Suit.Diamonds);

heartStack.Push(new Card() {
    Suit = Suit.Hearts,
    Rank = 1,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = Suit.Hearts,
    Rank = 2,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = Suit.Hearts,
    Rank = 3,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = Suit.Hearts,
    Rank = 4,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = Suit.Hearts,
    Rank = 5,
    IsFaceUp = true
});



heartStack.Print();

