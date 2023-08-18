namespace Ear_Splitter
{
	partial class Form1
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
			NukeEarsButton = new Button();
			SelectPathButton = new Button();
			OnOffLabel = new Label();
			DelayLabel = new Label();
			DelayUpDown = new NumericUpDown();
			openFileDialog1 = new OpenFileDialog();
			AbortButton = new Button();
			((System.ComponentModel.ISupportInitialize)DelayUpDown).BeginInit();
			SuspendLayout();
			// 
			// NukeEarsButton
			// 
			NukeEarsButton.Location = new Point(12, 41);
			NukeEarsButton.Name = "NukeEarsButton";
			NukeEarsButton.Size = new Size(75, 23);
			NukeEarsButton.TabIndex = 0;
			NukeEarsButton.Text = "Nuke Ears";
			NukeEarsButton.UseVisualStyleBackColor = true;
			NukeEarsButton.Click += NukeEarsButton_Click;
			// 
			// SelectPathButton
			// 
			SelectPathButton.Location = new Point(12, 12);
			SelectPathButton.Name = "SelectPathButton";
			SelectPathButton.Size = new Size(130, 23);
			SelectPathButton.TabIndex = 1;
			SelectPathButton.Text = "Select Filepath";
			SelectPathButton.UseVisualStyleBackColor = true;
			SelectPathButton.Click += SelectPathButton_Click;
			// 
			// OnOffLabel
			// 
			OnOffLabel.AutoSize = true;
			OnOffLabel.Location = new Point(93, 45);
			OnOffLabel.Name = "OnOffLabel";
			OnOffLabel.Size = new Size(24, 15);
			OnOffLabel.TabIndex = 2;
			OnOffLabel.Text = "Off";
			// 
			// DelayLabel
			// 
			DelayLabel.AutoSize = true;
			DelayLabel.Location = new Point(12, 67);
			DelayLabel.Name = "DelayLabel";
			DelayLabel.Size = new Size(39, 15);
			DelayLabel.TabIndex = 3;
			DelayLabel.Text = "Delay:";
			// 
			// DelayUpDown
			// 
			DelayUpDown.Location = new Point(57, 65);
			DelayUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			DelayUpDown.Name = "DelayUpDown";
			DelayUpDown.Size = new Size(60, 23);
			DelayUpDown.TabIndex = 4;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// AbortButton
			// 
			AbortButton.Location = new Point(12, 94);
			AbortButton.Name = "AbortButton";
			AbortButton.Size = new Size(75, 23);
			AbortButton.TabIndex = 5;
			AbortButton.Text = "Abort";
			AbortButton.UseVisualStyleBackColor = true;
			AbortButton.Click += AbortButton_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(256, 144);
			Controls.Add(AbortButton);
			Controls.Add(DelayUpDown);
			Controls.Add(DelayLabel);
			Controls.Add(OnOffLabel);
			Controls.Add(SelectPathButton);
			Controls.Add(NukeEarsButton);
			Name = "Form1";
			Text = "Ear Splitter";
			((System.ComponentModel.ISupportInitialize)DelayUpDown).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button NukeEarsButton;
		private Button SelectPathButton;
		private Label OnOffLabel;
		private Label DelayLabel;
		private NumericUpDown DelayUpDown;
		private OpenFileDialog openFileDialog1;
		private Button button1;
		private Button AbortButton;
	}
}