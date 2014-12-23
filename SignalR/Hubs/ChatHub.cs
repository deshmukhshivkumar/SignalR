using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void SendMessage(string userName , string message)
        {
            Clients.All.showMessage(userName, message + " <i>sent at " + DateTime.Now +"</i>");
            
         
        }
    }
}