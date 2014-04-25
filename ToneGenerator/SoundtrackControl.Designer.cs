namespace ToneGenerator
{
    partial class SoundtrackControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoundtrackControl));
            this.rightCheckBox = new System.Windows.Forms.CheckBox();
            this.leftCheckBox = new System.Windows.Forms.CheckBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.nextOctaveButton = new System.Windows.Forms.Button();
            this.prevOctaveButton = new System.Windows.Forms.Button();
            this.nextNoteButton = new System.Windows.Forms.Button();
            this.prevNoteButton = new System.Windows.Forms.Button();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.frequencyNumeric = new System.Windows.Forms.NumericUpDown();
            this.volumePictureBox = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.dBVolumeSlider = new ToneGenerator.VolumeSlider();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // rightCheckBox
            // 
            this.rightCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightCheckBox.AutoSize = true;
            this.rightCheckBox.Checked = true;
            this.rightCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rightCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rightCheckBox.Location = new System.Drawing.Point(272, 67);
            this.rightCheckBox.Name = "rightCheckBox";
            this.rightCheckBox.Size = new System.Drawing.Size(60, 20);
            this.rightCheckBox.TabIndex = 26;
            this.rightCheckBox.Text = "&Right";
            this.rightCheckBox.UseVisualStyleBackColor = true;
            this.rightCheckBox.CheckedChanged += new System.EventHandler(this.rightCheckBox_CheckedChanged);
            // 
            // leftCheckBox
            // 
            this.leftCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftCheckBox.AutoSize = true;
            this.leftCheckBox.Checked = true;
            this.leftCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.leftCheckBox.Location = new System.Drawing.Point(214, 67);
            this.leftCheckBox.Name = "leftCheckBox";
            this.leftCheckBox.Size = new System.Drawing.Size(52, 20);
            this.leftCheckBox.TabIndex = 25;
            this.leftCheckBox.Text = "&Left";
            this.leftCheckBox.UseVisualStyleBackColor = true;
            this.leftCheckBox.CheckedChanged += new System.EventHandler(this.leftCheckBox_CheckedChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(11, 69);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(90, 15);
            this.volumeLabel.TabIndex = 24;
            this.volumeLabel.Text = "Amplitude: 0.25";
            // 
            // nextOctaveButton
            // 
            this.nextOctaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextOctaveButton.Location = new System.Drawing.Point(309, 9);
            this.nextOctaveButton.Name = "nextOctaveButton";
            this.nextOctaveButton.Size = new System.Drawing.Size(23, 23);
            this.nextOctaveButton.TabIndex = 22;
            this.nextOctaveButton.Text = ">>";
            this.toolTip.SetToolTip(this.nextOctaveButton, "Go up an octave");
            this.nextOctaveButton.UseVisualStyleBackColor = true;
            this.nextOctaveButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // prevOctaveButton
            // 
            this.prevOctaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevOctaveButton.Location = new System.Drawing.Point(286, 9);
            this.prevOctaveButton.Name = "prevOctaveButton";
            this.prevOctaveButton.Size = new System.Drawing.Size(23, 23);
            this.prevOctaveButton.TabIndex = 21;
            this.prevOctaveButton.Text = "<<";
            this.toolTip.SetToolTip(this.prevOctaveButton, "Go down an octave");
            this.prevOctaveButton.UseVisualStyleBackColor = true;
            this.prevOctaveButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // nextNoteButton
            // 
            this.nextNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextNoteButton.Location = new System.Drawing.Point(254, 9);
            this.nextNoteButton.Name = "nextNoteButton";
            this.nextNoteButton.Size = new System.Drawing.Size(23, 23);
            this.nextNoteButton.TabIndex = 20;
            this.nextNoteButton.Text = ">";
            this.toolTip.SetToolTip(this.nextNoteButton, "Go up a semitone");
            this.nextNoteButton.UseVisualStyleBackColor = true;
            this.nextNoteButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // prevNoteButton
            // 
            this.prevNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevNoteButton.Location = new System.Drawing.Point(231, 9);
            this.prevNoteButton.Name = "prevNoteButton";
            this.prevNoteButton.Size = new System.Drawing.Size(23, 23);
            this.prevNoteButton.TabIndex = 19;
            this.prevNoteButton.Text = "<";
            this.toolTip.SetToolTip(this.prevNoteButton, "Go down a semitone");
            this.prevNoteButton.UseVisualStyleBackColor = true;
            this.prevNoteButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(11, 11);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(65, 15);
            this.frequencyLabel.TabIndex = 14;
            this.frequencyLabel.Text = "&Frequency:";
            // 
            // frequencyNumeric
            // 
            this.frequencyNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyNumeric.DecimalPlaces = 2;
            this.frequencyNumeric.Location = new System.Drawing.Point(82, 9);
            this.frequencyNumeric.Maximum = new decimal(new int[] {
            24000,
            0,
            0,
            0});
            this.frequencyNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frequencyNumeric.Name = "frequencyNumeric";
            this.frequencyNumeric.Size = new System.Drawing.Size(88, 23);
            this.frequencyNumeric.TabIndex = 16;
            this.frequencyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequencyNumeric.Value = new decimal(new int[] {
            440,
            0,
            0,
            0});
            this.frequencyNumeric.ValueChanged += new System.EventHandler(this.frequencyNumeric_ValueChanged);
            // 
            // volumePictureBox
            // 
            this.volumePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("volumePictureBox.Image")));
            this.volumePictureBox.Location = new System.Drawing.Point(14, 42);
            this.volumePictureBox.Name = "volumePictureBox";
            this.volumePictureBox.Size = new System.Drawing.Size(16, 16);
            this.volumePictureBox.TabIndex = 15;
            this.volumePictureBox.TabStop = false;
            // 
            // plusButton
            // 
            this.plusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plusButton.Location = new System.Drawing.Point(199, 9);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(23, 23);
            this.plusButton.TabIndex = 18;
            this.plusButton.Text = "+";
            this.toolTip.SetToolTip(this.plusButton, "Go up 50 cents");
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minusButton.Location = new System.Drawing.Point(176, 9);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(23, 23);
            this.minusButton.TabIndex = 17;
            this.minusButton.Text = "-";
            this.toolTip.SetToolTip(this.minusButton, "Go down 50 cents");
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.changeFrequencyButtons_Click);
            // 
            // dBVolumeSlider
            // 
            this.dBVolumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dBVolumeSlider.Location = new System.Drawing.Point(36, 42);
            this.dBVolumeSlider.Name = "dBVolumeSlider";
            this.dBVolumeSlider.Size = new System.Drawing.Size(296, 16);
            this.dBVolumeSlider.TabIndex = 27;
            this.toolTip.SetToolTip(this.dBVolumeSlider, "Controls the volume on a logarithmic scale.");
            this.dBVolumeSlider.Volume = 0.25F;
            this.dBVolumeSlider.VolumeChanged += new System.EventHandler(this.dBVolumeSlider_VolumeChanged);
            // 
            // SoundtrackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rightCheckBox);
            this.Controls.Add(this.leftCheckBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.nextOctaveButton);
            this.Controls.Add(this.prevOctaveButton);
            this.Controls.Add(this.nextNoteButton);
            this.Controls.Add(this.prevNoteButton);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.frequencyNumeric);
            this.Controls.Add(this.volumePictureBox);
            this.Controls.Add(this.dBVolumeSlider);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.minusButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "SoundtrackControl";
            this.Size = new System.Drawing.Size(340, 95);
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox rightCheckBox;
        private System.Windows.Forms.CheckBox leftCheckBox;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.Button nextOctaveButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button prevOctaveButton;
        private System.Windows.Forms.Button nextNoteButton;
        private System.Windows.Forms.Button prevNoteButton;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.NumericUpDown frequencyNumeric;
        private System.Windows.Forms.PictureBox volumePictureBox;
        private VolumeSlider dBVolumeSlider;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
    }
}
