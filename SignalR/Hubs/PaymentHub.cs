using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class PaymentHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            //get conntection Id Context.ConnectionId;

            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            return base.OnDisconnectedAsync(exception);
        }
    }
}
