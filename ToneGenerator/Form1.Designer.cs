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
            this.volumePictureBox = new System.Windows.Forms.PictureBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.prevNoteButton = new System.Windows.Forms.Button();
            this.nextNoteButton = new System.Windows.Forms.Button();
            this.prevOctaveButton = new System.Windows.Forms.Button();
            this.nextOctaveButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.CheckBox();
            this.linearVolumeSlider = new System.Windows.Forms.TrackBar();
            this.frequencyNumeric = new System.Windows.Forms.NumericUpDown();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.leftCheckBox = new System.Windows.Forms.CheckBox();
            this.rightCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.minusButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.dBVolumeSlider = new ToneGenerator.VolumeSlider();
            ((System.ComponentModel.ISupportInitialize)(this.volumePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearVolumeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // volumePictureBox
            // 
            this.volumePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("volumePictureBox.Image")));
            this.volumePictureBox.Location = new System.Drawing.Point(15, 47);
            this.volumePictureBox.Name = "volumePictureBox";
            this.volumePictureBox.Size = new System.Drawing.Size(16, 16);
            this.volumePictureBox.TabIndex = 0;
            this.volumePictureBox.TabStop = false;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(12, 14);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(65, 15);
            this.frequencyLabel.TabIndex = 0;
            this.frequencyLabel.Text = "&Frequency:";
            // 
            // prevNoteButton
            // 
            this.prevNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevNoteButton.Location = new System.Drawing.Point(217, 12);
            this.prevNoteButton.Name = "prevNoteButton";
            this.prevNoteButton.Size = new System.Drawing.Size(23, 23);
            this.prevNoteButton.TabIndex = 4;
            this.prevNoteButton.Text = "<";
            this.toolTip.SetToolTip(this.prevNoteButton, "Go down a semitone");
            this.prevNoteButton.UseVisualStyleBackColor = true;
            this.prevNoteButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // nextNoteButton
            // 
            this.nextNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextNoteButton.Location = new System.Drawing.Point(240, 12);
            this.nextNoteButton.Name = "nextNoteButton";
            this.nextNoteButton.Size = new System.Drawing.Size(23, 23);
            this.nextNoteButton.TabIndex = 5;
            this.nextNoteButton.Text = ">";
            this.toolTip.SetToolTip(this.nextNoteButton, "Go up a semitone");
            this.nextNoteButton.UseVisualStyleBackColor = true;
            this.nextNoteButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // prevOctaveButton
            // 
            this.prevOctaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevOctaveButton.Location = new System.Drawing.Point(272, 12);
            this.prevOctaveButton.Name = "prevOctaveButton";
            this.prevOctaveButton.Size = new System.Drawing.Size(23, 23);
            this.prevOctaveButton.TabIndex = 6;
            this.prevOctaveButton.Text = "<<";
            this.toolTip.SetToolTip(this.prevOctaveButton, "Go down an octave");
            this.prevOctaveButton.UseVisualStyleBackColor = true;
            this.prevOctaveButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // nextOctaveButton
            // 
            this.nextOctaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextOctaveButton.Location = new System.Drawing.Point(295, 12);
            this.nextOctaveButton.Name = "nextOctaveButton";
            this.nextOctaveButton.Size = new System.Drawing.Size(23, 23);
            this.nextOctaveButton.TabIndex = 7;
            this.nextOctaveButton.Text = ">>";
            this.toolTip.SetToolTip(this.nextOctaveButton, "Go up an octave");
            this.nextOctaveButton.UseVisualStyleBackColor = true;
            this.nextOctaveButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playButton.Location = new System.Drawing.Point(243, 45);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 9;
            this.playButton.Text = "&Play";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.CheckedChanged += new System.EventHandler(this.playButton_CheckedChanged);
            // 
            // linearVolumeSlider
            // 
            this.linearVolumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linearVolumeSlider.AutoSize = false;
            this.linearVolumeSlider.Location = new System.Drawing.Point(31, 45);
            this.linearVolumeSlider.Maximum = 1000;
            this.linearVolumeSlider.Name = "linearVolumeSlider";
            this.linearVolumeSlider.Size = new System.Drawing.Size(206, 23);
            this.linearVolumeSlider.TabIndex = 8;
            this.linearVolumeSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip.SetToolTip(this.linearVolumeSlider, "Controls the volume on a linear scale.");
            this.linearVolumeSlider.Value = 250;
            this.linearVolumeSlider.Scroll += new System.EventHandler(this.linearVolumeSlider_Scroll);
            // 
            // frequencyNumeric
            // 
            this.frequencyNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyNumeric.DecimalPlaces = 2;
            this.frequencyNumeric.Location = new System.Drawing.Point(83, 12);
            this.frequencyNumeric.Maximum = new decimal(new int[] {
            44100,
            0,
            0,
            0});
            this.frequencyNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frequencyNumeric.Name = "frequencyNumeric";
            this.frequencyNumeric.Size = new System.Drawing.Size(73, 23);
            this.frequencyNumeric.TabIndex = 1;
            this.frequencyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequencyNumeric.Value = new decimal(new int[] {
            440,
            0,
            0,
            0});
            this.frequencyNumeric.ValueChanged += new System.EventHandler(this.frequencyNumeric_ValueChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(12, 76);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(75, 15);
            this.volumeLabel.TabIndex = 10;
            this.volumeLabel.Text = "Volume: 0.25";
            // 
            // leftCheckBox
            // 
            this.leftCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftCheckBox.AutoSize = true;
            this.leftCheckBox.Checked = true;
            this.leftCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.leftCheckBox.Location = new System.Drawing.Point(200, 74);
            this.leftCheckBox.Name = "leftCheckBox";
            this.leftCheckBox.Size = new System.Drawing.Size(52, 20);
            this.leftCheckBox.TabIndex = 11;
            this.leftCheckBox.Text = "&Left";
            this.leftCheckBox.UseVisualStyleBackColor = true;
            this.leftCheckBox.CheckedChanged += new System.EventHandler(this.leftCheckBox_CheckedChanged);
            // 
            // rightCheckBox
            // 
            this.rightCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightCheckBox.AutoSize = true;
            this.rightCheckBox.Checked = true;
            this.rightCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rightCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rightCheckBox.Location = new System.Drawing.Point(258, 74);
            this.rightCheckBox.Name = "rightCheckBox";
            this.rightCheckBox.Size = new System.Drawing.Size(60, 20);
            this.rightCheckBox.TabIndex = 12;
            this.rightCheckBox.Text = "&Right";
            this.rightCheckBox.UseVisualStyleBackColor = true;
            this.rightCheckBox.CheckedChanged += new System.EventHandler(this.rightCheckBox_CheckedChanged);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minusButton.Location = new System.Drawing.Point(162, 12);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(23, 23);
            this.minusButton.TabIndex = 2;
            this.minusButton.Text = "-";
            this.toolTip.SetToolTip(this.minusButton, "Go down 50 cents");
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plusButton.Location = new System.Drawing.Point(185, 12);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(23, 23);
            this.plusButton.TabIndex = 3;
            this.plusButton.Text = "+";
            this.toolTip.SetToolTip(this.plusButton, "Go up 50 cents");
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // dBVolumeSlider
            // 
            this.dBVolumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dBVolumeSlider.Location = new System.Drawing.Point(12, 100);
            this.dBVolumeSlider.Name = "dBVolumeSlider";
            this.dBVolumeSlider.Size = new System.Drawing.Size(306, 16);
            this.dBVolumeSlider.TabIndex = 13;
            this.toolTip.SetToolTip(this.dBVolumeSlider, "Controls the volume on a logarithmic scale.");
            this.dBVolumeSlider.Volume = 0.25F;
            this.dBVolumeSlider.VolumeChanged += new System.EventHandler(this.dBVolumeSlider_VolumeChanged);
            this.dBVolumeSlider.Resize += new System.EventHandler(this.dBVolumeSlider_Resize);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(330, 126);
            this.Controls.Add(this.dBVolumeSlider);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.rightCheckBox);
            this.Controls.Add(this.leftCheckBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.nextOctaveButton);
            this.Controls.Add(this.prevOctaveButton);
            this.Controls.Add(this.nextNoteButton);
            this.Controls.Add(this.prevNoteButton);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.frequencyNumeric);
            this.Controls.Add(this.linearVolumeSlider);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.volumePictureBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(346, 164);
            this.Name = "Form1";
            this.Text = "Tone Generator";
            ((System.ComponentModel.ISupportInitialize)(this.volumePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearVolumeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox playButton;
		private System.Windows.Forms.TrackBar linearVolumeSlider;
		private System.Windows.Forms.NumericUpDown frequencyNumeric;
		private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.CheckBox leftCheckBox;
        private System.Windows.Forms.CheckBox rightCheckBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button prevNoteButton;
        private System.Windows.Forms.Button nextNoteButton;
        private System.Windows.Forms.Button prevOctaveButton;
        private System.Windows.Forms.Button nextOctaveButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private VolumeSlider dBVolumeSlider;
        private System.Windows.Forms.PictureBox volumePictureBox;
        private System.Windows.Forms.Label frequencyLabel;
	}
}

