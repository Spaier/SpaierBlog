using MediatR;

namespace Spaier.Blog.Domain.Events;

public record PostDeleted : INotification
{
    public required string PostId { get; init; }
}
