namespace CsharpSolitaire.Exceptions;

internal class WrongSuitException : Exception {
    public WrongSuitException() : base() { }

    public WrongSuitException(string? message) : base(message) { }

    public WrongSuitException(string? message, Exception? innerException) : base(message, innerException) { }

}
