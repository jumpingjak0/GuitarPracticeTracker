namespace UI
{
    partial class DeleteSong
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
            this.btnKeepSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.rtbDeleteSongWarning = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnKeepSong
            // 
            this.btnKeepSong.Location = new System.Drawing.Point(12, 112);
            this.btnKeepSong.Name = "btnKeepSong";
            this.btnKeepSong.Size = new System.Drawing.Size(75, 23);
            this.btnKeepSong.TabIndex = 0;
            this.btnKeepSong.Text = "Keep Song";
            this.btnKeepSong.UseVisualStyleBackColor = true;
            this.btnKeepSong.Click += new System.EventHandler(this.btnKeepSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Location = new System.Drawing.Point(146, 112);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSong.TabIndex = 1;
            this.btnDeleteSong.Text = "Delete Song";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // rtbDeleteSongWarning
            // 
            this.rtbDeleteSongWarning.Location = new System.Drawing.Point(15, 12);
            this.rtbDeleteSongWarning.Name = "rtbDeleteSongWarning";
            this.rtbDeleteSongWarning.ReadOnly = true;
            this.rtbDeleteSongWarning.Size = new System.Drawing.Size(206, 75);
            this.rtbDeleteSongWarning.TabIndex = 3;
            this.rtbDeleteSongWarning.Text = "";
            // 
            // DeleteSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 159);
            this.Controls.Add(this.rtbDeleteSongWarning);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnKeepSong);
            this.Name = "DeleteSong";
            this.Text = "DeleteSong";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKeepSong;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.RichTextBox rtbDeleteSongWarning;
    }
}