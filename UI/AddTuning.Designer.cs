namespace UI
{
    partial class AddTuning
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
            this.btnAddTuning = new System.Windows.Forms.Button();
            this.tbTuningName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddTuning
            // 
            this.btnAddTuning.Location = new System.Drawing.Point(12, 66);
            this.btnAddTuning.Name = "btnAddTuning";
            this.btnAddTuning.Size = new System.Drawing.Size(75, 23);
            this.btnAddTuning.TabIndex = 0;
            this.btnAddTuning.Text = "Add Tuning";
            this.btnAddTuning.UseVisualStyleBackColor = true;
            this.btnAddTuning.Click += new System.EventHandler(this.btnAddTuning_Click);
            // 
            // tbTuningName
            // 
            this.tbTuningName.Location = new System.Drawing.Point(40, 26);
            this.tbTuningName.Name = "tbTuningName";
            this.tbTuningName.Size = new System.Drawing.Size(100, 20);
            this.tbTuningName.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(94, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddTuning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 101);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbTuningName);
            this.Controls.Add(this.btnAddTuning);
            this.Name = "AddTuning";
            this.Text = "AddTuning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTuning;
        private System.Windows.Forms.TextBox tbTuningName;
        private System.Windows.Forms.Button btnClose;
    }
}