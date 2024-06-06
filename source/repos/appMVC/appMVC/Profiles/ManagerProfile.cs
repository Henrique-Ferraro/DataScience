using appMVC.Data.Dtos.Manager;
using appMVC.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appMVC.Profiles
{
    public class ManagerProfile : Profile
    {
        public ManagerProfile()
        {
            CreateMap<CreateManagerDto, mdlManager>();
            CreateMap<mdlManager, ReadManagerDto>();

        }
    }
}
