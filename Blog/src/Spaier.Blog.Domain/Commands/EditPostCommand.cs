using MediatR;

namespace Spaier.Blog.Domain.Commands;

public record EditPostCommand : IRequest<Post>
{
    public required string Id { get; set; }

    public string? Title { get; set; }

    public string? Content { get; set; }
}

public class EditPostCommandHandler : IRequestHandler<EditPostCommand, Post>
{
    public Task<Post> Handle(EditPostCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
