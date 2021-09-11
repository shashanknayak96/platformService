using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using PlatformService.DTOS;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            //Source => Target

            //To Read
            CreateMap<Platform, PlatformReadDto>();

            //To Write
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
