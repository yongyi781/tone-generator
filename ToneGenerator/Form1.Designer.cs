namespace ToneGenerator
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
			if (disposing)
			{
				if (waveOut != null)
					waveOut.Dispose();
				if (components != null)
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.playButton = new System.Windows.Forms.CheckBox();
            this.soundtrackControl2 = new ToneGenerator.SoundtrackControl();
            this.soundtrackControl1 = new ToneGenerator.SoundtrackControl();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playButton.Location = new System.Drawing.Point(243, 188);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 15;
            this.playButton.Text = "&Play";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.CheckedChanged += new System.EventHandler(this.playButton_CheckedChanged);
            // 
            // soundtrackControl2
            // 
            this.soundtrackControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundtrackControl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soundtrackControl2.Location = new System.Drawing.Point(12, 98);
            this.soundtrackControl2.Name = "soundtrackControl2";
            this.soundtrackControl2.Size = new System.Drawing.Size(306, 80);
            this.soundtrackControl2.TabIndex = 16;
            // 
            // soundtrackControl1
            // 
            this.soundtrackControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.soundtrackControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soundtrackControl1.Location = new System.Drawing.Point(12, 12);
            this.soundtrackControl1.Name = "soundtrackControl1";
            this.soundtrackControl1.Size = new System.Drawing.Size(306, 80);
            this.soundtrackControl1.TabIndex = 14;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(330, 223);
            this.Controls.Add(this.soundtrackControl2);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.soundtrackControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(346, 164);
            this.Name = "Form1";
            this.Text = "Tone Generator";
            this.ResumeLayout(false);

		}

		#endregion
        private System.Windows.Forms.ToolTip toolTip;
        private SoundtrackControl soundtrackControl1;
        private System.Windows.Forms.CheckBox playButton;
        private SoundtrackControl soundtrackControl2;
    }
}

