using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace GuitarPracticeTrackerEngine
{
    public static class SongList
    {
        public static BindingList<Song> ListOfSongs { get; set; }
        private static int IDForNextSong;
        static SongList()
        {
            ListOfSongs = new BindingList<Song>();
            IDForNextSong = 1;
        }      

        public static void AddNewSong(string name, string artist = null, string tuning = null, Difficulty difficulty = Difficulty.Null)
        {

            Song songToAdd = (new Song(name, IDForNextSong, artist, tuning, difficulty));
            songToAdd.DateTimeLastPracticed = DateTime.Parse("01/01/0001 01:00:00");
            ListOfSongs.Add(songToAdd);
            IDForNextSong++;
        }


        public static Song FindSongByID(int id)
        {
            return ListOfSongs.SingleOrDefault(song => song.ID == id);
        }

        public static void DeleteSong(Song songToDelete)
        {
            ListOfSongs.Remove(songToDelete);
        }

        internal static void LoadSong(string name, string artist, string tuning, Difficulty difficulty, DateTime timeLastPracticed)
        {
            Song songToLoad = new Song(name, IDForNextSong, artist, tuning, difficulty);
            songToLoad.DateTimeLastPracticed = timeLastPracticed;
            ListOfSongs.Add(songToLoad);
            IDForNextSong++;             
        }
    }
}
