using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{

    //Invoker class
    internal class MenuOptionsInvoker
    {
        private readonly ICommand openCommand;
        private readonly ICommand saveCommand;
        private readonly ICommand closeCommand;
        public MenuOptionsInvoker(ICommand open, ICommand save , ICommand close)
        {
            this.openCommand = open;
            this.saveCommand = save;
            this.closeCommand = close;
        }
        public void OpenDocument()
        {
            openCommand.Execute();
        }

        public void SaveDocument()
        {
            saveCommand.Execute();
        }

        public void CloseDocument()
        {
            closeCommand.Execute();
        }
    }
}
