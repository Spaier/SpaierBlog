using MediatR;

namespace Spaier.Blog.Domain.Queries;

public class GetPostsQuery : IRequest<List<Post>>
{
}
