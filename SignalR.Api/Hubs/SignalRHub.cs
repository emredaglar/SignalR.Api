using Microsoft.AspNetCore.SignalR;
using SignalR.Api.Context;

namespace SignalR.Api.Hubs
{
    public class SignalRHub:Hub
    {
        private readonly CustomerContext _context;

        public SignalRHub(CustomerContext context)
        {
            _context = context;
        }

        public async Task TotalCustomerCount()
        {
            var value=_context.Customers.Count();
            await Clients.All.SendAsync("ReceiveTotalCustomerCount", value);
        }
        public async Task BalanceLargerThan50000CustomerCount()
        {
            var value=_context.Customers.Where(x=>x.Balance>50000).Count();
            await Clients.All.SendAsync("ReceiveBalanceLargerThan50000CustomerCount", value);
        }
        public async Task CustomerList()
        {
            var value=_context.Customers.ToList();
            await Clients.All.SendAsync("ReceiveCustomerList",value);
        }
    }   
}
