using ToDo.Shared.Models;
using ToDo.Shared.Services.TaskService;

namespace ToDo.Client.Shared.TaskService
{
    public class TaskService : ITaskService
    {
        public Task ChangeCategory(Guid taskId, Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task ChangeStatus(Guid taskiId, TaskStatus newTaskStatus)
        {
            throw new NotImplementedException();
        }

        public Task Create(NewTask data)
        {
            throw new NotImplementedException();
        }

        public Task CreateCategory(NewCategory data)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskModel>> GetAllTasks()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category?> GetCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskModel>> GetWithStatus(TaskStatus taskStatus)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid taskId)
        {
            throw new NotImplementedException();
        }
    }
}
