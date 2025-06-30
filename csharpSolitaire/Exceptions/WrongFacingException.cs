namespace CsharpSolitaire.Exceptions;

internal class WrongFacingException : Exception {
    internal WrongFacingException() : base() { }

    internal WrongFacingException(string? message) : base(message) { }

    internal WrongFacingException(string? message, Exception? innerException) : base(message, innerException) { }

}
