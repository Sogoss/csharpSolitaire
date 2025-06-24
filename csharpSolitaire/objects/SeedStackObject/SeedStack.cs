using csharpSolitaire.objects.CardObject;
using csharpSolitaire.objects.CardSuitObject;
using csharpSolitaire.objects.Exceptions;

namespace csharpSolitaire.objects.SeedStackObject;
internal class SeedStack(CardSuit suit) : ISeedStack {
    internal Stack<Card> stack = new();
    internal CardSuit suit = suit;

    public Card Pop() {
        if (stack.Count == 0) throw new EmptyStackException();
        else return stack.Pop();
    }

    public void Push(Card card) {
        if (card.Suit != this.suit) throw new WrongSuitException();
        if (card.IsFaceUp == false) throw new WrongFacingException();


        Card? lastCard = stack.FirstOrDefault();

        if (lastCard == null &&
            card.Rank == 1)
            stack.Push(card);
        else if (lastCard != null &&
            card.Rank - lastCard.Rank == 1)
            stack.Push(card);
        else
            throw new WrongRankException();
    }

    public void Print() {
        foreach (Card card in stack)
            card.Print();
    }

}
