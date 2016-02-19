namespace MonthlyCalander
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelJournalFor = new System.Windows.Forms.Label();
            this.buttonSaveRecord = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(7, 8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // labelJournalFor
            // 
            this.labelJournalFor.AutoSize = true;
            this.labelJournalFor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelJournalFor.Location = new System.Drawing.Point(246, 9);
            this.labelJournalFor.Name = "labelJournalFor";
            this.labelJournalFor.Size = new System.Drawing.Size(56, 13);
            this.labelJournalFor.TabIndex = 2;
            this.labelJournalFor.Text = "Journal for";
            // 
            // buttonSaveRecord
            // 
            this.buttonSaveRecord.Location = new System.Drawing.Point(508, 4);
            this.buttonSaveRecord.Name = "buttonSaveRecord";
            this.buttonSaveRecord.Size = new System.Drawing.Size(86, 23);
            this.buttonSaveRecord.TabIndex = 3;
            this.buttonSaveRecord.Text = "Save Record";
            this.buttonSaveRecord.UseVisualStyleBackColor = true;
            this.buttonSaveRecord.Click += new System.EventHandler(this.buttonSaveRecord_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelDate.Location = new System.Drawing.Point(308, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 13);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "label1";
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxNotes.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxNotes.Location = new System.Drawing.Point(246, 34);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNotes.Size = new System.Drawing.Size(348, 328);
            this.textBoxNotes.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MonthlyCalander.Properties.Resources.calendar1;
            this.pictureBox1.Location = new System.Drawing.Point(50, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 129);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(603, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxNotes);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonSaveRecord);
            this.Controls.Add(this.labelJournalFor);
            this.Controls.Add(this.monthCalendar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Journal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelJournalFor;
        private System.Windows.Forms.Button buttonSaveRecord;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

