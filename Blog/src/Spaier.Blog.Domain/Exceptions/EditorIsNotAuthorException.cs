namespace Spaier.Blog.Domain.Exceptions;

public class EditorIsNotAuthorException() : Exception("Editor tried to modify not his own post")
{
    public required string AuthorId { get; init; }

    public required string EditorId { get; init; }
}
