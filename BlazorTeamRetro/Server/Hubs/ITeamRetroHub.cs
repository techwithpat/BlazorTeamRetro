using BlazorTeamRetro.Shared;

namespace BlazorTeamRetro.Server.Hubs
{
    public interface ITeamRetroHub
    {
        Task ReceiveRetroItem(RetrospectiveItem item);
        Task UpdateClientsCount(int count);
    }
}
