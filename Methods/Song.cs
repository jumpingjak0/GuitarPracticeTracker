using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarPracticeTrackerEngine
{
    public enum Difficulty
    { 
        Null,
        Easy,
        Intermediate,
        Hard
    }

    public class Song
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Tuning { get; set; }
        public DateTime DateTimeLastPracticed { get; set; }
        public Difficulty Difficulty { get; set; }
        public List<string> Comments { get; set; }   
        public int ID { get; set; }

        public Song(string name, string artist = null, string tuning = null, Difficulty difficulty = Difficulty.Null, int id)
        {
            Name = name;
            Artist = artist;
            Tuning = tuning;
            Difficulty = difficulty;
            ID = id;
        }
    }
}
