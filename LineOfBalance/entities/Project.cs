using System.Collections.Generic;

namespace LineOfBalance.entities
{
    class Project
    {
        public List<Task> Tasks { get; }

        public Project()
        {
            Tasks = new List<Task>();
        }

        public void AddTask(Task t)
        {
            Tasks.Add(t);
        }

        public void RemoveTask(Task t)
        {
            Tasks.Remove(t);
        }
    }
}
