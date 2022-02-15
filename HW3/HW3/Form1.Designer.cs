
namespace HW3
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
            this.BinaryPictureBox = new System.Windows.Forms.PictureBox();
            this.column1 = new System.Windows.Forms.Label();
            this.column2 = new System.Windows.Forms.Label();
            this.column3 = new System.Windows.Forms.Label();
            this.column4 = new System.Windows.Forms.Label();
            this.column5 = new System.Windows.Forms.Label();
            this.EmguPictureBox = new System.Windows.Forms.PictureBox();
            this.ThresholdTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.BinaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmguPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BinaryPictureBox
            // 
            this.BinaryPictureBox.Location = new System.Drawing.Point(401, 12);
            this.BinaryPictureBox.Name = "BinaryPictureBox";
            this.BinaryPictureBox.Size = new System.Drawing.Size(369, 336);
            this.BinaryPictureBox.TabIndex = 0;
            this.BinaryPictureBox.TabStop = false;

            // 
            // column1
            // 
            this.column1.AutoSize = true;
            this.column1.Location = new System.Drawing.Point(398, 351);
            this.column1.Name = "column1";
            this.column1.Size = new System.Drawing.Size(35, 13);
            this.column1.TabIndex = 1;
            this.column1.Text = "label1";
            // 
            // column2
            // 
            this.column2.AutoSize = true;
            this.column2.Location = new System.Drawing.Point(481, 351);
            this.column2.Name = "column2";
            this.column2.Size = new System.Drawing.Size(35, 13);
            this.column2.TabIndex = 2;
            this.column2.Text = "label2";
            // 
            // column3
            // 
            this.column3.AutoSize = true;
            this.column3.Location = new System.Drawing.Point(571, 351);
            this.column3.Name = "column3";
            this.column3.Size = new System.Drawing.Size(35, 13);
            this.column3.TabIndex = 3;
            this.column3.Text = "label3";
            // 
            // column4
            // 
            this.column4.AutoSize = true;
            this.column4.Location = new System.Drawing.Point(670, 351);
            this.column4.Name = "column4";
            this.column4.Size = new System.Drawing.Size(35, 13);
            this.column4.TabIndex = 4;
            this.column4.Text = "label4";
            // 
            // column5
            // 
            this.column5.AutoSize = true;
            this.column5.Location = new System.Drawing.Point(735, 351);
            this.column5.Name = "column5";
            this.column5.Size = new System.Drawing.Size(35, 13);
            this.column5.TabIndex = 5;
            this.column5.Text = "label5";
            // 
            // EmguPictureBox
            // 
            this.EmguPictureBox.Location = new System.Drawing.Point(12, 12);
            this.EmguPictureBox.Name = "EmguPictureBox";
            this.EmguPictureBox.Size = new System.Drawing.Size(352, 336);
            this.EmguPictureBox.TabIndex = 6;
            this.EmguPictureBox.TabStop = false;
            // 
            // ThresholdTrackBar
            // 
            this.ThresholdTrackBar.Location = new System.Drawing.Point(12, 393);
            this.ThresholdTrackBar.Maximum = 255;
            this.ThresholdTrackBar.Name = "ThresholdTrackBar";
            this.ThresholdTrackBar.Size = new System.Drawing.Size(776, 45);
            this.ThresholdTrackBar.TabIndex = 7;
            this.ThresholdTrackBar.Scroll += new System.EventHandler(this.ThresholdTrackBar_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThresholdTrackBar);
            this.Controls.Add(this.EmguPictureBox);
            this.Controls.Add(this.column5);
            this.Controls.Add(this.column4);
            this.Controls.Add(this.column3);
            this.Controls.Add(this.column2);
            this.Controls.Add(this.column1);
            this.Controls.Add(this.BinaryPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.BinaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmguPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BinaryPictureBox;
        private System.Windows.Forms.Label column1;
        private System.Windows.Forms.Label column2;
        private System.Windows.Forms.Label column3;
        private System.Windows.Forms.Label column4;
        private System.Windows.Forms.Label column5;
        private System.Windows.Forms.PictureBox EmguPictureBox;
        private System.Windows.Forms.TrackBar ThresholdTrackBar;
    }
}

