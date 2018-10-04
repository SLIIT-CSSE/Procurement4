using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Procurment.Models;
using Procurment.Dtos;
using AutoMapper;

namespace Procurment.Controllers.Api
{
    public class PaymentsController : ApiController
    {
        private ApplicationDbContext _context;
         
        public PaymentsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/payments
        public IEnumerable<PaymentDto> GetSuccessPayments()
        {
            return _context.Payments.ToList().Select(Mapper.Map<Payment,PaymentDto>);

        }

        //GET /api/payments/1
        public PaymentDto GetSuccessPayment(string id)
        {
            var successpayment = _context.Payments.SingleOrDefault(p => p.PaymentId == id);

            if (successpayment == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return Mapper.Map<Payment,PaymentDto>(successpayment);
        }

        //POST  /api/payments
        [HttpPost]
        public PaymentDto CreatePayment(PaymentDto paymentDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var payment = Mapper.Map<PaymentDto, Payment>(paymentDto);
            _context.Payments.Add(payment);
            _context.SaveChanges();

            paymentDto.PaymentId = payment.PaymentId;

            return paymentDto;
        }

        //DELETE  /api/payments/1
        [HttpDelete]
        public void RemovePayment(string id)
        {
            var paymentInDb = _context.Payments.SingleOrDefault(p => p.PaymentId == id);

            if (paymentInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Payments.Remove(paymentInDb);
            _context.SaveChanges();
        }
    }
}
