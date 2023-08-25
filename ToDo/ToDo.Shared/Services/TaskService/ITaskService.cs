using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Shared.Enums;
using ToDo.Shared.Models;

namespace ToDo.Shared.Services.TaskService;

public interface ITaskService
{
    Task Create(NewTask data);
    Task Remove(Guid taskId);
    Task ChangeStatus(Guid taskiId, Status newStatus);
    Task<IEnumerable<TaskModel>> GetAllTasks(Guid? withCategory);
    Task<IEnumerable<TaskModel>> GetWithStatus(Status status);
}
