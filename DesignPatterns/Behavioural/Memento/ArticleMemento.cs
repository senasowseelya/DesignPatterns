using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Memento
{
    public class ArticleMemento
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

    }
}
