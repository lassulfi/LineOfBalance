using System;
using System.Collections.Generic;

namespace LineOfBalance.entities
{
    class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Duration { get; set; }
        public double TotalSlack { get; set; }
        public DateTime Start { get; set; }
        public DateTime LateStart { get; set; }
        public List<Task> predecessors;

        public Task(int id, string name, double duration, double totalSlack, DateTime start, DateTime lateStart)
        {
            Id = id;
            Name = name;
            Duration = duration;
            TotalSlack = totalSlack;
            Start = start;
            LateStart = lateStart;
            predecessors = new List<Task>();
        }

        public void AddPredecessor(Task t)
        {
            predecessors.Add(t);
        }

        public void removePredecessor(Task t)
        {
            predecessors.Remove(t);
        }
    }
}
