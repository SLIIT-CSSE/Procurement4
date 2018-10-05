using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Procurment.Dtos;
using Procurment.Models;

namespace Procurment.App_Start
{
    public class MappingSupplierOrderProfile : Profile
    {
        public MappingSupplierOrderProfile()
        {
            Mapper.CreateMap<Order, SupplierOrderDto>();
            Mapper.CreateMap<SupplierOrderDto, Order>();
        }
        
    }
}