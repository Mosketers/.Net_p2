using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Web.Hubs
{
    public class PushEmployee : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void SendEmployee(int IdEmployee)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<PushEmployee>();
            hubContext.Clients.All.addEmployee(IdEmployee);
        }
    }
}