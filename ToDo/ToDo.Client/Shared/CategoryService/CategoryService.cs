using Microsoft.JSInterop;
using System.Text.Json;
using ToDo.Shared.Models;
using ToDo.Shared.Services.CategoryService;
using ToDo.Shared.Services.Shared;

namespace ToDo.Client.Shared.CategoryService
{
    internal sealed class CategoryService : ICategoryService, ISharedService
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

        public async Task CreateCategory(NewCategory data)
        {
            await LoadData();
            var category = new Category(Guid.NewGuid(), data.Name, data.Color);
            categories.Add(category);
            await SaveData();

        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            await LoadData();
            return categories;
        }

        public async Task<Category?> GetCategory(Guid categoryId)
        {
            return categories.FirstOrDefault(x => x.Id == categoryId);
            
        }

        public async Task LoadData()
        {
            var loadedCategories = await jSRuntime.InvokeAsync<string>("localStorage.getItem", "categories"); // categories - klucz po którym pobieramy dane

            if (loadedCategories is not null)
            {
                categories = JsonSerializer.Deserialize<IEnumerable<Category>>(loadedCategories).ToList();
            }
        }

        public async Task SaveData()
        {
            await jSRuntime.InvokeVoidAsync("localStorage.setItem", "categories", JsonSerializer.Serialize(categories));
        }
    }
}
