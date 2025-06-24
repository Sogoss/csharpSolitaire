namespace CsharpSolitaire.Objects.DeckObject;

internal interface IDeck {
    void Print();
    void SeedShuffle(uint seed);
}