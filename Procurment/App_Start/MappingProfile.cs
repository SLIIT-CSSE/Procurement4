using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Procurment.Dtos;
using Procurment.Models;

namespace Procurment.App_Start
{
    public class MappingProfile : Profile
    {
       public MappingProfile()
        {
            Mapper.CreateMap<Payment, PaymentDto>();
            Mapper.CreateMap<PaymentDto,Payment>();
        }
    }
}