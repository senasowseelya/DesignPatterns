using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{

    public class WhatsappGroup : IGroup
    {

        List<User> users = new List<User>();

        public void Register(User user)
        {
            users.Add(user);
            user.Group = this;  
            Console.WriteLine("User Added");
        }

        public void SendMessage(User user, string message)
        {
            foreach (User u in users)
            {
                if (u.Name != user.Name)
                {
                   u.Receive(user,message);
                }
            }
        }
    }
}
