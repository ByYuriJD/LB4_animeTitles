using System;
using System.Collections.Generic;
using LB4_animeTypesApp.Models;

namespace LB4_animeTypesApp;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateOfRegistration { get; set; }

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
