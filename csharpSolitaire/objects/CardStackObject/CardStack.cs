using csharpSolitaire.objects.CardObject;
using csharpSolitaire.objects.Exceptions;

namespace csharpSolitaire.objects.CardStackObject;

internal class CardStack() : ICardStack {
    public Stack<Card> cardsStack = new();

    public void Print() {
        foreach (Card card in cardsStack)
            card.Print();
    }

    public Card Pop() {
        if (cardsStack.Count == 0) throw new EmptyStackException();
        return cardsStack.Pop();
    }

    public void Push(Card card) {
        if (card == null) return;
        else if (cardsStack.Contains(card)) return;
        else cardsStack.Push(card);
    }
}
