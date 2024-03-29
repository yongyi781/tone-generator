﻿using System;

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
            this.dBVolumeSlider = new ToneGenerator.VolumeSlider();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.plus2Button = new System.Windows.Forms.Button();
            this.minus2Button = new System.Windows.Forms.Button();
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
            this.rightCheckBox.Location = new System.Drawing.Point(550, 100);
            this.rightCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightCheckBox.Name = "rightCheckBox";
            this.rightCheckBox.Size = new System.Drawing.Size(72, 25);
            this.rightCheckBox.TabIndex = 26;
            this.rightCheckBox.Text = "&Right";
            this.rightCheckBox.UseVisualStyleBackColor = true;
            this.rightCheckBox.CheckedChanged += new System.EventHandler(this.RightCheckBox_CheckedChanged);
            // 
            // leftCheckBox
            // 
            this.leftCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftCheckBox.AutoSize = true;
            this.leftCheckBox.Checked = true;
            this.leftCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.leftCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.leftCheckBox.Location = new System.Drawing.Point(462, 100);
            this.leftCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftCheckBox.Name = "leftCheckBox";
            this.leftCheckBox.Size = new System.Drawing.Size(62, 25);
            this.leftCheckBox.TabIndex = 25;
            this.leftCheckBox.Text = "&Left";
            this.leftCheckBox.UseVisualStyleBackColor = true;
            this.leftCheckBox.CheckedChanged += new System.EventHandler(this.LeftCheckBox_CheckedChanged);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(16, 104);
            this.volumeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(119, 20);
            this.volumeLabel.TabIndex = 24;
            this.volumeLabel.Text = "Amplitude: 0.25";
            // 
            // nextOctaveButton
            // 
            this.nextOctaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextOctaveButton.Location = new System.Drawing.Point(582, 10);
            this.nextOctaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextOctaveButton.Name = "nextOctaveButton";
            this.nextOctaveButton.Size = new System.Drawing.Size(40, 34);
            this.nextOctaveButton.TabIndex = 22;
            this.nextOctaveButton.Text = "x2";
            this.nextOctaveButton.UseVisualStyleBackColor = true;
            this.nextOctaveButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // prevOctaveButton
            // 
            this.prevOctaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevOctaveButton.Location = new System.Drawing.Point(537, 10);
            this.prevOctaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prevOctaveButton.Name = "prevOctaveButton";
            this.prevOctaveButton.Size = new System.Drawing.Size(40, 34);
            this.prevOctaveButton.TabIndex = 21;
            this.prevOctaveButton.Text = "/2";
            this.prevOctaveButton.UseVisualStyleBackColor = true;
            this.prevOctaveButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // nextNoteButton
            // 
            this.nextNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextNoteButton.Location = new System.Drawing.Point(393, 10);
            this.nextNoteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextNoteButton.Name = "nextNoteButton";
            this.nextNoteButton.Size = new System.Drawing.Size(40, 34);
            this.nextNoteButton.TabIndex = 20;
            this.nextNoteButton.Text = "+1";
            this.nextNoteButton.UseVisualStyleBackColor = true;
            this.nextNoteButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // prevNoteButton
            // 
            this.prevNoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.prevNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevNoteButton.Location = new System.Drawing.Point(348, 10);
            this.prevNoteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prevNoteButton.Name = "prevNoteButton";
            this.prevNoteButton.Size = new System.Drawing.Size(40, 34);
            this.prevNoteButton.TabIndex = 19;
            this.prevNoteButton.Text = "-1";
            this.prevNoteButton.UseVisualStyleBackColor = true;
            this.prevNoteButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(16, 16);
            this.frequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(88, 20);
            this.frequencyLabel.TabIndex = 14;
            this.frequencyLabel.Text = "&Frequency:";
            // 
            // frequencyNumeric
            // 
            this.frequencyNumeric.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyNumeric.DecimalPlaces = 2;
            this.frequencyNumeric.Location = new System.Drawing.Point(123, 14);
            this.frequencyNumeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.frequencyNumeric.Size = new System.Drawing.Size(122, 26);
            this.frequencyNumeric.TabIndex = 16;
            this.frequencyNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequencyNumeric.Value = new decimal(new int[] {
            440,
            0,
            0,
            0});
            this.frequencyNumeric.ValueChanged += new System.EventHandler(this.FrequencyNumeric_ValueChanged);
            // 
            // volumePictureBox
            // 
            this.volumePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("volumePictureBox.Image")));
            this.volumePictureBox.Location = new System.Drawing.Point(21, 63);
            this.volumePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.volumePictureBox.Name = "volumePictureBox";
            this.volumePictureBox.Size = new System.Drawing.Size(24, 24);
            this.volumePictureBox.TabIndex = 15;
            this.volumePictureBox.TabStop = false;
            // 
            // dBVolumeSlider
            // 
            this.dBVolumeSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dBVolumeSlider.Location = new System.Drawing.Point(54, 63);
            this.dBVolumeSlider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dBVolumeSlider.MaximumDB = 0F;
            this.dBVolumeSlider.MinimumDB = -60F;
            this.dBVolumeSlider.Name = "dBVolumeSlider";
            this.dBVolumeSlider.Size = new System.Drawing.Size(568, 24);
            this.dBVolumeSlider.TabIndex = 27;
            this.toolTip.SetToolTip(this.dBVolumeSlider, "Controls the volume on a logarithmic scale.");
            this.dBVolumeSlider.Volume = 0.25F;
            this.dBVolumeSlider.VolumeChanged += new System.EventHandler(this.DBVolumeSlider_VolumeChanged);
            // 
            // plusButton
            // 
            this.plusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plusButton.Location = new System.Drawing.Point(298, 10);
            this.plusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(40, 34);
            this.plusButton.TabIndex = 18;
            this.plusButton.Text = "+.5";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // minusButton
            // 
            this.minusButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minusButton.Location = new System.Drawing.Point(254, 10);
            this.minusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(40, 34);
            this.minusButton.TabIndex = 17;
            this.minusButton.Text = "-.5";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // plus2Button
            // 
            this.plus2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plus2Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plus2Button.Location = new System.Drawing.Point(488, 10);
            this.plus2Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plus2Button.Name = "plus2Button";
            this.plus2Button.Size = new System.Drawing.Size(40, 34);
            this.plus2Button.TabIndex = 29;
            this.plus2Button.Text = "+2";
            this.plus2Button.UseVisualStyleBackColor = true;
            this.plus2Button.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // minus2Button
            // 
            this.minus2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minus2Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minus2Button.Location = new System.Drawing.Point(442, 10);
            this.minus2Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minus2Button.Name = "minus2Button";
            this.minus2Button.Size = new System.Drawing.Size(40, 34);
            this.minus2Button.TabIndex = 28;
            this.minus2Button.Text = "-2";
            this.minus2Button.UseVisualStyleBackColor = true;
            this.minus2Button.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // SoundtrackControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.plus2Button);
            this.Controls.Add(this.minus2Button);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SoundtrackControl";
            this.Size = new System.Drawing.Size(634, 142);
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
        private System.Windows.Forms.Button plus2Button;
        private System.Windows.Forms.Button minus2Button;
    }
}
