using MediatR;

namespace Spaier.Blog.Domain.Events;

public record PostCreated : INotification
{
    public required string PostId { get; init; }

    public required string Title { get; init; }

    public required string Content { get; init; }

    public required string AuthorId { get; init; }
}
