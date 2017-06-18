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
    public partial class GuitarPracticeTrackerUI : Form
    {
        public GuitarPracticeTrackerUI()
        {
            InitializeComponent();
            

            Song tempSong = new Song("Nothing Else Matters", 0, "Metallica", "Standard", Difficulty.Easy);
            SongList.ListOfSongs.Add(tempSong);
            dgvSongList.DataSource = SongList.ListOfSongs;

            dgvSongList.RowHeadersVisible = false;
            dgvSongList.AutoGenerateColumns = false;
            dgvSongList.Columns.Clear();

            dgvSongList.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Visible = false,
                DataPropertyName = "ID"
            });

            dgvSongList.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Name",
                Width = 150,
                DataPropertyName = "Name"
            });
            dgvSongList.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Artist",
                Width = 150,
                DataPropertyName = "Artist"
            });
            dgvSongList.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tuning",
                Width = 100,
                DataPropertyName = "Tuning"
            });
            dgvSongList.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Difficulty",
                Width = 97,
                DataPropertyName = "Difficulty"
            });
            dgvSongList.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Last Practiced",
                Width = 100,
                DataPropertyName = "DateTimeLastPracticed"
            });

            
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            AddSongUI addSong = new AddSongUI(this);
            addSong.Show();
        }

        public void UpdateSongList()
        {
            
            dgvSongList.DataSource = SongList.ListOfSongs;
            dgvSongList.Refresh();
        }

        private void GuitarPracticeTrackerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMethods.SavesToXML();
        }

        private void btnEditSong_Click(object sender, EventArgs e)
        { 
            string songID = dgvSongList.CurrentRow.Cells[0].Value.ToString();
            int songIDint = Int32.Parse(songID);
            Song tempSong = SongList.FindSongByID(songIDint);
            AddSongUI editSong = new AddSongUI(this, tempSong);
            editSong.Show();
        }
    }
}
