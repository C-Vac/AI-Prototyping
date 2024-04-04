using MySql.Data.MySqlClient;


namespace TheStreets.Prototype;

/// <summary>
/// Container object for serialized sql queries
/// </summary>
public static class SqlQueries
{
    public const string CreateUser = "INSERT INTO users (Username, Email) VALUES (@Username, @Email)";
    public const string GetUserById = "SELECT * FROM users WHERE Id = @Id";

}

/// <summary>
/// Handles database client operations.
/// </summary>
public class CrudController
{
    public static void UpdateUserEmail(MySqlConnection conn, int userId, string newEmail)
    {
        string sql = "UPDATE users SET Email = @Email WHERE Id = @Id";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Email", newEmail);
        cmd.Parameters.AddWithValue("@Id", userId);

        int affectedRows = cmd.ExecuteNonQuery();
        if (affectedRows > 0)
        {
            Console.WriteLine("User email updated successfully.");
        }
        else
        {
            Console.WriteLine("No user found with the given ID.");
        }
    }

    public static void CreateUser(MySqlConnection conn, User newUser)
    {
        string sql = "INSERT INTO users (Username, Email) VALUES (@Username, @Email)";
        MySqlCommand cmd = new MySqlCommand(sql, conn);

        // Bind the parameters
        cmd.Parameters.AddWithValue("@Username", newUser.Username);
        cmd.Parameters.AddWithValue("@Email", newUser.Email);

        try
        {
            cmd.ExecuteNonQuery();
            Console.WriteLine("User successfully created.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
    public static void DeleteUserById(MySqlConnection conn, int userId)
    {
        string sql = "DELETE FROM users WHERE Id = @Id";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        cmd.Parameters.AddWithValue("@Id", userId);

        int affectedRows = cmd.ExecuteNonQuery();
        if (affectedRows > 0)
        {
            Console.WriteLine("User deleted successfully.");
        }
        else
        {
            Console.WriteLine("No user found with the given ID.");
        }
    }
}
