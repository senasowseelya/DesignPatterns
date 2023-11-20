using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{
    internal class CloseCommand : ICommand
    {
        private readonly Document document;

        public CloseCommand(Document document)
        {
            this.document = document;
        }
        public void Execute()
        {
            this.document.Close();
        }
    }
}
