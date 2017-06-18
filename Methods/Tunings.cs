using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace GuitarPracticeTrackerEngine
{
    public static class Tunings
    {
        public static BindingList<string> ListOfTunings;

        static Tunings()
        {
            ListOfTunings = new BindingList<string>();
            ListOfTunings.Add("Standard");
            ListOfTunings.Add("Dropped D");
        }
 
    

        public static bool AddTuning(string tuningName)
        {
            if (ListOfTunings.Any(x => x == tuningName || tuningName.Trim() != ""))
            {
                return false;
            }
            else
            {
                ListOfTunings.Add(tuningName);
                return true;
            }
        }

        public static string FindTuningByString(string inTuning)
        {
            return ListOfTunings.SingleOrDefault(tuning => tuning == inTuning);          
        }
    }
}
