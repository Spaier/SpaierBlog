namespace Spaier.Blog.Domain;

public record Author
{
    public required string Id { get; init; }

    public required string Name { get; init; }
}
