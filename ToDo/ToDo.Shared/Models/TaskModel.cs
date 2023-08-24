namespace ToDo.Shared.Models;

public record TaskModel(Guid Id, string Title, string? Description, Guid? CategoryId);
