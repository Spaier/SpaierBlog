using MediatR;

namespace Spaier.Blog.Domain.Events;

public record PostEdited : INotification
{
    public required string PostId { get; init; }

    public required string? NewTitle { get; init; }

    public required string? NewContent { get; init; }

    public required string EditorId { get; init; }
}
