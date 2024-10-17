using System;

public class InvalidEmailFormatException : Exception
{
    public InvalidEmailFormatException(string message) : base(message) { }
}
