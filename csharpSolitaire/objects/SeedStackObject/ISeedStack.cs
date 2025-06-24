using CsharpSolitaire.Objects.CardObject;

namespace CsharpSolitaire.Objects.SeedStackObject;
internal interface ISeedStack {
    Card Pop();
    void Push(Card card);
    void Print();
}