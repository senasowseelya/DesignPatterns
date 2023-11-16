namespace DesignPatterns.Behavioural.Iterator
{
    internal class PlayListAggregate : IAggregate<Song>
    {
        public List<Song> songs = new List<Song>();
        public IIterator<Song> CreateIterator()
        {
            return new PlaylistIterator(this);
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
        }

       
    }
}
