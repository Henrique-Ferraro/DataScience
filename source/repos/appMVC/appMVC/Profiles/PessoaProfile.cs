using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using appMVC.Data.Dtos;
using appMVC.Models;
using AutoMapper;

namespace appMVC.Profiles
{
    public class PessoaProfile : Profile
    {
        public PessoaProfile()
        {
            CreateMap<CreatePessoaDto, mdlPessoa>();
            CreateMap<UpdatePessoaDto, mdlPessoa>();
            CreateMap<mdlPessoa, ReadPessoaDto>();
        }
    }
}
