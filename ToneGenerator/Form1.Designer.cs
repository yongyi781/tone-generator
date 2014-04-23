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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.soundtrackControl1 = new ToneGenerator.SoundtrackControl();
            this.soundtrackControl2 = new ToneGenerator.SoundtrackControl();
            this.bottomPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.playButton.Location = new System.Drawing.Point(243, 8);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 15;
            this.playButton.Text = "&Play";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.CheckedChanged += new System.EventHandler(this.playButton_CheckedChanged);
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.Controls.Add(this.playButton);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 191);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(330, 43);
            this.bottomPanel.TabIndex = 17;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.soundtrackControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.soundtrackControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 191);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // soundtrackControl1
            // 
            this.soundtrackControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soundtrackControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.soundtrackControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soundtrackControl1.Location = new System.Drawing.Point(3, 3);
            this.soundtrackControl1.Name = "soundtrackControl1";
            this.soundtrackControl1.Size = new System.Drawing.Size(324, 89);
            this.soundtrackControl1.TabIndex = 0;
            // 
            // soundtrackControl2
            // 
            this.soundtrackControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soundtrackControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.soundtrackControl2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.soundtrackControl2.Location = new System.Drawing.Point(3, 98);
            this.soundtrackControl2.Name = "soundtrackControl2";
            this.soundtrackControl2.Size = new System.Drawing.Size(324, 90);
            this.soundtrackControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(330, 234);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bottomPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(346, 272);
            this.Name = "Form1";
            this.Text = "Tone Generator";
            this.bottomPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
        private System.Windows.Forms.CheckBox playButton;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SoundtrackControl soundtrackControl1;
        private SoundtrackControl soundtrackControl2;
    }
}

