using AutoMapper;
using Procurment.Dtos;
using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Procurment.Controllers.Api
{
    public class ViewOrdersController : ApiController
    {
        private ApplicationDbContext _context;
        public ViewOrdersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/Orders
        public IEnumerable<OrderDto> GetOrders()
        {
            return _context.Orders.ToList().Select(Mapper.Map<Order,OrderDto>);

        }

        //GET /api/Orders/Date
        public IHttpActionResult GetOrders(DateTime date)
        {
            var order = _context.Orders.SingleOrDefault(c => c.Date == date);
            if (order == null) throw new HttpResponseException(HttpStatusCode.NotFound);
            return Ok(Mapper.Map<Order,OrderDto>(order));
        }


        //PUT /api/suppliers/1
        [HttpPut]
        public void updateStatus(string id, Order order)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var orderInDb = _context.Orders.SingleOrDefault(o => o.OrderId == id);

            if (orderInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            orderInDb.CompanyStatus = order.CompanyStatus;



            _context.SaveChanges();


        }

        //DELETE /api/vieworders/1
        [HttpDelete]
        public IHttpActionResult DeleteOrder(string id)
        {
            var orderInDb = _context.Orders.SingleOrDefault(o => o.OrderId == id);

            if (orderInDb == null)
                return NotFound();
            _context.Orders.Remove(orderInDb);
            

            return Ok();

        }
    }
}
