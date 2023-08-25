using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Shared.Models;

namespace ToDo.Shared.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<Category?> GetCategory(Guid categoryId);
        Task CreateCategory(NewCategory data);
        Task ChangeCategory(Guid taskId, Guid categoryId);
        Task<IEnumerable<Category>> GetCategories();
    }
}
