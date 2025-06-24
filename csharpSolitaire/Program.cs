using csharpSolitaire.objects.CardObject;
using csharpSolitaire.objects.CardSuitObject;
using csharpSolitaire.objects.SeedStackObject;


SeedStack heartStack = new SeedStack(CardSuit.Hearts);
SeedStack diamondStack = new SeedStack(CardSuit.Diamonds);

heartStack.Push(new Card() {
    Suit = CardSuit.Hearts,
    Rank = 1,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = CardSuit.Hearts,
    Rank = 2,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = CardSuit.Hearts,
    Rank = 3,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = CardSuit.Hearts,
    Rank = 4,
    IsFaceUp = true
});

heartStack.Push(new Card() {
    Suit = CardSuit.Hearts,
    Rank = 14,
    IsFaceUp = true
});



heartStack.Print();

