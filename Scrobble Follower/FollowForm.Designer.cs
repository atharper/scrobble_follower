namespace Scrobble_Follower
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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.track4 = new Scrobble_Follower.Track();
      this.track3 = new Scrobble_Follower.Track();
      this.track2 = new Scrobble_Follower.Track();
      this.track1 = new Scrobble_Follower.Track();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(292, 20);
      this.textBox1.TabIndex = 0;
      this.textBox1.Text = "katacalysmic";
      this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
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
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Window;
      this.ClientSize = new System.Drawing.Size(529, 461);
      this.Controls.Add(this.track4);
      this.Controls.Add(this.track3);
      this.Controls.Add(this.track2);
      this.Controls.Add(this.track1);
      this.Controls.Add(this.textBox1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Scrobble Follower";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private Track track1;
    private Track track2;
    private Track track3;
    private Track track4;
  }
}

