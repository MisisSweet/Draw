using Draw.Models;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Draw
{
    public class DrawHub : Hub
    {
        public async Task Send(Data message)
        {
            await Clients.Others.SendAsync("Receive", message);
        }
    }
}