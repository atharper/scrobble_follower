namespace Scrobble_Follower
{
  partial class Track
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.pictureBox = new System.Windows.Forms.PictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.albumLabel = new System.Windows.Forms.Label();
      this.artistLabel = new System.Windows.Forms.Label();
      this.trackLabel = new System.Windows.Forms.Label();
      this.timeLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox
      // 
      this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.pictureBox.Location = new System.Drawing.Point(0, 0);
      this.pictureBox.Name = "pictureBox";
      this.pictureBox.Size = new System.Drawing.Size(100, 92);
      this.pictureBox.TabIndex = 0;
      this.pictureBox.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label1.Location = new System.Drawing.Point(106, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Track:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label2.Location = new System.Drawing.Point(106, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Artist:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.label3.Location = new System.Drawing.Point(106, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 13);
      this.label3.TabIndex = 3;
      this.label3.Text = "Album:";
      // 
      // albumLabel
      // 
      this.albumLabel.AutoSize = true;
      this.albumLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.albumLabel.Location = new System.Drawing.Point(151, 32);
      this.albumLabel.Name = "albumLabel";
      this.albumLabel.Size = new System.Drawing.Size(46, 13);
      this.albumLabel.TabIndex = 6;
      this.albumLabel.Text = "             ";
      // 
      // artistLabel
      // 
      this.artistLabel.AutoSize = true;
      this.artistLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.artistLabel.Location = new System.Drawing.Point(151, 16);
      this.artistLabel.Name = "artistLabel";
      this.artistLabel.Size = new System.Drawing.Size(46, 13);
      this.artistLabel.TabIndex = 5;
      this.artistLabel.Text = "             ";
      // 
      // trackLabel
      // 
      this.trackLabel.AutoSize = true;
      this.trackLabel.ForeColor = System.Drawing.SystemColors.ControlText;
      this.trackLabel.Location = new System.Drawing.Point(151, 0);
      this.trackLabel.Name = "trackLabel";
      this.trackLabel.Size = new System.Drawing.Size(46, 13);
      this.trackLabel.TabIndex = 4;
      this.trackLabel.Text = "             ";
      // 
      // timeLabel
      // 
      this.timeLabel.AutoSize = true;
      this.timeLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
      this.timeLabel.Location = new System.Drawing.Point(106, 55);
      this.timeLabel.Name = "timeLabel";
      this.timeLabel.Size = new System.Drawing.Size(40, 13);
      this.timeLabel.TabIndex = 7;
      this.timeLabel.Text = "           ";
      // 
      // Track
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.timeLabel);
      this.Controls.Add(this.albumLabel);
      this.Controls.Add(this.artistLabel);
      this.Controls.Add(this.trackLabel);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pictureBox);
      this.Name = "Track";
      this.Size = new System.Drawing.Size(360, 100);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label albumLabel;
    private System.Windows.Forms.Label artistLabel;
    private System.Windows.Forms.Label trackLabel;
    private System.Windows.Forms.Label timeLabel;
  }
}
