using Microsoft.JSInterop;
using System.Text.Json;
using ToDo.Shared.Enums;
using ToDo.Shared.Models;
using ToDo.Shared.Services.CategoryService;
using ToDo.Shared.Services.Shared;
using ToDo.Shared.Services.TaskService;

namespace ToDo.Client.Shared.TaskService
{
    internal sealed class TaskService : ITaskService, ISharedService
    {
        private List<TaskModel> tasks = new List<TaskModel>();
        private readonly ICategoryService _categoryService;
        private readonly IJSRuntime jSRuntime;

        public TaskService(IJSRuntime jSRuntime, ICategoryService categoryService )
        {
            this.jSRuntime = jSRuntime;
            this._categoryService = categoryService;
        }


        public async Task ChangeStatus(Guid taskiId, Status newStatus)
        {
            await LoadData();
            var task = tasks.FirstOrDefault(x => x.Id == taskiId);
            if (task is null)
                return;
            var index = tasks.IndexOf(task);
            task = task with { Status = newStatus};
            tasks[index] = task;
            await SaveData();
        }

        public async Task Create(NewTask data)
        {
            await LoadData();

            var category = await _categoryService.GetCategory(data.CategoryId);
                
            var task = new TaskModel(Guid.NewGuid(), data.Title, Status.ToDo, category, data.Description );
            tasks.Add(task);
            await SaveData();   
        }

        public async Task<IEnumerable<TaskModel>> GetAllTasks(Guid? withCategory)
        {
            await LoadData();

           return withCategory is null ? tasks : tasks.Where(x => x.Category is not null && x.Category.Id == withCategory);
        }

        public Task<IEnumerable<TaskModel>> GetWithStatus(Status status)
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

        public async Task SaveData()
        {
            await jSRuntime.InvokeVoidAsync("localStorage.setItem", "tasks", JsonSerializer.Serialize(tasks)); // InvokeVoidAsync - bo nie zwracamy żadnych wyników, InvokeAsync<list<TaskModel>> zwraca wynik
        }


    }
}
