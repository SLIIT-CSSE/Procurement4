using AutoMapper;
using Procurment.Dtos;
using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Procurment.App_Start
{
    public class MappingSearchProfile : Profile
    {
        public MappingSearchProfile()
        {
            Mapper.CreateMap<Order , OrderDto>();
            Mapper.CreateMap<OrderDto , Order>();
          
        }
    }
}   