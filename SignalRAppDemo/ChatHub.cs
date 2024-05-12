namespace SignalRAppDemo
{
    using Microsoft.AspNetCore.SignalR;

    public class ChatHub : Hub
    {
        // This method can be called by clients to send a message to everyone
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);

            await SendMessageToUser(user, "Hello");
        }

        public async Task SendMessageToUser(string userId, string message)
        {
            await Clients.User(userId).SendAsync("ReceiveMessage", "Server", message);
        }
    }
}
