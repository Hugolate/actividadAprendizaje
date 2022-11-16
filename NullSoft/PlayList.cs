using System;
using System.Collections.Generic;
using System.Text;

namespace NullSoft
{
    class PlayList
    {
        public string playListName { get; set; }
        public List<Song> allSongs { get; }
        public Boolean privacity { get; set; }

        public PlayList(string name, Boolean privacity)
        {
            this.playListName = name;
            changePrivacity(privacity);
        }

        public Song getSongByName(string name)
        {
            foreach (Song iterator in allSongs)
            {
                if (iterator.songName == name)
                {
                    return iterator;
                }
            }
            return null;
        }

        public void addSong(Song newSong)
        {
            if (!allSongs.Contains(newSong))
            {
                allSongs.Add(newSong);
            }
            else
            {
                Console.WriteLine("This playlist already contains the song");
            }
        }

        public void removeSong(Song songToRemove)
        {
            if (allSongs.Contains(songToRemove))
            {
                allSongs.Remove(songToRemove);
            }
        }

        public void changePrivacity(Boolean boo)
        {
            privacity = boo;
        }
    }
}