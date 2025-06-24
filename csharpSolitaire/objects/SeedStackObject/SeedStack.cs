using CsharpSolitaire.Objects.CardObject;
using CsharpSolitaire.Exceptions;

namespace CsharpSolitaire.Objects.SeedStackObject;
public class SeedStack(Suit suit) : ISeedStack {
    internal Stack<Card> stack = new();
    internal Suit suit = suit;

    public Card Pop() {
        if (stack.Count == 0) throw new EmptyStackException();
        else return stack.Pop();
    }

    public void Push(Card card) {
        if (card.Suit != this.suit) throw new WrongSuitException();
        if (card.IsFaceUp == false) throw new WrongFacingException();


        Card? lastCard = stack.FirstOrDefault();

        if (lastCard == null &&
            card.Rank == Rank.Ace)
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
