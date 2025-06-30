namespace CsharpSolitaire.Objects.CardObject;

public class Card : ICard {
    internal Suit Suit { get; set; }
    internal Rank Rank { get; set; }
    internal bool IsFaceUp { get; set; }

    public void Print() {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        if (!IsFaceUp)
            Console.ForegroundColor = ConsoleColor.Gray;
        else
            Console.ForegroundColor = Suit switch {
                Suit.Hearts => ConsoleColor.Red,
                Suit.Diamonds => ConsoleColor.DarkYellow,
                Suit.Clubs => ConsoleColor.DarkMagenta,
                Suit.Spades => ConsoleColor.Blue,
                _ => Console.ForegroundColor,
            };

        Console.WriteLine($"{GetsuitSymbol()} {((int)this.Rank)}");
        Console.ResetColor();



        Console.OutputEncoding = System.Text.Encoding.Default;

    }

    public string GetsuitSymbol() {
        return this.Suit switch {
            Suit.Hearts => "♥",
            Suit.Diamonds => "♦",
            Suit.Clubs => "♣",
            Suit.Spades => "♠",
            _ => "?"
        };
    }
}
