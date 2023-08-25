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
    Task Remove(Guid taskId);
    Task ChangeStatus(Guid taskiId, TaskStatus newTaskStatus);
    Task<IEnumerable<TaskModel>> GetAllTasks();
    Task<IEnumerable<TaskModel>> GetWithStatus(TaskStatus taskStatus);
}
