using System;

public class DBPropertyUtil
{
    public static string GetConnectionString(string propertyFileName)
    {
        return "Data Source=.\\sqlexpress;Initial Catalog=CareerHub;Integrated Security=True;TrustServerCertificate=True";
    }
}
