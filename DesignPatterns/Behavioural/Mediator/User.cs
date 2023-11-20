using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public class User
    {
        public IGroup Group { get; set; }
        public string Name { get; set; }
       

        public void Receive(User user,string message)
        {
            Console.WriteLine($"{message} Received Message from {user.Name} to {Name}");
        }

        //calls send message from mediator class rather than exeuting logic here.
        public void SendMessage(string message)
        {
            Group.SendMessage(this,message);
        }
    }
}
