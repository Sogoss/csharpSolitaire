using CsharpSolitaire.Objects.CardObject;

namespace CsharpSolitaire.Objects.CardStackObject;
internal interface ICardStack {
    Card Pop();
    void Push(Card card);
    void Print();
}