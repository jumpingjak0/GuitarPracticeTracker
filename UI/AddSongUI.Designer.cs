namespace UI
{
    partial class AddSongUI
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
            this.btnAddSong = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.cbTuning = new System.Windows.Forms.ComboBox();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddtuning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(97, 213);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 0;
            this.btnAddSong.Text = "Add Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(150, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(150, 70);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(100, 20);
            this.tbArtist.TabIndex = 3;
            // 
            // cbTuning
            // 
            this.cbTuning.FormattingEnabled = true;
            this.cbTuning.Location = new System.Drawing.Point(150, 110);
            this.cbTuning.Name = "cbTuning";
            this.cbTuning.Size = new System.Drawing.Size(121, 21);
            this.cbTuning.TabIndex = 4;
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Location = new System.Drawing.Point(150, 164);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cbDifficulty.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artist (Optional)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tuning (Optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Difficulty (Optional)";
            // 
            // btnAddtuning
            // 
            this.btnAddtuning.Location = new System.Drawing.Point(14, 116);
            this.btnAddtuning.Name = "btnAddtuning";
            this.btnAddtuning.Size = new System.Drawing.Size(111, 25);
            this.btnAddtuning.TabIndex = 10;
            this.btnAddtuning.Text = "Add New Tuning";
            this.btnAddtuning.UseVisualStyleBackColor = true;
            this.btnAddtuning.Click += new System.EventHandler(this.btnAddtuning_Click);
            // 
            // AddSongUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAddtuning);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.cbTuning);
            this.Controls.Add(this.tbArtist);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddSong);
            this.Name = "AddSongUI";
            this.Text = "Add Song";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.ComboBox cbTuning;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddtuning;
    }
}