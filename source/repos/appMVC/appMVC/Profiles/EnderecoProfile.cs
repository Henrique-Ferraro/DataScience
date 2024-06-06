using appMVC.Data.Dtos;
using appMVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Profiles
{
    public class EnderecoProfile : Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, mdlEndereco>();
            CreateMap<UpdateEnderecoDto, mdlEndereco>();
            CreateMap<mdlEndereco, ReadEnderecoDto>();
        }
    }
}
