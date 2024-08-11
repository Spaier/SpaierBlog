using MediatR;

using Spaier.Blog.Domain.Events;
using Spaier.Blog.Domain.Exceptions;

namespace Spaier.Blog.Domain;

public record Post
{
    public required string Id { get; init; }

    private string _title = default!;
    public required string Title
    {
        get => _title;
        init => _title = value;
    }

    private string _content = default!;
    public required string Content
    {
        get => _content;
        init => _content = value;
    }

    public required string AuthorId { get; init; }

    public Author Author { get; init; } = default!;

    public void Edit(
        string editorId,
        string? title,
        string? content,
        IMediator mediator)
    {
        if (AuthorId != editorId)
        {
            throw new EditorIsNotAuthorException
            {
                AuthorId = AuthorId,
                EditorId = editorId,
            };
        }
        if (title is null && content is null)
        {
            throw new NotImplementedException("Not possible.");
        }
        if (title is not null)
        {
            _title = title;
        }
        if (content is not null)
        {
            _content = content;
        }
        mediator.Publish(new PostEdited()
        {
            PostId = Id,
            NewTitle = _title,
            NewContent = _content,
            EditorId = editorId,
        });
    }

    public void Delete(
        string editorId,
        IMediator mediator)
    {
        if (AuthorId != editorId)
        {
            throw new EditorIsNotAuthorException
            {
                AuthorId = AuthorId,
                EditorId = editorId,
            };
        }
        mediator.Publish(new PostDeleted
        {
            PostId = Id,
        });
    }
}
