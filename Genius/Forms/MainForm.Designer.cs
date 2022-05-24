namespace Genius.Forms
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pbYellow = new System.Windows.Forms.PictureBox();
			this.pbBlue = new System.Windows.Forms.PictureBox();
			this.pbGreen = new System.Windows.Forms.PictureBox();
			this.pbRed = new System.Windows.Forms.PictureBox();
			this.lblSequence = new System.Windows.Forms.Label();
			this.lblCurrentPosition = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblSequenceValue = new System.Windows.Forms.Label();
			this.lblPositionValue = new System.Windows.Forms.Label();
			this.lblScoreValue = new System.Windows.Forms.Label();
			this.gbDifficult = new System.Windows.Forms.GroupBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.rbExpert = new System.Windows.Forms.RadioButton();
			this.rbHard = new System.Windows.Forms.RadioButton();
			this.rbNormal = new System.Windows.Forms.RadioButton();
			this.rbEasy = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pbYellow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRed)).BeginInit();
			this.gbDifficult.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbYellow
			// 
			this.pbYellow.Image = global::Genius.Properties.Resources.yellow;
			this.pbYellow.Location = new System.Drawing.Point(267, 12);
			this.pbYellow.Name = "pbYellow";
			this.pbYellow.Size = new System.Drawing.Size(300, 300);
			this.pbYellow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbYellow.TabIndex = 0;
			this.pbYellow.TabStop = false;
			this.pbYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbYellow_MouseDown);
			this.pbYellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbYellow_MouseUp);
			// 
			// pbBlue
			// 
			this.pbBlue.Image = global::Genius.Properties.Resources.blue;
			this.pbBlue.Location = new System.Drawing.Point(573, 12);
			this.pbBlue.Name = "pbBlue";
			this.pbBlue.Size = new System.Drawing.Size(300, 300);
			this.pbBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbBlue.TabIndex = 1;
			this.pbBlue.TabStop = false;
			this.pbBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbBlue_MouseDown);
			this.pbBlue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbBlue_MouseUp);
			// 
			// pbGreen
			// 
			this.pbGreen.Image = global::Genius.Properties.Resources.green;
			this.pbGreen.Location = new System.Drawing.Point(267, 318);
			this.pbGreen.Name = "pbGreen";
			this.pbGreen.Size = new System.Drawing.Size(300, 300);
			this.pbGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbGreen.TabIndex = 2;
			this.pbGreen.TabStop = false;
			this.pbGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbGreen_MouseDown);
			this.pbGreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbGreen_MouseUp);
			// 
			// pbRed
			// 
			this.pbRed.Image = global::Genius.Properties.Resources.red;
			this.pbRed.Location = new System.Drawing.Point(573, 318);
			this.pbRed.Name = "pbRed";
			this.pbRed.Size = new System.Drawing.Size(300, 300);
			this.pbRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbRed.TabIndex = 3;
			this.pbRed.TabStop = false;
			this.pbRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbRed_MouseDown);
			this.pbRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbRed_MouseUp);
			// 
			// lblSequence
			// 
			this.lblSequence.AutoSize = true;
			this.lblSequence.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblSequence.Location = new System.Drawing.Point(23, 36);
			this.lblSequence.Name = "lblSequence";
			this.lblSequence.Size = new System.Drawing.Size(101, 15);
			this.lblSequence.TabIndex = 4;
			this.lblSequence.Text = "Sequence Length:";
			// 
			// lblCurrentPosition
			// 
			this.lblCurrentPosition.AutoSize = true;
			this.lblCurrentPosition.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblCurrentPosition.Location = new System.Drawing.Point(23, 64);
			this.lblCurrentPosition.Name = "lblCurrentPosition";
			this.lblCurrentPosition.Size = new System.Drawing.Size(96, 15);
			this.lblCurrentPosition.TabIndex = 5;
			this.lblCurrentPosition.Text = "Current Position:";
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblScore.Location = new System.Drawing.Point(23, 90);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(39, 15);
			this.lblScore.TabIndex = 6;
			this.lblScore.Text = "Score:";
			// 
			// lblSequenceValue
			// 
			this.lblSequenceValue.AutoSize = true;
			this.lblSequenceValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblSequenceValue.Location = new System.Drawing.Point(130, 36);
			this.lblSequenceValue.Name = "lblSequenceValue";
			this.lblSequenceValue.Size = new System.Drawing.Size(13, 15);
			this.lblSequenceValue.TabIndex = 7;
			this.lblSequenceValue.Text = "0";
			// 
			// lblPositionValue
			// 
			this.lblPositionValue.AutoSize = true;
			this.lblPositionValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblPositionValue.Location = new System.Drawing.Point(125, 64);
			this.lblPositionValue.Name = "lblPositionValue";
			this.lblPositionValue.Size = new System.Drawing.Size(13, 15);
			this.lblPositionValue.TabIndex = 8;
			this.lblPositionValue.Text = "0";
			// 
			// lblScoreValue
			// 
			this.lblScoreValue.AutoSize = true;
			this.lblScoreValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblScoreValue.Location = new System.Drawing.Point(68, 90);
			this.lblScoreValue.Name = "lblScoreValue";
			this.lblScoreValue.Size = new System.Drawing.Size(13, 15);
			this.lblScoreValue.TabIndex = 9;
			this.lblScoreValue.Text = "0";
			// 
			// gbDifficult
			// 
			this.gbDifficult.Controls.Add(this.btnStart);
			this.gbDifficult.Controls.Add(this.rbExpert);
			this.gbDifficult.Controls.Add(this.rbHard);
			this.gbDifficult.Controls.Add(this.rbNormal);
			this.gbDifficult.Controls.Add(this.rbEasy);
			this.gbDifficult.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.gbDifficult.Location = new System.Drawing.Point(23, 127);
			this.gbDifficult.Name = "gbDifficult";
			this.gbDifficult.Size = new System.Drawing.Size(200, 127);
			this.gbDifficult.TabIndex = 10;
			this.gbDifficult.TabStop = false;
			this.gbDifficult.Text = "Difficult";
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnStart.Location = new System.Drawing.Point(54, 77);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(89, 34);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// rbExpert
			// 
			this.rbExpert.AutoSize = true;
			this.rbExpert.Location = new System.Drawing.Point(114, 45);
			this.rbExpert.Name = "rbExpert";
			this.rbExpert.Size = new System.Drawing.Size(58, 19);
			this.rbExpert.TabIndex = 3;
			this.rbExpert.Text = "Expert";
			this.rbExpert.UseVisualStyleBackColor = true;
			// 
			// rbHard
			// 
			this.rbHard.AutoSize = true;
			this.rbHard.Location = new System.Drawing.Point(114, 20);
			this.rbHard.Name = "rbHard";
			this.rbHard.Size = new System.Drawing.Size(51, 19);
			this.rbHard.TabIndex = 2;
			this.rbHard.Text = "Hard";
			this.rbHard.UseVisualStyleBackColor = true;
			// 
			// rbNormal
			// 
			this.rbNormal.AutoSize = true;
			this.rbNormal.Location = new System.Drawing.Point(21, 45);
			this.rbNormal.Name = "rbNormal";
			this.rbNormal.Size = new System.Drawing.Size(65, 19);
			this.rbNormal.TabIndex = 1;
			this.rbNormal.Text = "Normal";
			this.rbNormal.UseVisualStyleBackColor = true;
			// 
			// rbEasy
			// 
			this.rbEasy.AutoSize = true;
			this.rbEasy.Checked = true;
			this.rbEasy.Location = new System.Drawing.Point(21, 20);
			this.rbEasy.Name = "rbEasy";
			this.rbEasy.Size = new System.Drawing.Size(48, 19);
			this.rbEasy.TabIndex = 0;
			this.rbEasy.TabStop = true;
			this.rbEasy.Text = "Easy";
			this.rbEasy.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.ClientSize = new System.Drawing.Size(885, 630);
			this.Controls.Add(this.gbDifficult);
			this.Controls.Add(this.lblScoreValue);
			this.Controls.Add(this.lblPositionValue);
			this.Controls.Add(this.lblSequenceValue);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.lblCurrentPosition);
			this.Controls.Add(this.lblSequence);
			this.Controls.Add(this.pbRed);
			this.Controls.Add(this.pbGreen);
			this.Controls.Add(this.pbBlue);
			this.Controls.Add(this.pbYellow);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Genius";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbYellow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbRed)).EndInit();
			this.gbDifficult.ResumeLayout(false);
			this.gbDifficult.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pbYellow;
		private PictureBox pbBlue;
		private PictureBox pbGreen;
		private PictureBox pbRed;
		private Label lblSequence;
		private Label lblCurrentPosition;
		private Label lblScore;
		private Label lblSequenceValue;
		private Label lblPositionValue;
		private Label lblScoreValue;
		private GroupBox gbDifficult;
		private Button btnStart;
		private RadioButton rbExpert;
		private RadioButton rbHard;
		private RadioButton rbNormal;
		private RadioButton rbEasy;
	}
}