using System;
using System.Collections.Generic;

namespace LB4_animeTypesApp.Models;

public partial class AnimeType
{
    public int Id { get; set; }

    public string TypeOfAnime { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
