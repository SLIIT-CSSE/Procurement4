using Procurment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Procurment.Controllers.Api
{
    public class PendingPaymentsController : ApiController
    {
        private ApplicationDbContext _context;

        public PendingPaymentsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/PendingPayments
        public IEnumerable<Order> GetPendingOrders()
        {
            return _context.Orders.ToList();
        }

        //GET /api/PendingPayments/1
        public Order GetPendingOrders(string id)
        {
            var pendingPayment = _context.Orders.SingleOrDefault(p => p.OrderId == id);

            if(pendingPayment == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return pendingPayment;

        }
    }
}
