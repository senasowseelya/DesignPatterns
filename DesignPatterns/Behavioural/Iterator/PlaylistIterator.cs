using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Iterator
{
    internal class PlaylistIterator : IIterator<Song>
    {
        private readonly PlayListAggregate playList;
        private int index = 0;

        public PlaylistIterator(PlayListAggregate playList)
        {
            this.playList = playList;
        }
        public bool HasNext()
        {
           return index < this.playList.songs.Count;
        }

        public Song Next()
        {
            return this.playList.songs[index++];
        }
    }
}
