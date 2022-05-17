namespace CProject
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barRed = new System.Windows.Forms.TrackBar();
            this.barGreen = new System.Windows.Forms.TrackBar();
            this.barBlue = new System.Windows.Forms.TrackBar();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnDramatic = new System.Windows.Forms.Button();
            this.btnSepa = new System.Windows.Forms.Button();
            this.btnArtistic = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 399);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // barRed
            // 
            this.barRed.Location = new System.Drawing.Point(98, 466);
            this.barRed.Name = "barRed";
            this.barRed.Size = new System.Drawing.Size(588, 56);
            this.barRed.TabIndex = 1;
            this.barRed.Scroll += new System.EventHandler(this.barRed_Scroll);
            // 
            // barGreen
            // 
            this.barGreen.Location = new System.Drawing.Point(98, 511);
            this.barGreen.Name = "barGreen";
            this.barGreen.Size = new System.Drawing.Size(588, 56);
            this.barGreen.TabIndex = 2;
            this.barGreen.Scroll += new System.EventHandler(this.barGreen_Scroll);
            // 
            // barBlue
            // 
            this.barBlue.Location = new System.Drawing.Point(98, 554);
            this.barBlue.Name = "barBlue";
            this.barBlue.Size = new System.Drawing.Size(588, 56);
            this.barBlue.TabIndex = 3;
            this.barBlue.Scroll += new System.EventHandler(this.barBlue_Scroll);
            // 
            // btnNone
            // 
            this.btnNone.BackColor = System.Drawing.Color.Thistle;
            this.btnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNone.Location = new System.Drawing.Point(735, 56);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(170, 48);
            this.btnNone.TabIndex = 4;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = false;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnDramatic
            // 
            this.btnDramatic.BackColor = System.Drawing.Color.Thistle;
            this.btnDramatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDramatic.Location = new System.Drawing.Point(735, 272);
            this.btnDramatic.Name = "btnDramatic";
            this.btnDramatic.Size = new System.Drawing.Size(170, 48);
            this.btnDramatic.TabIndex = 5;
            this.btnDramatic.Text = "Dramatic";
            this.btnDramatic.UseVisualStyleBackColor = false;
            this.btnDramatic.Click += new System.EventHandler(this.btnDramatic_Click);
            // 
            // btnSepa
            // 
            this.btnSepa.BackColor = System.Drawing.Color.Thistle;
            this.btnSepa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepa.Location = new System.Drawing.Point(735, 218);
            this.btnSepa.Name = "btnSepa";
            this.btnSepa.Size = new System.Drawing.Size(170, 48);
            this.btnSepa.TabIndex = 6;
            this.btnSepa.Text = "Sepia";
            this.btnSepa.UseVisualStyleBackColor = false;
            this.btnSepa.Click += new System.EventHandler(this.btnSepa_Click);
            // 
            // btnArtistic
            // 
            this.btnArtistic.BackColor = System.Drawing.Color.Thistle;
            this.btnArtistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArtistic.Location = new System.Drawing.Point(735, 164);
            this.btnArtistic.Name = "btnArtistic";
            this.btnArtistic.Size = new System.Drawing.Size(170, 48);
            this.btnArtistic.TabIndex = 7;
            this.btnArtistic.Text = "Artistic";
            this.btnArtistic.UseVisualStyleBackColor = false;
            this.btnArtistic.Click += new System.EventHandler(this.btnArtistic_Click);
            // 
            // btnGray
            // 
            this.btnGray.BackColor = System.Drawing.Color.Thistle;
            this.btnGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGray.Location = new System.Drawing.Point(735, 110);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(170, 48);
            this.btnGray.TabIndex = 8;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = false;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // btnHash
            // 
            this.btnHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.Location = new System.Drawing.Point(1225, 14);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(159, 35);
            this.btnHash.TabIndex = 9;
            this.btnHash.Text = "Flash";
            this.btnHash.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Pink;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpen.Location = new System.Drawing.Point(731, 417);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(174, 72);
            this.btnOpen.TabIndex = 11;
            this.btnOpen.Text = "Open Photo";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(731, 495);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(174, 72);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Photo";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(30, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(30, 554);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(12, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(741, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "BROWSE PHOTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "CUSTOM ADJUST RGB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(777, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "FILTERS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(940, 604);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnArtistic);
            this.Controls.Add(this.btnSepa);
            this.Controls.Add(this.btnDramatic);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.barBlue);
            this.Controls.Add(this.barGreen);
            this.Controls.Add(this.barRed);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Photo Editor ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar barRed;
        private System.Windows.Forms.TrackBar barGreen;
        private System.Windows.Forms.TrackBar barBlue;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnDramatic;
        private System.Windows.Forms.Button btnSepa;
        private System.Windows.Forms.Button btnArtistic;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

