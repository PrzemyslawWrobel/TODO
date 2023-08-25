using ToDo.Shared.Enums;

namespace ToDo.Shared.Models;

public record TaskModel(Guid Id, string Title, Status Status, Category? Category, string? Description);
