using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Shared.Services.Shared
{
    public interface ISharedService
    {
        Task SaveData();
        Task LoadData();

    }
}
