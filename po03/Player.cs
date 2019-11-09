using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po03
{
    class Player
    {
        private List<Song> songList;

        public Player()
        {
            songList = new List<Song>();
        }

        public void Add(Song song)
        {
            songList.Add(song);
        }

        public void Remove(int songIndex)
        {
            if (IsExist(songIndex))
            {
                songList.RemoveAt(songIndex);
            }
        }

        public void Play(int songIndex)
        {
            if (IsExist(songIndex))
            {
                songList[songIndex].Play();
            }
        }

        public void PlayAllSongs()
        {
            for (int i = 0; i < songList.Count; i++)
            {
                Play(i);
            }
        }

        private bool IsExist(int songIndex)
        {
            if (songIndex < 0 || songIndex > songList.Count - 1)
            {
                Console.WriteLine("Nieprawidłowy index utworu.");
                return false;
            }
            return true;
        }
    }
}
