namespace CsharpSolitaire.Exceptions;

internal class WrongRankException : Exception {
    internal WrongRankException() : base() { }

    internal WrongRankException(string? message) : base(message) { }

    internal WrongRankException(string? message, Exception? innerException) : base(message, innerException) { }

}
