namespace csharpSolitaire.objects.Exceptions;
internal class WrongFacingException : Exception {
    public WrongFacingException() : base() { }

    public WrongFacingException(string? message) : base(message) { }

    public WrongFacingException(string? message, Exception? innerException) : base(message, innerException) { }

}
