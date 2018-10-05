using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Procurment.Dtos;
using Procurment.Models;

namespace Procurment.App_Start
{
    public class MappingProfileNew: Profile
    {
        public MappingProfileNew()
        {
            Mapper.CreateMap<Order, OrdersDto>();
            Mapper.CreateMap<OrdersDto, Order>();
        }
    }
}