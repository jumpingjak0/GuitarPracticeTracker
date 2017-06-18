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
        private int DaysSinceLastPracticed
        {
            get
            {
                return DateTime.Now.Subtract(DateTimeLastPracticed).Hours;
            }
        } 
        public string LastPracticedMessage
        {
            get
            {
                return practiceMessage();
            }
        }
        public Difficulty Difficulty { get; set; }
        public List<string> Comments { get; set; }   
        public int ID { get; set; }

        public Song(string name, int id, string artist = null, string tuning = null, Difficulty difficulty = Difficulty.Null)
        {
            Name = name;
            Artist = artist;
            Tuning = tuning;
            Difficulty = difficulty;
            ID = id;
            Comments = new List<string>();
        }

        private string practiceMessage()
        {
            DateTime initialTime = DateTime.Parse("01/01/0001 01:00:00");
            if(DateTimeLastPracticed == initialTime)
            {
                return "Not Practiced";
            }
            else
            {
                return DaysSinceLastPracticed + " days ago";
            }
        }

        
    }
}
