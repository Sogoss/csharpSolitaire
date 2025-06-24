using csharpSolitaire.objects.CardObject;

namespace csharpSolitaire.objects.CardStackObject;
internal interface ICardStack {
    void Pop(Card card);
    void Push(Card card);
    void Print();
}