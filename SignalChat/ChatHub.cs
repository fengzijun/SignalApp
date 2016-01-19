using Microsoft.AspNet.SignalR;
using System;
using System.Threading.Tasks;

namespace SignalChat
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.

            Task perdiodicTask = PeriodicTaskFactory.Start(() =>
            {
                // Console.WriteLine(DateTime.Now);
                Clients.All.addNewMessageToPage(name, DateTime.Now.ToString());
            },
            intervalInMilliseconds: 2000// fire every two seconds...
           );

         
        }
    }
}