using csharpSolitaire.objects.CardObject;

namespace csharpSolitaire.objects.SeedStackObject;
internal interface ISeedStack {
    Card Pop();
    void Push(Card card);
    void Print();
}