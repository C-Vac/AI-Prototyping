namespace TheStreets.Prototype;

/// <summary>
/// Holds the user's application data.
/// </summary>
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PersonId { get; set; }
    public string Email { get; set; }

    public User(string username, string password = "")
    {
        Username = username;

        // something password something something auth token
    }
}
