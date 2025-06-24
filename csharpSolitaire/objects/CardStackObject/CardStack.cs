using csharpSolitaire.objects.CardObject;

namespace csharpSolitaire.objects.CardStackObject;

internal class CardStack() : ICardStack {
    public Stack<Card> cardsStack = new();

    public void Print() {
        foreach (Card card in cardsStack)
            card.Print();
    }

    public void Pop(Card card) {
        if (card == null) return;
        else if (cardsStack.Contains(card)) return;
        else cardsStack.Pop();
    }

    public void Push(Card card) {
        if (card == null) return;
        else if (cardsStack.Contains(card)) return;
        else cardsStack.Push(card);
    }
}
