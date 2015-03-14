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
            this.masterVolumeSlider = new ToneGenerator.VolumeSlider();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.periodUpDown = new System.Windows.Forms.NumericUpDown();
            this.periodLabel = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.minimumVolumeUpDown = new System.Windows.Forms.NumericUpDown();
            this.minVolumeLabel = new System.Windows.Forms.Label();
            this.divisionTonesUpDown = new System.Windows.Forms.NumericUpDown();
            this.divisionTonesLabel = new System.Windows.Forms.Label();
            this.bottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumVolumeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionTonesUpDown)).BeginInit();
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
            this.playButton.Size = new System.Drawing.Size(660, 25);
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
            this.bottomPanel.Size = new System.Drawing.Size(660, 41);
            this.bottomPanel.TabIndex = 17;
            // 
            // masterVolumeSlider
            // 
            this.masterVolumeSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.masterVolumeSlider.Location = new System.Drawing.Point(0, 0);
            this.masterVolumeSlider.MinimumDB = -48F;
            this.masterVolumeSlider.Name = "masterVolumeSlider";
            this.masterVolumeSlider.Size = new System.Drawing.Size(660, 16);
            this.masterVolumeSlider.TabIndex = 0;
            this.masterVolumeSlider.VolumeChanged += new System.EventHandler(this.masterVolumeSlider_VolumeChanged);
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(660, 303);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.periodUpDown);
            this.panel1.Controls.Add(this.periodLabel);
            this.panel1.Controls.Add(this.modeComboBox);
            this.panel1.Controls.Add(this.modeLabel);
            this.panel1.Controls.Add(this.minimumVolumeUpDown);
            this.panel1.Controls.Add(this.minVolumeLabel);
            this.panel1.Controls.Add(this.divisionTonesUpDown);
            this.panel1.Controls.Add(this.divisionTonesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 33);
            this.panel1.TabIndex = 0;
            // 
            // periodUpDown
            // 
            this.periodUpDown.Location = new System.Drawing.Point(594, 7);
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
            this.periodUpDown.TabIndex = 7;
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
            this.periodLabel.Location = new System.Drawing.Point(517, 9);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(71, 15);
            this.periodLabel.TabIndex = 6;
            this.periodLabel.Text = "&Period (ms):";
            // 
            // modeComboBox
            // 
            this.modeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Pure tones",
            "Alternating tones"});
            this.modeComboBox.Location = new System.Drawing.Point(375, 6);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(136, 23);
            this.modeComboBox.TabIndex = 5;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(328, 9);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(41, 15);
            this.modeLabel.TabIndex = 4;
            this.modeLabel.Text = "M&ode:";
            // 
            // minimumVolumeUpDown
            // 
            this.minimumVolumeUpDown.Location = new System.Drawing.Point(272, 7);
            this.minimumVolumeUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.minimumVolumeUpDown.Minimum = new decimal(new int[] {
            900,
            0,
            0,
            -2147483648});
            this.minimumVolumeUpDown.Name = "minimumVolumeUpDown";
            this.minimumVolumeUpDown.Size = new System.Drawing.Size(50, 23);
            this.minimumVolumeUpDown.TabIndex = 3;
            this.minimumVolumeUpDown.Value = new decimal(new int[] {
            48,
            0,
            0,
            -2147483648});
            this.minimumVolumeUpDown.ValueChanged += new System.EventHandler(this.minimumVolumeUpDown_ValueChanged);
            // 
            // minVolumeLabel
            // 
            this.minVolumeLabel.AutoSize = true;
            this.minVolumeLabel.Location = new System.Drawing.Point(160, 9);
            this.minVolumeLabel.Name = "minVolumeLabel";
            this.minVolumeLabel.Size = new System.Drawing.Size(106, 15);
            this.minVolumeLabel.TabIndex = 2;
            this.minVolumeLabel.Text = "&Minimum volume:";
            // 
            // divisionTonesUpDown
            // 
            this.divisionTonesUpDown.Location = new System.Drawing.Point(109, 7);
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
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(660, 377);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(676, 214);
            this.Name = "Form1";
            this.Text = "Tone Generator";
            this.bottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumVolumeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divisionTonesUpDown)).EndInit();
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
        private System.Windows.Forms.NumericUpDown minimumVolumeUpDown;
        private System.Windows.Forms.Label minVolumeLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.NumericUpDown periodUpDown;
        private System.Windows.Forms.Label periodLabel;
    }
}

