namespace UI
{
    partial class PracticedSong
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbPracticeComment = new System.Windows.Forms.RichTextBox();
            this.btnLogPractice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a comment for this practice session";
            // 
            // rtbPracticeComment
            // 
            this.rtbPracticeComment.Location = new System.Drawing.Point(16, 43);
            this.rtbPracticeComment.Name = "rtbPracticeComment";
            this.rtbPracticeComment.Size = new System.Drawing.Size(256, 137);
            this.rtbPracticeComment.TabIndex = 1;
            this.rtbPracticeComment.Text = "";
            // 
            // btnLogPractice
            // 
            this.btnLogPractice.Location = new System.Drawing.Point(59, 186);
            this.btnLogPractice.Name = "btnLogPractice";
            this.btnLogPractice.Size = new System.Drawing.Size(168, 23);
            this.btnLogPractice.TabIndex = 2;
            this.btnLogPractice.Text = "Log Practice Session";
            this.btnLogPractice.UseVisualStyleBackColor = true;
            this.btnLogPractice.Click += new System.EventHandler(this.btnLogPractice_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(106, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PracticedSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 246);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogPractice);
            this.Controls.Add(this.rtbPracticeComment);
            this.Controls.Add(this.label1);
            this.Name = "PracticedSong";
            this.Text = "PracticedSong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbPracticeComment;
        private System.Windows.Forms.Button btnLogPractice;
        private System.Windows.Forms.Button btnClose;
    }
}