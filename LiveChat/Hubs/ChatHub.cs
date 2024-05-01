using LiveChat.Components.Pages;
using LiveChat.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace LiveChat.Hubs
{


    public class ChatHub : Hub
    {
        
        public async Task SendMessage(string message, string toReceiver, string username)
        {

            if (username is string userName)
            {
                await Clients.All.SendAsync("ReceiveMessage",message, userName, toReceiver);
            }
            Console.WriteLine(username);
        }


        


    }
}
