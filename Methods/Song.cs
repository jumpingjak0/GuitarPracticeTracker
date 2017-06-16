using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuitarPracticeTrackerEngine
{
    public enum Difficulty
    {
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
    }
}
