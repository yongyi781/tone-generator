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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.CheckBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.calibrationRightBrowseButton = new System.Windows.Forms.Button();
            this.calibrateLeftBrowseButton = new System.Windows.Forms.Button();
            this.calibrationRightTextBox = new System.Windows.Forms.TextBox();
            this.rightEarLabel = new System.Windows.Forms.Label();
            this.calibrationLeftTextBox = new System.Windows.Forms.TextBox();
            this.leftEarLabel = new System.Windows.Forms.Label();
            this.masterVolumeSlider = new ToneGenerator.VolumeSlider();
            this.useLoudnessCheckBox = new System.Windows.Forms.CheckBox();
            this.bottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxVolumeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minVolumeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionTonesUpDown)).BeginInit();
            this.calibrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.playButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.playButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(0, 16);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(754, 25);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "▶ ";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.CheckedChanged += new System.EventHandler(this.playButton_CheckedChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.playButton);
            this.bottomPanel.Controls.Add(this.masterVolumeSlider);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 336);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(754, 41);
            this.bottomPanel.TabIndex = 17;
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(754, 303);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.panel1.Size = new System.Drawing.Size(754, 33);
            this.panel1.TabIndex = 0;
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
            this.maxVolumeUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.maxVolumeUpDown.ValueChanged += new System.EventHandler(this.minMaxVolumeUpDown_ValueChanged);
            // 
            // maxVolumeLabel
            // 
            this.maxVolumeLabel.AutoSize = true;
            this.maxVolumeLabel.Location = new System.Drawing.Point(247, 9);
            this.maxVolumeLabel.Name = "maxVolumeLabel";
            this.maxVolumeLabel.Size = new System.Drawing.Size(32, 15);
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
            this.calibrateButton.CheckedChanged += new System.EventHandler(this.calibrateButton_CheckedChanged);
            // 
            // periodUpDown
            // 
            this.periodUpDown.Location = new System.Drawing.Point(696, 7);
            this.periodUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.periodUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.periodUpDown.Name = "periodUpDown";
            this.periodUpDown.Size = new System.Drawing.Size(50, 23);
            this.periodUpDown.TabIndex = 10;
            this.periodUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.periodUpDown.ValueChanged += new System.EventHandler(this.periodUpDown_ValueChanged);
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
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
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
            this.minVolumeUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.minVolumeUpDown.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            -2147483648});
            this.minVolumeUpDown.Name = "minVolumeUpDown";
            this.minVolumeUpDown.Size = new System.Drawing.Size(50, 23);
            this.minVolumeUpDown.TabIndex = 3;
            this.minVolumeUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.minVolumeUpDown.ValueChanged += new System.EventHandler(this.minMaxVolumeUpDown_ValueChanged);
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
            this.calibrationPanel.Size = new System.Drawing.Size(754, 303);
            this.calibrationPanel.TabIndex = 1;
            this.calibrationPanel.Visible = false;
            // 
            // calibrationRightBrowseButton
            // 
            this.calibrationRightBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrationRightBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calibrationRightBrowseButton.Location = new System.Drawing.Point(667, 35);
            this.calibrationRightBrowseButton.Name = "calibrationRightBrowseButton";
            this.calibrationRightBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.calibrationRightBrowseButton.TabIndex = 5;
            this.calibrationRightBrowseButton.Text = "&Browse...";
            this.calibrationRightBrowseButton.UseVisualStyleBackColor = true;
            this.calibrationRightBrowseButton.Click += new System.EventHandler(this.calibrateBrowseButton_Click);
            // 
            // calibrateLeftBrowseButton
            // 
            this.calibrateLeftBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrateLeftBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calibrateLeftBrowseButton.Location = new System.Drawing.Point(667, 6);
            this.calibrateLeftBrowseButton.Name = "calibrateLeftBrowseButton";
            this.calibrateLeftBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.calibrateLeftBrowseButton.TabIndex = 4;
            this.calibrateLeftBrowseButton.Text = "&Browse...";
            this.calibrateLeftBrowseButton.UseVisualStyleBackColor = true;
            this.calibrateLeftBrowseButton.Click += new System.EventHandler(this.calibrateBrowseButton_Click);
            // 
            // calibrationRightTextBox
            // 
            this.calibrationRightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calibrationRightTextBox.Location = new System.Drawing.Point(75, 35);
            this.calibrationRightTextBox.Name = "calibrationRightTextBox";
            this.calibrationRightTextBox.ReadOnly = true;
            this.calibrationRightTextBox.Size = new System.Drawing.Size(586, 23);
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
            this.calibrationLeftTextBox.Size = new System.Drawing.Size(586, 23);
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
            // masterVolumeSlider
            // 
            this.masterVolumeSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.masterVolumeSlider.Location = new System.Drawing.Point(0, 0);
            this.masterVolumeSlider.MaximumDB = 0F;
            this.masterVolumeSlider.MinimumDB = -48F;
            this.masterVolumeSlider.Name = "masterVolumeSlider";
            this.masterVolumeSlider.Size = new System.Drawing.Size(754, 16);
            this.masterVolumeSlider.TabIndex = 0;
            this.masterVolumeSlider.VolumeChanged += new System.EventHandler(this.masterVolumeSlider_VolumeChanged);
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
            this.useLoudnessCheckBox.CheckedChanged += new System.EventHandler(this.useLoudnessCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(754, 377);
            this.Controls.Add(this.calibrationPanel);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(770, 214);
            this.Name = "Form1";
            this.Text = "Tone Generator";
            this.bottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label periodLabel;
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
    }
}

