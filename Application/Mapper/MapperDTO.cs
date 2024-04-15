﻿using Application.DTOs;
using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public class MapperDTO : Profile
    {
        public MapperDTO() 
        {
            CreateMap<Post, PostDTO>();
            CreateMap<PostDTO, Post>();
        }  
    }
}
