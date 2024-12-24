using System;
using System.Collections.Generic;

namespace LB4_animeTypesApp.Models;

public partial class AnimeTitle
{
    public int Id { get; set; }

    public int IdAnimeType { get; set; }

    public int IdGenre { get; set; }

    public int IdUser { get; set; }

    public string OriginalName { get; set; } = null!;

    public string TitleName { get; set; } = null!;

    public int? YearOfRelease { get; set; }

    public string? Description { get; set; }

    public string? Poster { get; set; }

    public int? CountOfSeries { get; set; }

    public int? Duration { get; set; }

    public bool IsComplete { get; set; }

    public string Studio { get; set; } = null!;

    public virtual AnimeType IdAnimeTypeNavigation { get; set; } = null!;

    public virtual Genre IdGenreNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
