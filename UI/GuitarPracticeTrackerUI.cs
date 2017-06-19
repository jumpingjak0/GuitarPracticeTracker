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


        public void UpdateUIDisplay()
        {
            
            dgvSongList.DataSource = SongList.ListOfSongs;
            dgvSongList.Refresh();

            pnlComments.Controls.Clear();

            

            RichTextBox lastAdded = null;
            int commentNumber = 0;
            Song commentsToDisplay = FindSongFromSelectedDgvRow();
            foreach(string comment in commentsToDisplay.Comments)
            {
                RichTextBox newComment = new RichTextBox();
                newComment.Text = comment;
                Point location = new Point();
                location.X = 10;
                location.Y = commentNumber * 50 + 5;
                newComment.Location = location;
                newComment.Width = 350;
                newComment.Height = 50;
                pnlComments.Controls.Add(newComment);
                commentNumber++;
                lastAdded = newComment;

            }

            pnlComments.AutoScroll = false;
            pnlComments.AutoScroll = true;
            try
            {
                pnlComments.ScrollControlIntoView(lastAdded);
            }
            catch
            { }
            
            
        }

        private void GuitarPracticeTrackerUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMethods.SavesToXML();
        }

        private void btnEditSong_Click(object sender, EventArgs e)
        { 
            
            Song songToEdit = FindSongFromSelectedDgvRow();
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
         
            Song songToDelete = FindSongFromSelectedDgvRow();
            DeleteSong deleteSong = new DeleteSong(songToDelete);
            deleteSong.StartPosition = FormStartPosition.CenterParent;
            deleteSong.Show();
        }

        private void btnPracticedSong_Click(object sender, EventArgs e)
        {
            Song songToPractice = FindSongFromSelectedDgvRow();
            PracticedSong form = new PracticedSong(songToPractice, this);
            form.Show();
        }

        private Song FindSongFromSelectedDgvRow()
        {
                string songID = dgvSongList.CurrentCell.OwningRow.Cells[0].Value.ToString();
                int songIDint = Int32.Parse(songID);
                Song songtoReturn = SongList.FindSongByID(songIDint);
                return songtoReturn;
            
        }

        private void GuitarPracticeTrackerUI_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSongList.CurrentCellChanged -= dgvSongList_CurrentCellChanged;
                UpdateUIDisplay();
                dgvSongList.CurrentCellChanged += dgvSongList_CurrentCellChanged;
            }
            catch
            {
                dgvSongList.CurrentCellChanged += dgvSongList_CurrentCellChanged;
                return;
            }
        }


        private void dgvSongList_CurrentCellChanged(object sender, EventArgs e)
        {
            UpdateUIDisplay();

        }
    }
}
