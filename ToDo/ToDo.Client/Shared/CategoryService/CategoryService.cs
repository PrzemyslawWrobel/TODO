using Microsoft.JSInterop;
using System.Text.Json;
using ToDo.Shared.Models;
using ToDo.Shared.Services.CategoryService;

namespace ToDo.Client.Shared.CategoryService
{
    internal sealed class CategoryService : ICategoryService
    {
        private List<Category> categories = new List<Category>();
        private readonly IJSRuntime jSRuntime;

        public CategoryService(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }


        public Task ChangeCategory(Guid taskId, Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task CreateCategory(NewCategory data)
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

        public async Task LoadData()
        {
            var loadedCategories = await jSRuntime.InvokeAsync<string>("localStorage.getItem", "categories"); // categories - klucz po którym pobieramy dane

            if (loadedCategories is not null)
            {
                categories = JsonSerializer.Deserialize<IEnumerable<Category>>(loadedCategories).ToList();
            }
        }
    }
}
