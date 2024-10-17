using System;

public class DatabaseConnectionException : Exception
{
    public DatabaseConnectionException(string message) : base(message) { }
}
