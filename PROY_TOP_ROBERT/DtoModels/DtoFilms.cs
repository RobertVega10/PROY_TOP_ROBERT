using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROY_TOP_ROBERT.DtoModels
{
    public class DtoFilms
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double ReleaseYear { get; set; }
        public double LanguageId { get; set; }
        public string OriginalLanguageId { get; set; }
        public double RentalDuration { get; set; }
        public double RentalRate { get; set; }
        public double Length { get; set; }
        public double ReplacementCost { get; set; }
        public string Rating { get; set; }
        public string SpecialFeatures { get; set; }
        public DateTime LastUpdate { get; set; }

        public IList<DtoFilmsText> filmstext { get; set; }

    }
}
