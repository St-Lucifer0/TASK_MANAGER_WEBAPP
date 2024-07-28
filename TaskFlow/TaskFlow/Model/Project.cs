namespace TaskFlow.Model
{
    public class Project
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Context { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPriority { get; set; }
        public DateTime? DeadLine { get; set; }
    }
}
