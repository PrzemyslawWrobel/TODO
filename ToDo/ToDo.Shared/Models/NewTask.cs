namespace ToDo.Shared.Models;

public record NewTask(string Title, string? Description, Guid? CategoryId);

