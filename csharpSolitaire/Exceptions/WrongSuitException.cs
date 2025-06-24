namespace CsharpSolitaire.Exceptions;

internal class WrongSuitException : Exception {
    internal WrongSuitException() : base() { }

    internal WrongSuitException(string? message) : base(message) { }

    internal WrongSuitException(string? message, Exception? innerException) : base(message, innerException) { }

}
