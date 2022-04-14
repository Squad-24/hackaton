using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalShare.Models;
using TechnicalShare.Services;

namespace TechnicalShare.Hubs
{
    public class ChatHub :Hub
    {
        private readonly static ConnectionsService _connections = new ConnectionsService();

        public override Task OnConnectedAsync()
        {
            var user = JsonConvert.DeserializeObject<User>(Context.GetHttpContext().Request.Query["user"]);
            _connections.Add(Context.ConnectionId, user);
            Clients.All.SendAsync("chat", _connections.GetAllUser(), user);
            return base.OnConnectedAsync();
        }

        public async Task SendMessage(Message chat)
        {
            await Clients.Client(_connections.GetUserId(chat.destination)).SendAsync("Receive", chat.sender, chat.message);
        }
    }
}
