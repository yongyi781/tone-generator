﻿namespace ToneGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.CheckBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.nextOctaveButton = new System.Windows.Forms.Button();
            this.prevOctaveButton = new System.Windows.Forms.Button();
            this.nextNoteButton = new System.Windows.Forms.Button();
            this.prevNoteButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.masterVolumeSlider = new ToneGenerator.VolumeSlider();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dutyCycleUpDown = new System.Windows.Forms.NumericUpDown();
            this.dutyCycleLabel = new System.Windows.Forms.Label();
            this.maxVolumeUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxVolumeLabel = new System.Windows.Forms.Label();
            this.calibrateButton = new System.Windows.Forms.CheckBox();
            this.periodUpDown = new System.Windows.Forms.NumericUpDown();
            this.periodLabel = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.minVolumeUpDown = new System.Windows.Forms.NumericUpDown();
            this.minVolumeLabel = new System.Windows.Forms.Label();
            this.divisionTonesUpDown = new System.Windows.Forms.NumericUpDown();
            this.divisionTonesLabel = new System.Windows.Forms.Label();
            this.calibrationPanel = new System.Windows.Forms.Panel();
            this.resetCalibrationButton = new System.Windows.Forms.Button();
            this.useLoudnessCheckBox = new System.Windows.Forms.CheckBox();
            this.calibrationRightBrowseButton = new System.Windows.Forms.Button();
            this.calibrateLeftBrowseButton = new System.Windows.Forms.Button();
            this.calibrationRightTextBox = new System.Windows.Forms.TextBox();
            this.rightEarLabel = new System.Windows.Forms.Label();
            this.calibrationLeftTextBox = new System.Windows.Forms.TextBox();
            this.leftEarLabel = new System.Windows.Forms.Label();
            this.bottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVolumeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minVolumeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionTonesUpDown)).BeginInit();
            this.calibrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.playButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(165, 16);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(785, 25);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "▶ ";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.CheckedChanged += new System.EventHandler(this.PlayButton_CheckedChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.nextOctaveButton);
            this.bottomPanel.Controls.Add(this.prevOctaveButton);
            this.bottomPanel.Controls.Add(this.nextNoteButton);
            this.bottomPanel.Controls.Add(this.prevNoteButton);
            this.bottomPanel.Controls.Add(this.plusButton);
            this.bottomPanel.Controls.Add(this.minusButton);
            this.bottomPanel.Controls.Add(this.playButton);
            this.bottomPanel.Controls.Add(this.masterVolumeSlider);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 336);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(950, 41);
            this.bottomPanel.TabIndex = 17;
            // 
            // nextOctaveButton
            // 
            this.nextOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextOctaveButton.Location = new System.Drawing.Point(136, 17);
            this.nextOctaveButton.Name = "nextOctaveButton";
            this.nextOctaveButton.Size = new System.Drawing.Size(23, 23);
            this.nextOctaveButton.TabIndex = 28;
            this.nextOctaveButton.Text = ">>";
            this.nextOctaveButton.UseVisualStyleBackColor = true;
            this.nextOctaveButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // prevOctaveButton
            // 
            this.prevOctaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevOctaveButton.Location = new System.Drawing.Point(113, 17);
            this.prevOctaveButton.Name = "prevOctaveButton";
            this.prevOctaveButton.Size = new System.Drawing.Size(23, 23);
            this.prevOctaveButton.TabIndex = 27;
            this.prevOctaveButton.Text = "<<";
            this.prevOctaveButton.UseVisualStyleBackColor = true;
            this.prevOctaveButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // nextNoteButton
            // 
            this.nextNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextNoteButton.Location = new System.Drawing.Point(81, 17);
            this.nextNoteButton.Name = "nextNoteButton";
            this.nextNoteButton.Size = new System.Drawing.Size(23, 23);
            this.nextNoteButton.TabIndex = 26;
            this.nextNoteButton.Text = ">";
            this.nextNoteButton.UseVisualStyleBackColor = true;
            this.nextNoteButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // prevNoteButton
            // 
            this.prevNoteButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.prevNoteButton.Location = new System.Drawing.Point(58, 17);
            this.prevNoteButton.Name = "prevNoteButton";
            this.prevNoteButton.Size = new System.Drawing.Size(23, 23);
            this.prevNoteButton.TabIndex = 25;
            this.prevNoteButton.Text = "<";
            this.prevNoteButton.UseVisualStyleBackColor = true;
            this.prevNoteButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // plusButton
            // 
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plusButton.Location = new System.Drawing.Point(26, 17);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(23, 23);
            this.plusButton.TabIndex = 24;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // minusButton
            // 
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minusButton.Location = new System.Drawing.Point(3, 17);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(23, 23);
            this.minusButton.TabIndex = 23;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.ChangeFrequencyButtons_Click);
            // 
            // masterVolumeSlider
            // 
            this.masterVolumeSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.masterVolumeSlider.Location = new System.Drawing.Point(0, 0);
            this.masterVolumeSlider.MaximumDB = 0F;
            this.masterVolumeSlider.MinimumDB = -48F;
            this.masterVolumeSlider.Name = "masterVolumeSlider";
            this.masterVolumeSlider.Size = new System.Drawing.Size(950, 16);
            this.masterVolumeSlider.TabIndex = 0;
            this.masterVolumeSlider.VolumeChanged += new System.EventHandler(this.MasterVolumeSlider_VolumeChanged);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(950, 303);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.dutyCycleUpDown);
            this.panel1.Controls.Add(this.dutyCycleLabel);
            this.panel1.Controls.Add(this.maxVolumeUpDown);
            this.panel1.Controls.Add(this.maxVolumeLabel);
            this.panel1.Controls.Add(this.calibrateButton);
            this.panel1.Controls.Add(this.periodUpDown);
            this.panel1.Controls.Add(this.periodLabel);
            this.panel1.Controls.Add(this.modeComboBox);
            this.panel1.Controls.Add(this.modeLabel);
            this.panel1.Controls.Add(this.minVolumeUpDown);
            this.panel1.Controls.Add(this.minVolumeLabel);
            this.panel1.Controls.Add(this.divisionTonesUpDown);
            this.panel1.Controls.Add(this.divisionTonesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 33);
            this.panel1.TabIndex = 0;
            // 
            // dutyCycleUpDown
            // 
            this.dutyCycleUpDown.DecimalPlaces = 3;
            this.dutyCycleUpDown.Increment = new decimal(new int[] {
            2,
            0,
            0,
            196608});
            this.dutyCycleUpDown.Location = new System.Drawing.Point(840, 7);
            this.dutyCycleUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dutyCycleUpDown.Name = "dutyCycleUpDown";
            this.dutyCycleUpDown.Size = new System.Drawing.Size(67, 23);
            this.dutyCycleUpDown.TabIndex = 12;
            this.dutyCycleUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.dutyCycleUpDown.ValueChanged += new System.EventHandler(this.DutyCycleUpDown_ValueChanged);
            // 
            // dutyCycleLabel
            // 
            this.dutyCycleLabel.AutoSize = true;
            this.dutyCycleLabel.Location = new System.Drawing.Point(769, 9);
            this.dutyCycleLabel.Name = "dutyCycleLabel";
            this.dutyCycleLabel.Size = new System.Drawing.Size(65, 15);
            this.dutyCycleLabel.TabIndex = 11;
            this.dutyCycleLabel.Text = "&Duty cycle:";
            // 
            // maxVolumeUpDown
            // 
            this.maxVolumeUpDown.Location = new System.Drawing.Point(281, 7);
            this.maxVolumeUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.maxVolumeUpDown.Name = "maxVolumeUpDown";
            this.maxVolumeUpDown.Size = new System.Drawing.Size(50, 23);
            this.maxVolumeUpDown.TabIndex = 5;
            this.maxVolumeUpDown.ValueChanged += new System.EventHandler(this.MinMaxVolumeUpDown_ValueChanged);
            // 
            // maxVolumeLabel
            // 
            this.maxVolumeLabel.AutoSize = true;
            this.maxVolumeLabel.Location = new System.Drawing.Point(247, 9);
            this.maxVolumeLabel.Name = "maxVolumeLabel";
            this.maxVolumeLabel.Size = new System.Drawing.Size(33, 15);
            this.maxVolumeLabel.TabIndex = 4;
            this.maxVolumeLabel.Text = "&Max:";
            // 
            // calibrateButton
            // 
            this.calibrateButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.calibrateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calibrateButton.Location = new System.Drawing.Point(337, 6);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(76, 24);
            this.calibrateButton.TabIndex = 6;
            this.calibrateButton.Text = "&Calibrate";
            this.calibrateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.calibrateButton.UseVisualStyleBackColor = true;
            this.calibrateButton.CheckedChanged += new System.EventHandler(this.CalibrateButton_CheckedChanged);
            // 
            // periodUpDown
            // 
            this.periodUpDown.DecimalPlaces = 3;
            this.periodUpDown.Location = new System.Drawing.Point(696, 7);
            this.periodUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.periodUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.periodUpDown.Name = "periodUpDown";
            this.periodUpDown.Size = new System.Drawing.Size(67, 23);
            this.periodUpDown.TabIndex = 10;
            this.periodUpDown.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.periodUpDown.ValueChanged += new System.EventHandler(this.PeriodUpDown_ValueChanged);
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.Location = new System.Drawing.Point(619, 9);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(71, 15);
            this.periodLabel.TabIndex = 9;
            this.periodLabel.Text = "&Period (ms):";
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Pure tones",
            "Alternating tones"});
            this.modeComboBox.Location = new System.Drawing.Point(477, 6);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(136, 23);
            this.modeComboBox.TabIndex = 8;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.ModeComboBox_SelectedIndexChanged);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(430, 9);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(41, 15);
            this.modeLabel.TabIndex = 7;
            this.modeLabel.Text = "M&ode:";
            // 
            // minVolumeUpDown
            // 
            this.minVolumeUpDown.Location = new System.Drawing.Point(191, 7);
            this.minVolumeUpDown.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            -2147483648});
            this.minVolumeUpDown.Name = "minVolumeUpDown";
            this.minVolumeUpDown.Size = new System.Drawing.Size(50, 23);
            this.minVolumeUpDown.TabIndex = 3;
            this.minVolumeUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.minVolumeUpDown.ValueChanged += new System.EventHandler(this.MinMaxVolumeUpDown_ValueChanged);
            // 
            // minVolumeLabel
            // 
            this.minVolumeLabel.AutoSize = true;
            this.minVolumeLabel.Location = new System.Drawing.Point(157, 9);
            this.minVolumeLabel.Name = "minVolumeLabel";
            this.minVolumeLabel.Size = new System.Drawing.Size(31, 15);
            this.minVolumeLabel.TabIndex = 2;
            this.minVolumeLabel.Text = "&Min:";
            // 
            // divisionTonesUpDown
            // 
            this.divisionTonesUpDown.Location = new System.Drawing.Point(106, 7);
            this.divisionTonesUpDown.Maximum = new decimal(new int[] {
            120000,
            0,
            0,
            0});
            this.divisionTonesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.divisionTonesUpDown.Name = "divisionTonesUpDown";
            this.divisionTonesUpDown.Size = new System.Drawing.Size(45, 23);
            this.divisionTonesUpDown.TabIndex = 1;
            this.divisionTonesUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // divisionTonesLabel
            // 
            this.divisionTonesLabel.AutoSize = true;
            this.divisionTonesLabel.Location = new System.Drawing.Point(12, 9);
            this.divisionTonesLabel.Name = "divisionTonesLabel";
            this.divisionTonesLabel.Size = new System.Drawing.Size(91, 15);
            this.divisionTonesLabel.TabIndex = 0;
            this.divisionTonesLabel.Text = "&Octave division:";
            // 
            // calibrationPanel
            // 
            this.calibrationPanel.Controls.Add(this.resetCalibrationButton);
            this.calibrationPanel.Controls.Add(this.useLoudnessCheckBox);
            this.calibrationPanel.Controls.Add(this.calibrationRightBrowseButton);
            this.calibrationPanel.Controls.Add(this.calibrateLeftBrowseButton);
            this.calibrationPanel.Controls.Add(this.calibrationRightTextBox);
            this.calibrationPanel.Controls.Add(this.rightEarLabel);
            this.calibrationPanel.Controls.Add(this.calibrationLeftTextBox);
            this.calibrationPanel.Controls.Add(this.leftEarLabel);
            this.calibrationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calibrationPanel.Location = new System.Drawing.Point(0, 33);
            this.calibrationPanel.Name = "calibrationPanel";
            this.calibrationPanel.Size = new System.Drawing.Size(950, 303);
            this.calibrationPanel.TabIndex = 1;
            this.calibrationPanel.Visible = false;
            // 
            // resetCalibrationButton
            // 
            this.resetCalibrationButton.AutoSize = true;
            this.resetCalibrationButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resetCalibrationButton.Location = new System.Drawing.Point(75, 90);
            this.resetCalibrationButton.Name = "resetCalibrationButton";
            this.resetCalibrationButton.Size = new System.Drawing.Size(112, 24);
            this.resetCalibrationButton.TabIndex = 7;
            this.resetCalibrationButton.Text = "R&eset calibration";
            this.resetCalibrationButton.UseVisualStyleBackColor = true;
            this.resetCalibrationButton.Click += new System.EventHandler(this.ResetCalibrationButton_Click);
            // 
            // useLoudnessCheckBox
            // 
            this.useLoudnessCheckBox.AutoSize = true;
            this.useLoudnessCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.useLoudnessCheckBox.Location = new System.Drawing.Point(75, 64);
            this.useLoudnessCheckBox.Name = "useLoudnessCheckBox";
            this.useLoudnessCheckBox.Size = new System.Drawing.Size(234, 20);
            this.useLoudnessCheckBox.TabIndex = 6;
            this.useLoudnessCheckBox.Text = "&Use Loudness (maps 120 dB to 0 dBFS)";
            this.useLoudnessCheckBox.UseVisualStyleBackColor = true;
            this.useLoudnessCheckBox.CheckedChanged += new System.EventHandler(this.UseLoudnessCheckBox_CheckedChanged);
            // 
            // calibrationRightBrowseButton
            // 
            this.calibrationRightBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrationRightBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calibrationRightBrowseButton.Location = new System.Drawing.Point(863, 35);
            this.calibrationRightBrowseButton.Name = "calibrationRightBrowseButton";
            this.calibrationRightBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.calibrationRightBrowseButton.TabIndex = 5;
            this.calibrationRightBrowseButton.Text = "&Browse...";
            this.calibrationRightBrowseButton.UseVisualStyleBackColor = true;
            this.calibrationRightBrowseButton.Click += new System.EventHandler(this.CalibrateBrowseButton_Click);
            // 
            // calibrateLeftBrowseButton
            // 
            this.calibrateLeftBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrateLeftBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calibrateLeftBrowseButton.Location = new System.Drawing.Point(863, 6);
            this.calibrateLeftBrowseButton.Name = "calibrateLeftBrowseButton";
            this.calibrateLeftBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.calibrateLeftBrowseButton.TabIndex = 4;
            this.calibrateLeftBrowseButton.Text = "&Browse...";
            this.calibrateLeftBrowseButton.UseVisualStyleBackColor = true;
            this.calibrateLeftBrowseButton.Click += new System.EventHandler(this.CalibrateBrowseButton_Click);
            // 
            // calibrationRightTextBox
            // 
            this.calibrationRightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrationRightTextBox.Location = new System.Drawing.Point(75, 35);
            this.calibrationRightTextBox.Name = "calibrationRightTextBox";
            this.calibrationRightTextBox.ReadOnly = true;
            this.calibrationRightTextBox.Size = new System.Drawing.Size(782, 23);
            this.calibrationRightTextBox.TabIndex = 3;
            // 
            // rightEarLabel
            // 
            this.rightEarLabel.AutoSize = true;
            this.rightEarLabel.Location = new System.Drawing.Point(12, 38);
            this.rightEarLabel.Name = "rightEarLabel";
            this.rightEarLabel.Size = new System.Drawing.Size(57, 15);
            this.rightEarLabel.TabIndex = 2;
            this.rightEarLabel.Text = "&Right ear:";
            // 
            // calibrationLeftTextBox
            // 
            this.calibrationLeftTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrationLeftTextBox.Location = new System.Drawing.Point(75, 6);
            this.calibrationLeftTextBox.Name = "calibrationLeftTextBox";
            this.calibrationLeftTextBox.ReadOnly = true;
            this.calibrationLeftTextBox.Size = new System.Drawing.Size(782, 23);
            this.calibrationLeftTextBox.TabIndex = 1;
            // 
            // leftEarLabel
            // 
            this.leftEarLabel.AutoSize = true;
            this.leftEarLabel.Location = new System.Drawing.Point(12, 9);
            this.leftEarLabel.Name = "leftEarLabel";
            this.leftEarLabel.Size = new System.Drawing.Size(49, 15);
            this.leftEarLabel.TabIndex = 0;
            this.leftEarLabel.Text = "&Left ear:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(950, 377);
            this.Controls.Add(this.calibrationPanel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(848, 208);
            this.Name = "Form1";
            this.Text = "Tone Generator";
            this.bottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxVolumeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minVolumeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionTonesUpDown)).EndInit();
            this.calibrationPanel.ResumeLayout(false);
            this.calibrationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.CheckBox playButton;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private VolumeSlider masterVolumeSlider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown divisionTonesUpDown;
        private System.Windows.Forms.Label divisionTonesLabel;
        private System.Windows.Forms.NumericUpDown minVolumeUpDown;
        private System.Windows.Forms.Label minVolumeLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.NumericUpDown periodUpDown;
        private System.Windows.Forms.Panel calibrationPanel;
        private System.Windows.Forms.CheckBox calibrateButton;
        private System.Windows.Forms.NumericUpDown maxVolumeUpDown;
        private System.Windows.Forms.Label maxVolumeLabel;
        private System.Windows.Forms.Label leftEarLabel;
        private System.Windows.Forms.TextBox calibrationLeftTextBox;
        private System.Windows.Forms.TextBox calibrationRightTextBox;
        private System.Windows.Forms.Label rightEarLabel;
        private System.Windows.Forms.Button calibrateLeftBrowseButton;
        private System.Windows.Forms.Button calibrationRightBrowseButton;
        private System.Windows.Forms.CheckBox useLoudnessCheckBox;
        private System.Windows.Forms.Button nextOctaveButton;
        private System.Windows.Forms.Button prevOctaveButton;
        private System.Windows.Forms.Button nextNoteButton;
        private System.Windows.Forms.Button prevNoteButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button resetCalibrationButton;
        private System.Windows.Forms.NumericUpDown dutyCycleUpDown;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.Label dutyCycleLabel;
    }
}

