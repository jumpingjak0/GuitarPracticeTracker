using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuitarPracticeTrackerEngine;

namespace UI
{
    public partial class AddSongUI : Form
    {
        public AddSongUI()
        {
            InitializeComponent();
            cbTuning.DataSource = Tunings.ListOfTunings;
            cbDifficulty.DataSource = Enum.GetValues(typeof(Difficulty));
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            string name = isTextValid(tbName.Text);
            string artist = isTextValid(tbArtist.Text);
            string tuning = cbTuning.SelectedText;
            Difficulty difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), cbDifficulty.Text);

            SongList.AddNewSong(name, artist, tuning, difficulty);
            this.Close();
        }

        public string isTextValid(string inText)
        {
            if(inText.Trim() != null)
            {
                return inText;
            }

            return null;
        }

        private void btnAddtuning_Click(object sender, EventArgs e)
        {
            AddTuning addTuner = new AddTuning();
            addTuner.Show();
        }

        public event EventHandler OnAddSong;

        
    }
}
