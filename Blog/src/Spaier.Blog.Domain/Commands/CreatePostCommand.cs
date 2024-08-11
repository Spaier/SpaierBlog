using MediatR;

namespace Spaier.Blog.Domain.Commands;

public record CreatePostCommand : IRequest<Post>
{
    public required string Title { get; set; }

    public required string Content { get; set; }
}

public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Post>
{
    public Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
