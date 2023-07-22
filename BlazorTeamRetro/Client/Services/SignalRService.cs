using BlazorTeamRetro.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace BlazorTeamRetro.Client.Services
{
    public class SignalRService : IAsyncDisposable
    {
        HubConnection? _hubConnection;
        private readonly NavigationManager _navigationManager;

        public event Action<RetrospectiveItem> OnItemReceived;
        public event Action<int> OnUpdateClientsCount;

        public SignalRService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public async Task StartConnection()
        {
            if (_hubConnection is not null) return;
            _hubConnection = new HubConnectionBuilder()
                .WithUrl(_navigationManager.ToAbsoluteUri("/teamretrohub"))
                .Build();

            _hubConnection.On<RetrospectiveItem>("ReceiveRetroItem", item => OnItemReceived?.Invoke(item));
            _hubConnection.On<int>("UpdateClientsCount", count => OnUpdateClientsCount?.Invoke(count));

            await _hubConnection.StartAsync();
        }

        public async Task SendMessage(RetrospectiveItem item)
        {
            if (_hubConnection is null) return;
            await _hubConnection.SendAsync("SendRetroItem", item);
        }

        public async ValueTask DisposeAsync()
        {
            if (_hubConnection is not null)
            {
                await _hubConnection.DisposeAsync();
            }
        }
    }
}
