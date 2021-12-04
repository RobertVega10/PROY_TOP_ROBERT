using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROY_TOP_ROBERT.Profiles
{
    public class DtoFilmsProfile: Profile
    {
        public DtoFilmsProfile()
        {
            CreateMap<Models.FilmText, DtoModels.DtoFilms>();
        }
    }
}
