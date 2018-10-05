using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Procurment.Dtos;
using AutoMapper;

namespace Procurment.Controllers.ApiOrder
{
    public class OrderManageController : ApiController
    {
        private ApplicationDbContext _context;

        public OrderManageController()
        {
            _context = new ApplicationDbContext();
        }

        // GET/api/ordermanage
        public IEnumerable<OrdersDto> GetOrderDetails()
        {
            return _context.Orders.ToList().Select(Mapper.Map<Order, OrdersDto>);
        }

        // GET/api/ordermanage/id
        public OrdersDto GetOrderDetails(string id)
        {
            var order = _context.Orders.SingleOrDefault(o => o.OrderId == id);

            if (order == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Order, OrdersDto>(order);
        }

        // POST/api/ordermanage
        [HttpPost]
        public OrdersDto SaveOrder(OrdersDto orderDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var order = Mapper.Map<OrdersDto, Order>(orderDto);
            _context.Orders.Add(order);
            _context.SaveChanges();

            orderDto.OrderId = order.OrderId;

            return orderDto;

        }

        // PUT/api/ordermanage
        [HttpPut]
        public void UpdateOrder(string id, OrdersDto orderDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var orderInDb = _context.Orders.SingleOrDefault(c => c.OrderId == id);

            if (orderInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(orderDto, orderInDb);

            _context.SaveChanges();

        }


        // DELETE/api/ordermanage/id
        [HttpDelete]
        public void DeleteOrderDetails(string id)
        {
            var orderInDb = _context.Orders.SingleOrDefault(o => o.OrderId == id);

            if (orderInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Orders.Remove(orderInDb);
            _context.SaveChanges();
        }

    }
}
