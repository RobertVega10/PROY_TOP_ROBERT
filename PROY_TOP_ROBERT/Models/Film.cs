using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PROY_TOP_ROBERT.Models
{
    [Table("film")]
    public partial class Film
    {
        public Film()
        {
            FilmList = new HashSet<FilmList>();
            FilmActors = new HashSet<FilmActor>();
            FilmCategories = new HashSet<FilmCategory>();
            Inventories = new HashSet<Inventory>();
        }


        public int FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ReleaseYear { get; set; }
        public string LanguageId { get; set; }
        public string OriginalLanguageId { get; set; }
        public string RentalDuration { get; set; }
        public string RentalRate { get; set; }
        public string Length { get; set; }

        public string ReplacementCost { get; set; }
        public string Rating { get; set; }

        public string SpecialFeatures { get; set; }
        public DateTime LastUpdate { get; set; }

        public virtual ICollection<FilmList> FilmList { get; set; }
        public virtual ICollection<FilmText> FilmText { get; set; }
        public virtual ICollection<FilmActor> FilmActors { get; set; }
        public virtual ICollection<FilmCategory> FilmCategories { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
