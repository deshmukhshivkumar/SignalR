using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class SimpleHub : Hub
    {
        public void Hello()
        {
            // Client will invoke server method Hello through javascript   and   server will respond by invoking client method called introduce and passing it string
            Clients.All.introduce("Hello World !!!");
            //Clients.Caller.introduce("Hello World !!!");
            //Clients.Others.introduce("Hello World !!!");
        }
    }
}