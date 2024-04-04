using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace TheStreets.Prototype;
/// <summary>
/// This is a practice project for the Streets task manager prototype.
/// </summary>
/// <remarks>
/// yuh
/// </remarks>
class Program
{

    const string LOG_PATH = @"";


    public static void Main(string[] args)
    {
        var state = new StateMachine();

        Console.WriteLine("Program started.");
        Console.WriteLine("Initializing database client...");
        InitDbClient();
    }

    public static void InitDbClient()
    {
        Console.Write("Enter password: ");
        string? dbPass = Console.ReadLine();
        string connectionString = $"server=localhost;user=goblindev;database=ai_assistant_app;port=3306;password={dbPass}";
        MySqlConnection conn = new MySqlConnection(connectionString);

        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();


            // TEST: Let's create a new user for demonstration purposes
            User newUser = new User { Username = "newgoblin", Email = "newgoblin@goblinmail.com" };
            CreateUser(conn, newUser);
            // Perform database operations

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            conn.Close();
            Console.WriteLine("Done.");
        }
    }




}

