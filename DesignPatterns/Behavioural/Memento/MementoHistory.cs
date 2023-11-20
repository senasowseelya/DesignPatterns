namespace DesignPatterns.Behavioural.Memento
{
    public class MementoHistory
    {
        private Stack<ArticleMemento> history = new Stack<ArticleMemento>();
        public void Save(Article article)
        {
            history.Push(article.Save()); 
        }

        public ArticleMemento GetLatestVersion()
        {
            return history.Pop();
        }

    }
}
