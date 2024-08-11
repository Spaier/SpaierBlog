using MediatR;

namespace Spaier.Blog.Domain.Queries;

public class GetAuthorsQuery : IRequest<List<Author>>
{
}
