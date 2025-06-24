namespace CsharpSolitaire.Exceptions;
internal class EmptyStackException : Exception {
    public EmptyStackException() : base() { }

    public EmptyStackException(string? message) : base(message) { }

    public EmptyStackException(string? message, Exception? innerException) : base(message, innerException) { }

}
