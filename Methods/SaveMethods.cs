using System.IO;
using System.Xml;

namespace GuitarPracticeTrackerEngine
{
    public static class SaveMethods
    {

        const string FileName = "GuitarPracticeTrackerSavedInformation.XML";

        public static void SavesToXML()
        {
            XmlDocument savedSongs = new XmlDocument();

            XmlNode practiceTracker = savedSongs.CreateElement("PracticeTracker");
            savedSongs.AppendChild(practiceTracker);

            XmlNode songList = savedSongs.CreateElement("SavedSongs");
            practiceTracker.AppendChild(songList);


            foreach (Song song in SongList.ListOfSongs)
            {
                XmlNode songInformation = savedSongs.CreateElement("SongInformation");

                XmlAttribute name = savedSongs.CreateAttribute("Name");
                name.Value = song.Name;
                songInformation.Attributes.Append(name);

                XmlAttribute artist = savedSongs.CreateAttribute("Artist");
                artist.Value = song.Artist;
                songInformation.Attributes.Append(artist);

                XmlAttribute dtLastPracticed = savedSongs.CreateAttribute("DTLastPracticed");
                dtLastPracticed.Value = song.DateTimeLastPracticed.ToString();
                songInformation.Attributes.Append(dtLastPracticed);

                XmlAttribute songTuning = savedSongs.CreateAttribute("Tuning");
                songTuning.Value = song.Tuning;
                songInformation.Attributes.Append(songTuning);

                XmlAttribute difficulty = savedSongs.CreateAttribute("Difficulty");
                difficulty.Value = song.Difficulty.ToString();
                songInformation.Attributes.Append(difficulty);

                XmlNode comments = savedSongs.CreateElement("Comments");
                songInformation.AppendChild(comments);

                foreach (string comment in song.Comments)
                {
                    XmlNode currentComment = savedSongs.CreateElement("Comment");
                    currentComment.AppendChild(savedSongs.CreateTextNode(comment));
                    comments.AppendChild(currentComment);
                }

                songList.AppendChild(songInformation);
            }

            XmlNode tuning = savedSongs.CreateElement("Tunings");
            practiceTracker.AppendChild(tuning);

            foreach (string tuningName in Tunings.ListOfTunings)
            {
                XmlNode currentTuning = savedSongs.CreateElement("Tuning");
                currentTuning.AppendChild(savedSongs.CreateTextNode(tuningName));
                tuning.AppendChild(currentTuning);
            }
            File.WriteAllText(FileName, savedSongs.InnerXml);
        }
    }
}
