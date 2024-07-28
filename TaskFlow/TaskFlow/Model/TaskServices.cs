namespace TaskFlow.Model
{
    public class TaskServices
    {
        private List<Task> _tasks = new List<Task>();
        private List<Project> _projects = new List<Project>();
        public IEnumerable<Task> GetAllTasks() 
        {
            return _tasks;
        } 
        public IEnumerable<Project>  GetAllProjects()
        {
            return _projects;
        }

        public void AddTask(Task task) 
        {
            task.Id = (_tasks.Count + 1) .ToString();
            _tasks.Add(task);
        }  

        public void UpdateTask(Task task) 
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Id == task.Id);
            if (existingTask != null)
            {
                existingTask.Name = task.Name;
                existingTask.Description = task.Description;
                existingTask.DeadLine = task.DeadLine;
                existingTask.IsCompleted = task.IsCompleted;
                existingTask.IsPriority = task.IsPriority;
                existingTask.Context = task.Context;
            }
        }

        public void DeleteTask(string taskId)
        {
            var taskDelete = _tasks.FirstOrDefault(t => t.Id == taskId);
            if(taskDelete != null)
            {
                _tasks.Remove(taskDelete);
            }
        }
        
        
        //methods for adding, updaing and deleting a project
        public void AddProject(Project project)
        {
            project.Id = (_projects.Count + 1) .ToString();
            _projects.Add(project);
        }

        public void UpdateProject(Project project)
        {
            var existingProject = _projects.FirstOrDefault(p => p.Id == project.Id);
            if (existingProject != null)
            {
                existingProject.Name = project.Name;
                existingProject.Description = project.Description;
                existingProject.DeadLine = project.DeadLine;
                existingProject.IsCompleted = project.IsCompleted;
                existingProject.IsPriority = project.IsPriority;
                existingProject.Context = project.Context;
            }
        }

        public void DeleteProject(string projectId)
        {
            var projectDelete = _projects.FirstOrDefault(p => p.Id == projectId);
            if(projectDelete != null)
            {
                _projects.Remove(projectDelete);
            }
        }


    }
}
