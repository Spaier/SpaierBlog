using MediatR;

namespace Spaier.Blog.Domain.Commands;

public class DeletePostCommand : IRequest<Post>
{
    public required string Id { get; set; }
}

public class DeletePostCommandHandler : IRequestHandler<DeletePostCommand, Post>
{
    public Task<Post> Handle(DeletePostCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
