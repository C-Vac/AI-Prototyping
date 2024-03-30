using System;

namespace TheStreets.Prototype
{
    public class GProject
    {
        public readonly int ProjectId;
        public string Name { get; set; }
        private List<GTask> _tasks;
        GProject(int id, string name)
        {
            ProjectId = id;
            Name = name;
            _tasks = new List<GTask>();
        }
        public void AddTask(GTask task)
        {
            _tasks.Add(task);
        }
    }
}
