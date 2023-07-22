using BlazorTeamRetro.Shared;
using Microsoft.AspNetCore.SignalR;

namespace BlazorTeamRetro.Server.Hubs
{
    public class TeamRetroHub : Hub<ITeamRetroHub>
    {
        static int clientsCount;
        public async Task SendRetroItem(RetrospectiveItem item)
        {
            await Clients.All.ReceiveRetroItem(item);
        }

        public override async Task OnConnectedAsync()
        {
            clientsCount++;
            await Clients.All.UpdateClientsCount(clientsCount);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientsCount--;
            await Clients.All.UpdateClientsCount(clientsCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
