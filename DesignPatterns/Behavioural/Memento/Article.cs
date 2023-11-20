using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Memento
{
    public class Article
    {
        public string  Title { get; set; }
        public string Content { get; set; }

        public ArticleMemento Save()
        {
            return new ArticleMemento
            {
                Title = Title,
                Content = Content
            };
        }

        public void Restore(ArticleMemento memento)
        {
            this.Title = memento.Title;
            this.Content = memento.Content;
        }
    }
}
