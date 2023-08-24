using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Shared.Models;

namespace ToDo.Shared.Services.TaskService;

public interface ITaskService
{
    Task Create(NewTask data);
    Task CreateCategory(NewCategory data);
    Task Remove(Guid taskId);
    Task ChangeStatus(Guid taskiId, TaskStatus newTaskStatus);
    Task ChangeCategory(Guid taskId, Guid categoryId);
    Task<IEnumerable<TaskModel>> GetAllTasks();
    Task<IEnumerable<TaskModel>> GetWithStatus(TaskStatus taskStatus);
    Task<IEnumerable<Category>> GetCategories();
    Task<Category?> GetCategory(Guid categoryId);
}
