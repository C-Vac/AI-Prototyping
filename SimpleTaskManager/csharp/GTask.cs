namespace TheStreets.Prototype;

public class GTask
{
    public readonly int TaskId;
    public string Name;
    public readonly DateTime AddedTimestamp;

    public GTask(int id, string name, string priority = "Medium")
    {
        TaskId = id;
        Name = name;
        AddedTimestamp = DateTime.Now;

    }
}
