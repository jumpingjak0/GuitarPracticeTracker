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
            LoadMethods.loadSavedSongsFromXML();

            UpdateDgvSongList();
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
                DataPropertyName = "LastPracticedMessage"
            });

            
        }


        public void UpdateDgvSongList()
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
            Song songToEdit = SongList.FindSongByID(songIDint);
            AddSongUI editSong = new AddSongUI(this, songToEdit);
            editSong.StartPosition = FormStartPosition.CenterParent;
            editSong.Show();
        }
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            AddSongUI addSong = new AddSongUI(this);
            addSong.StartPosition = FormStartPosition.CenterParent;
            addSong.Show();
        }
        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            string songID = dgvSongList.CurrentRow.Cells[0].Value.ToString();
            int songIDint = Int32.Parse(songID);
            Song songToDelete = SongList.FindSongByID(songIDint);
            DeleteSong deleteSong = new DeleteSong(songToDelete);
            deleteSong.StartPosition = FormStartPosition.CenterParent;
            deleteSong.Show();
        }
    }
}
