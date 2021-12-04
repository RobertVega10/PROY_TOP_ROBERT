using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROY_TOP_ROBERT.Profiles
{
    public class DtoFilmsTextProfile : Profile
    {
        public DtoFilmsTextProfile()
        {
            CreateMap<Models.FilmText, DtoModels.DtoFilmsText>();
        }

    }
}
