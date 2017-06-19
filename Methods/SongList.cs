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
        public static BindingList<Song> SortedListOfSongs { get; set; }
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

        public static void LoadSong(string name, string artist, string tuning, Difficulty difficulty, DateTime timeLastPracticed, BindingList<string> comments)
        {
            Song songToLoad = new Song(name, IDForNextSong, artist, tuning, difficulty);
            songToLoad.DateTimeLastPracticed = timeLastPracticed;
            foreach(string comment in comments)
            {
                songToLoad.Comments.Add(comment);
            }
            ListOfSongs.Add(songToLoad);
            IDForNextSong++;             
        }

        public static void SortSongsByName()
        {
            List<Song> tempList = SongList.ListOfSongs.OrderBy(x => x.Name).ToList();
            SongList.SortedListOfSongs.Clear();
            foreach (Song song in tempList)
            {
                SongList.SortedListOfSongs.Add(song);
            }
        }
        public static void SortSongsByArtist()
        {
            List<Song> tempList = SongList.ListOfSongs.OrderBy(x => x.Artist).ToList();
            SongList.SortedListOfSongs.Clear();
            foreach (Song song in tempList)
            {
                SongList.SortedListOfSongs.Add(song);
            }
        }
        public static void SortSongsByTuning()
        {
            List<Song> tempList = SongList.ListOfSongs.OrderBy(x => x.Tuning).ToList();
            SongList.SortedListOfSongs.Clear();
            foreach (Song song in tempList)
            {
                SongList.SortedListOfSongs.Add(song);
            }
        }
        public static void SortSongsByTime()
        {
            List<Song> tempList = SongList.ListOfSongs.OrderBy(x => x.MinutesSinceLastPracticed).ToList();
            SongList.SortedListOfSongs.Clear();
            foreach (Song song in tempList)
            {
                SongList.SortedListOfSongs.Add(song);
            }
            SongList.SortedListOfSongs.Reverse();
        }

        public static void SortByDifficulty()
        {
            List<Song> tempList = SongList.ListOfSongs.OrderBy(x => x.Difficulty.ToString()).ToList();
            SongList.SortedListOfSongs.Clear();
            foreach (Song song in tempList)
            {
                SongList.SortedListOfSongs.Add(song);
            }
        }
    }
}
