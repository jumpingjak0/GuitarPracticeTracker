﻿namespace UI
{
    partial class GuitarPracticeTrackerUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSongList = new System.Windows.Forms.DataGridView();
            this.pnlComments = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortArtist = new System.Windows.Forms.Button();
            this.btnSortTuning = new System.Windows.Forms.Button();
            this.btnSortLastTimePracticed = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnEditSong = new System.Windows.Forms.Button();
            this.btnPracticedSong = new System.Windows.Forms.Button();
            this.btnSortDifficulty = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSongList
            // 
            this.dgvSongList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSongList.Location = new System.Drawing.Point(26, 47);
            this.dgvSongList.Name = "dgvSongList";
            this.dgvSongList.Size = new System.Drawing.Size(280, 390);
            this.dgvSongList.TabIndex = 0;
            // 
            // pnlComments
            // 
            this.pnlComments.Location = new System.Drawing.Point(324, 47);
            this.pnlComments.Name = "pnlComments";
            this.pnlComments.Size = new System.Drawing.Size(317, 207);
            this.pnlComments.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Bar";
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(16, 25);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(75, 23);
            this.btnSortName.TabIndex = 4;
            this.btnSortName.Text = "Name";
            this.btnSortName.UseVisualStyleBackColor = true;
            // 
            // btnSortArtist
            // 
            this.btnSortArtist.Location = new System.Drawing.Point(16, 54);
            this.btnSortArtist.Name = "btnSortArtist";
            this.btnSortArtist.Size = new System.Drawing.Size(75, 23);
            this.btnSortArtist.TabIndex = 5;
            this.btnSortArtist.Text = "Artist";
            this.btnSortArtist.UseVisualStyleBackColor = true;
            // 
            // btnSortTuning
            // 
            this.btnSortTuning.Location = new System.Drawing.Point(16, 84);
            this.btnSortTuning.Name = "btnSortTuning";
            this.btnSortTuning.Size = new System.Drawing.Size(75, 23);
            this.btnSortTuning.TabIndex = 6;
            this.btnSortTuning.Text = "Tuning";
            this.btnSortTuning.UseVisualStyleBackColor = true;
            // 
            // btnSortLastTimePracticed
            // 
            this.btnSortLastTimePracticed.Location = new System.Drawing.Point(16, 114);
            this.btnSortLastTimePracticed.Name = "btnSortLastTimePracticed";
            this.btnSortLastTimePracticed.Size = new System.Drawing.Size(75, 40);
            this.btnSortLastTimePracticed.TabIndex = 7;
            this.btnSortLastTimePracticed.Text = "Last Practiced";
            this.btnSortLastTimePracticed.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSortDifficulty);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSortName);
            this.panel1.Controls.Add(this.btnSortLastTimePracticed);
            this.panel1.Controls.Add(this.btnSortArtist);
            this.panel1.Controls.Add(this.btnSortTuning);
            this.panel1.Location = new System.Drawing.Point(324, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 206);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sort By:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPracticedSong);
            this.panel2.Controls.Add(this.btnEditSong);
            this.panel2.Controls.Add(this.btnAddSong);
            this.panel2.Location = new System.Drawing.Point(434, 261);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 144);
            this.panel2.TabIndex = 9;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(4, 24);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            // 
            // btnEditSong
            // 
            this.btnEditSong.Location = new System.Drawing.Point(4, 54);
            this.btnEditSong.Name = "btnEditSong";
            this.btnEditSong.Size = new System.Drawing.Size(75, 23);
            this.btnEditSong.TabIndex = 1;
            this.btnEditSong.Text = "EditSong";
            this.btnEditSong.UseVisualStyleBackColor = true;
            // 
            // btnPracticedSong
            // 
            this.btnPracticedSong.Location = new System.Drawing.Point(4, 85);
            this.btnPracticedSong.Name = "btnPracticedSong";
            this.btnPracticedSong.Size = new System.Drawing.Size(75, 23);
            this.btnPracticedSong.TabIndex = 2;
            this.btnPracticedSong.Text = "Practiced";
            this.btnPracticedSong.UseVisualStyleBackColor = true;
            // 
            // btnSortDifficulty
            // 
            this.btnSortDifficulty.Location = new System.Drawing.Point(16, 161);
            this.btnSortDifficulty.Name = "btnSortDifficulty";
            this.btnSortDifficulty.Size = new System.Drawing.Size(75, 23);
            this.btnSortDifficulty.TabIndex = 9;
            this.btnSortDifficulty.Text = "Difficulty";
            this.btnSortDifficulty.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(26, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(280, 33);
            this.panel3.TabIndex = 10;
            // 
            // GuitarPracticeTrackerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlComments);
            this.Controls.Add(this.dgvSongList);
            this.Name = "GuitarPracticeTrackerUI";
            this.Text = "Guitar Practive Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSongList;
        private System.Windows.Forms.Panel pnlComments;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortArtist;
        private System.Windows.Forms.Button btnSortTuning;
        private System.Windows.Forms.Button btnSortLastTimePracticed;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPracticedSong;
        private System.Windows.Forms.Button btnEditSong;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnSortDifficulty;
        private System.Windows.Forms.Panel panel3;
    }
}
