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
            this.divisionTonesUpDown = new System.Windows.Forms.NumericUpDown();
            this.divisionTonesLabel = new System.Windows.Forms.Label();
            this.bottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.playButton.TabIndex = 15;
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
            this.bottomPanel.Location = new System.Drawing.Point(0, 305);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(660, 41);
            this.bottomPanel.TabIndex = 17;
            // 
            // masterVolumeSlider
            // 
            this.masterVolumeSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.masterVolumeSlider.Location = new System.Drawing.Point(0, 0);
            this.masterVolumeSlider.Name = "masterVolumeSlider";
            this.masterVolumeSlider.Size = new System.Drawing.Size(660, 16);
            this.masterVolumeSlider.TabIndex = 16;
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(660, 272);
            this.tableLayoutPanel.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.divisionTonesUpDown);
            this.panel1.Controls.Add(this.divisionTonesLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 33);
            this.panel1.TabIndex = 19;
            // 
            // divisionTonesUpDown
            // 
            this.divisionTonesUpDown.Location = new System.Drawing.Point(164, 7);
            this.divisionTonesUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.divisionTonesUpDown.Name = "divisionTonesUpDown";
            this.divisionTonesUpDown.Size = new System.Drawing.Size(46, 23);
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
            this.divisionTonesLabel.Size = new System.Drawing.Size(146, 15);
            this.divisionTonesLabel.TabIndex = 0;
            this.divisionTonesLabel.Text = "&Equal temperament tones:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(660, 346);
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
    }
}

