using AutoMapper;
using OrderPoolManager.Models;
using OrderPoolManager.Repositories.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPoolManager.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TOrder, OrderDetail>().ReverseMap();
        }
    }
}
