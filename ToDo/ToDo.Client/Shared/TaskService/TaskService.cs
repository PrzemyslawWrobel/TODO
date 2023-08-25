using Microsoft.JSInterop;
using System.Text.Json;
using ToDo.Shared.Models;
using ToDo.Shared.Services.TaskService;

namespace ToDo.Client.Shared.TaskService
{
    internal sealed class TaskService : ITaskService
    {
        private List<TaskModel> tasks = new List<TaskModel>();
        private readonly IJSRuntime jSRuntime;

        public TaskService(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }


        public Task ChangeStatus(Guid taskiId, TaskStatus newTaskStatus)
        {
            throw new NotImplementedException();
        }

        public Task Create(NewTask data)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TaskModel>> GetAllTasks()
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

        public async Task LoadData()
        {
            var loadedTasks = await jSRuntime.InvokeAsync<string>("localStorage.getItem", "tasks"); // tasks - klucz po którym pobieramy dane

            if (loadedTasks is not null)
            {
                tasks = JsonSerializer.Deserialize<IEnumerable<TaskModel>>(loadedTasks).ToList();
            }
        }
    }
}
