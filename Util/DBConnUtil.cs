using System;
using System.Data.SqlClient;

public class DBConnUtil
{
    public static SqlConnection GetConnection(string connectionString)
    {
        try
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
        catch (SqlException ex)
        {
            throw new DatabaseConnectionException($"Failed to connect to the database: {ex.Message}");
        }
        catch (Exception ex)
        {
            throw new DatabaseConnectionException($"An error occurred while connecting to the database: {ex.Message}");
        }
    }
}
