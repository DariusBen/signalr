using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace signalrtpsignalr.aplicacion.hubs
{
    public class ChatHub : Hub
    {

        public async Task SendMessage(string room, string user, string message)
        { 
            await Clients.Group(room).SendAsync("ReceiveMessage",user,message);

        }

        public async Task AddToGroup(string room, string nombre)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId,room);

            await Clients.Group(room).SendAsync("ShowWho", $"{nombre} se unió a la Sala");

        }

    }
}
