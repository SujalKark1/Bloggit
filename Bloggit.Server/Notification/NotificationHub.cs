using Microsoft.AspNetCore.SignalR;

namespace Bloggit.Notification
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string message)
        {
            //await Clients.All.SendAsync("ReceiveNotification", message);
            await Clients.All.SendAsync("ReceiveNotification", "Hello welcome to softminds");
        }
    }
}
