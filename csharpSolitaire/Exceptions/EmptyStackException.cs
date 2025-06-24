namespace CsharpSolitaire.Exceptions;

internal class EmptyStackException : Exception {
    internal EmptyStackException() : base() { }

    internal EmptyStackException(string? message) : base(message) { }

    internal EmptyStackException(string? message, Exception? innerException) : base(message, innerException) { }

}
