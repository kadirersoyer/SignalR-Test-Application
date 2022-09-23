using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Hubs;
using SignalR.Models;

namespace SignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IHubContext<PaymentHub> _paymentHubContext;

        public CustomerController(IHubContext<PaymentHub> paymentHubContext)
        {
            _paymentHubContext = paymentHubContext;
        }
        [HttpGet("/get-all-customer")]
        public async Task<IActionResult> GetAllCustomer()
        {

            await _paymentHubContext.Clients.All.SendAsync("RecieveMesage", new PaymentModel
            {
                PaymentId = 1,
                Message = "Test Client Message"
            });

            return Ok(new { IsSuccess = true, Message = "test" });
        }
    }
}
