using AutoMapper;
using Procurment.Dtos;
using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Procurment.Controllers.ApiSupplier
{
    public class SuppliersController : ApiController
    {
        private ApplicationDbContext _context;
        public SuppliersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/suppliers
        public IEnumerable<SupplierOrderDto> GetOrders()
        {
            return _context.Orders.ToList().Select(Mapper.Map<Order, SupplierOrderDto>);
        }

        //GET /api/suppliers/1
        public IHttpActionResult GetOrders(DateTime date)
        {
            var order = _context.Orders.SingleOrDefault(o => o.Date == date);
            if (order == null)
                return NotFound();

            return Ok(Mapper.Map<Order, SupplierOrderDto>(order));
        }

        //PUT /api/suppliers/1
        [HttpPut]
        public void updateStatus(string id,Order order)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var orderInDb = _context.Orders.SingleOrDefault(o => o.OrderId == id);

            if (orderInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            orderInDb.SupplierStatus = order.SupplierStatus;

            

            _context.SaveChanges();

            
        }

        //DELETE /api/suppliers/1
        [HttpDelete]
        public IHttpActionResult DeleteOrder(string id)
        {
            var orderInDb = _context.Orders.SingleOrDefault(o => o.OrderId == id);

            if (orderInDb == null)
                return NotFound();
            _context.Orders.Remove(orderInDb);
            _context.SaveChanges();

            return Ok();

        }
    }
}
