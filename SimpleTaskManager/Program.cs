using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace TheStreets.Prototype;
/// <summary>
/// This is a practice project for the Streets task manager prototype.
/// </summary>
/// <remarks>
/// First, I will use my current knowledge of C# to build this project.
/// 
/// If I am not able to implement a feature, I will add a comment 
/// outlining the desired functionality.
/// 
/// Then, I will augment the code with generative AI and implement new
/// paradigms, patterns, and data structures.
/// </remarks>
class Program {

    const string LOG_PATH = @"";

    public static void Main(string[] args)
    {
        var state = new StateMachine();

        Console.WriteLine("Program started.");
        Console.WriteLine("");
    }
}

public class StateMachine
{
    enum State
    {
        APP_START,
        APP_QUIT,
        VIEW_PRIMARY,
        VIEW_PROJECT_DETAILS,
        VIEW_TASK_DETAILS,
        VIEW_SETTINGS,
    }
    public enum UxAction
    {
        NEW_PROJECT, NEW_TASK,
        EDIT_PROJECT, EDIT_TASK,
        DELETE_PROJECT, DELETE_TASK,

        ARCHIVE_PROJECT, ARCHIVE_TASK,
    }
    private string _state;
    public StateMachine()
    {
        _state = "APP_START";
    }
    public bool TryDoAction(string action)
    {
        // TODO: Implement
        return false;
    }
    private bool TryChangeState(State newState)
    {
        // TODO: Implement
        return false;
    }
}

public static class ProjectTracker
{
    enum Priority { Low, Medium, High }
    public static List<Project> Projects;
    public static List<GoblinTask> Agenda;
    static void UpdateProject()
    {

    }
    static void UpdateAgenda(string[]? args = null)
    { 

    }
}

public class Project
{
    public readonly int ProjectId;
    public string Name { get; set; }
    private List<GoblinTask> _tasks;
    Project(int id, string name)
    {
        ProjectId = id;
        Name = name;
        _tasks = new List<GoblinTask>();
    }
    public void AddTask(GoblinTask task)
    {
        _tasks.Add(task);
    }
}
public class GoblinTask
{
    public readonly int TaskId;
    public string Name;
    public readonly DateTime AddedTimestamp;

    public GoblinTask(int id, string name, string priority = "Medium")
    {
        TaskId = id;
        Name = name;
        AddedTimestamp = DateTime.Now;

    }
}
