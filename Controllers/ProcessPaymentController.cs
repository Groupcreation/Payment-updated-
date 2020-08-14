using Microsoft.AspNetCore.Mvc;
using Payment.Models;
using Payment.Repository;
using System;

namespace Payment.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessPaymentController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ProcessPaymentController));
        public IPayment _context;
        public ProcessPaymentController(IPayment context)
        {
            this._context = context;

        }

        [HttpPost]
        public dynamic ProcessPayment(CardDetails det)
        {

            _log4net.Info("Payment initiated");
            try
            {
                
                var payment = _context.ProcessPayment(det);
                return Ok(payment);
            }
            catch(Exception exception)
            {
                return BadRequest("Exception occured"+ exception);
            }
        }
    }
}
