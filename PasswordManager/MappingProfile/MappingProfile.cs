﻿using AutoMapper;
using PasswordManager.Entities;
using PasswordManager.Models;

namespace PasswordManager.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
