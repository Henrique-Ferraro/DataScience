using appMVC.Data.Dtos;
using appMVC.models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Profiles
{
    public class TelefoneProfile : Profile
    {
        public TelefoneProfile()
        {
            CreateMap<CreateTelefoneDto, mdlTelefone>();
            CreateMap<UpdateTelefoneDto, mdlTelefone>();
            CreateMap<mdlTelefone, ReadTelefoneaDto>();
        }
    }
}
