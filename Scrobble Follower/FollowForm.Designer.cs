namespace Scrobble_Follower
{
  partial class FollowForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FollowForm));
      this.userTextBox = new System.Windows.Forms.TextBox();
      this.track4 = new Scrobble_Follower.Track();
      this.track3 = new Scrobble_Follower.Track();
      this.track2 = new Scrobble_Follower.Track();
      this.track1 = new Scrobble_Follower.Track();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // userTextBox
      // 
      this.userTextBox.Location = new System.Drawing.Point(89, 12);
      this.userTextBox.Name = "userTextBox";
      this.userTextBox.Size = new System.Drawing.Size(292, 20);
      this.userTextBox.TabIndex = 0;
      this.userTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      this.userTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
      // 
      // track4
      // 
      this.track4.Location = new System.Drawing.Point(12, 356);
      this.track4.Name = "track4";
      this.track4.Size = new System.Drawing.Size(505, 100);
      this.track4.TabIndex = 5;
      // 
      // track3
      // 
      this.track3.Location = new System.Drawing.Point(12, 250);
      this.track3.Name = "track3";
      this.track3.Size = new System.Drawing.Size(505, 100);
      this.track3.TabIndex = 4;
      // 
      // track2
      // 
      this.track2.Location = new System.Drawing.Point(12, 144);
      this.track2.Name = "track2";
      this.track2.Size = new System.Drawing.Size(505, 100);
      this.track2.TabIndex = 3;
      // 
      // track1
      // 
      this.track1.Location = new System.Drawing.Point(12, 38);
      this.track1.Name = "track1";
      this.track1.Size = new System.Drawing.Size(505, 100);
      this.track1.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Last FM user:";
      // 
      // FollowForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(529, 461);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.track4);
      this.Controls.Add(this.track3);
      this.Controls.Add(this.track2);
      this.Controls.Add(this.track1);
      this.Controls.Add(this.userTextBox);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "FollowForm";
      this.Text = "Scrobble Follower";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox userTextBox;
    private Track track1;
    private Track track2;
    private Track track3;
    private Track track4;
    private System.Windows.Forms.Label label1;
  }
}

