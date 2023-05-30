﻿using Application.Abstractions;
using Application.Chapters.Commands;
using Domain.Chapter;
using MediatR;

namespace Application.Chapters.CommandHandlers;

public class CreateChapterHandler : IRequestHandler<CreateChapter, Chapter>
{
    private readonly IChapterRepository _chapterRepository;

    public CreateChapterHandler(IChapterRepository chapterRepository)
    {
        _chapterRepository = chapterRepository;
    }

    public async Task<Chapter> Handle(CreateChapter request, CancellationToken cancellationToken)
    {
        var chapter = new Chapter
        {
            Title = request.Title,
            Description = request.Description
        };

        return await _chapterRepository.AddChapter(chapter);
    }
}
