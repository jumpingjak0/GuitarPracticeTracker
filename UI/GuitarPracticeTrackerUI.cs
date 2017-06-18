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
            dgvSongList.DataSource = SongList.ListOfSongs;

            SongList.PropertyChanged += UpdateSongList;
            dgvSongList.RowHeadersVisible = false;
            dgvSongList.AutoGenerateColumns = false;
            dgvSongList.Columns.Clear();

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
            AddSongUI addSong = new AddSongUI();
            addSong.Show();
        }

        public void UpdateSongList(object sender, PropertyChangedEventArgs e)
        {
            dgvSongList.DataSource = SongList.ListOfSongs;
        }

    }
}
