﻿using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Dtos.ProductDtos;

namespace BabyCareProject.Mappings
{
    public class EventMapping : Profile
    {
        public EventMapping() 
        {
            CreateMap<Event, ResultEventDto>().ReverseMap();
            CreateMap<Event, CreateEventDto>().ReverseMap();
            CreateMap<Event, UpdateEventDto>().ReverseMap();
        }
    }
}
