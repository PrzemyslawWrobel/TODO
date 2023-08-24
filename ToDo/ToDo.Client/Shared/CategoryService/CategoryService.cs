using ToDo.Shared.Models;
using ToDo.Shared.Services.CategoryService;

namespace ToDo.Client.Shared.CategoryService
{
    internal sealed class CategoryService : ICategoryService
    {
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
    }
}
