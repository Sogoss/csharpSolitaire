namespace csharpSolitaire.objects.Exceptions;
internal class WrongRankException : Exception {
    public WrongRankException() : base() { }

    public WrongRankException(string? message) : base(message) { }

    public WrongRankException(string? message, Exception? innerException) : base(message, innerException) { }

}
