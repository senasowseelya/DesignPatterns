using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{
    internal class OpenCommand : ICommand
    {
        private readonly Document document;

        public OpenCommand(Document document)
        {
            this.document = document;
        }
        public void Execute()
        {
            this.document.Open();
        }
    }
}
