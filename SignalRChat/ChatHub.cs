using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Llama al método broadcastMessage para actualizar clientes.
            Clients.All.broadcastMessage(name, message);
        }
    }
}