namespace csharpSolitaire.objects.DeckObject;


/// <summary>
/// List of cards
/// </summary>
internal interface IDeck {
    void Print();
    void SeedShuffle(uint seed);
}