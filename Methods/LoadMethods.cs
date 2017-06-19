using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.ComponentModel;

namespace GuitarPracticeTrackerEngine
{
    public static class LoadMethods
    {

        const string FileName = "GuitarPracticeTrackerSavedInformation.XML";

        public static void loadSavedSongsFromXML()
        {
            if (File.Exists(FileName))
            {
                XmlDocument practiceTrackerInformation = new XmlDocument();

                practiceTrackerInformation.LoadXml(File.ReadAllText(FileName));

                foreach(XmlNode song in practiceTrackerInformation.SelectNodes("/PracticeTracker/SavedSongs/SongInformation"))
                {
                    BindingList<string> comments = new BindingList<string>();
                    
                    string name = Convert.ToString(song.Attributes["Name"].Value);
                    string artist = Convert.ToString(song.Attributes["Artist"].Value);
                    DateTime timeLastPracticed = Convert.ToDateTime(song.Attributes["DTLastPracticed"].Value);
                    string tuning = Convert.ToString(song.Attributes["Tuning"].Value);
                    Difficulty difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), Convert.ToString(song.Attributes["Difficulty"].Value));
                    string inCommentsLongString = song.Attributes["Comments"].Value;
                    string[] inCommentsSplit = inCommentsLongString.Split('|');
                    foreach(string comment in inCommentsSplit)
                    {
                        if (comment.Trim() != "")
                        comments.Add(comment);
                    }

                    
                    SongList.LoadSong(name, artist, tuning, difficulty, timeLastPracticed, comments);                  
                }
                

                foreach (XmlNode node in practiceTrackerInformation.SelectNodes("/PracticeTracker/Tunings/Tuning")) 
                {
                    Tunings.AddTuning(Convert.ToString(node.InnerText));
                }
            }
            else
            {
                return;
            }
        }
    }
}
