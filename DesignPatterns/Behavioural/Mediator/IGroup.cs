using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    /// <summary>
    /// Interface which acts as mediator
    /// </summary>
    public interface IGroup
    {
        public void SendMessage(User user,string message);
        public void Register(User user);
    }
}
