using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Command
{
    internal class SaveCommand : ICommand
    {
        private readonly Document document;

        public SaveCommand(Document document)
        {
            this.document = document;
        }
        public void Execute()
        {
            this.document.Save();
        }
    }
}
