using csharpSolitaire.objects.CardSuitObject;

namespace csharpSolitaire.objects.CardObject;

internal class Card : ICard {
    public CardSuit Suit { get; set; }
    public int Rank { get; set; }
    public bool IsFaceUp { get; set; }


    public void Print() {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        if (!IsFaceUp)
            Console.ForegroundColor = ConsoleColor.Gray;
        else
            Console.ForegroundColor = Suit switch {
                CardSuit.Hearts => ConsoleColor.Red,
                CardSuit.Diamonds => ConsoleColor.DarkYellow,
                CardSuit.Clubs => ConsoleColor.DarkMagenta,
                CardSuit.Spades => ConsoleColor.Blue,
                _ => Console.ForegroundColor,
            };

        Console.WriteLine($"{GetsuitSymbol()} {Rank}");
        Console.ResetColor();



        Console.OutputEncoding = System.Text.Encoding.Default;

    }

    public string GetsuitSymbol() {
        return Suit switch {
            CardSuit.Hearts => "♥",
            CardSuit.Diamonds => "♦",
            CardSuit.Clubs => "♣",
            CardSuit.Spades => "♠",
            _ => "?"
        };
    }
}
