using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace GuitarPracticeTrackerEngine
{
    public static class LoadMethods
    {

        const string FileName = "GuitarPracticeTrackerSavedInformation.XML";

        public static void loadSavedSongsFromXML()
        {
            if (File.Exists(FileName))
            {

            }
            else
            {
                return;
            }
        }
    }
}
