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

    enum AddOrEdit
    {
        Add,
        Edit
    }
    public partial class AddSongUI : Form
    {
        AddOrEdit addOrEdit;
        Song songToEdit;
        GuitarPracticeTrackerUI mainUIForm;

        public AddSongUI(GuitarPracticeTrackerUI mainUI)
        {
            InitializeComponent();
            cbTuning.DataSource = Tunings.ListOfTunings;
            cbDifficulty.DataSource = Enum.GetValues(typeof(Difficulty));
            addOrEdit = AddOrEdit.Add;
            btnAddSong.Text = "Add Song";
            mainUIForm = mainUI;

        }

        public AddSongUI(GuitarPracticeTrackerUI mainUI, Song song)
        {
            InitializeComponent();
            tbArtist.Text = song.Artist;
            tbName.Text = song.Name;
            cbTuning.DataSource = Tunings.ListOfTunings;
            cbTuning.SelectedItem = Tunings.FindTuningByString(song.Tuning);
            cbDifficulty.DataSource = Enum.GetValues(typeof(Difficulty));
            cbDifficulty.SelectedItem = song.Difficulty;
            songToEdit = song;
            addOrEdit = AddOrEdit.Edit;
            btnAddSong.Text = "Edit Song";
            mainUIForm = mainUI;
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            string name = isTextValid(tbName.Text);
            string artist = isTextValid(tbArtist.Text);
            string tuning = (string)cbTuning.SelectedValue;
            Difficulty difficulty = (Difficulty)Enum.Parse(typeof(Difficulty), cbDifficulty.Text);

            switch(addOrEdit)
            {
                case AddOrEdit.Add:
                    {
                        SongList.AddNewSong(name, artist, tuning, difficulty);
                        break;
                    }
                case AddOrEdit.Edit:
                    {
                        songToEdit.Name = name;
                        songToEdit.Artist = artist;
                        songToEdit.Difficulty = difficulty;
                        songToEdit.Tuning = tuning;
                        break;
                    }
            }
            mainUIForm.UpdateSongList();
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
    }
}
