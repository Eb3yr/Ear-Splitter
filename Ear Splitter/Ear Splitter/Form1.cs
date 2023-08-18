using System.IO.Packaging;

namespace Ear_Splitter
{
	public partial class Form1 : Form
	{
		bool cont;
		public Form1()
		{
			InitializeComponent();
			cont = false;
		}

		private void NukeEarsButton_Click(object sender, EventArgs e)
		{
			if (OnOffLabel.Text == "Off")
			{
				OnOffLabel.Text = "On";
				cont = true;
				NukeEars();
			}
			else
			{
				OnOffLabel.Text = "Off";
				cont = false;
			}
		}

		private async void NukeEars()
		{
			List<WMPLib.WindowsMediaPlayer> players = new();
			while (cont)
			{
				players.Add(new WMPLib.WindowsMediaPlayer { URL = SelectPathButton.Text });
				players[players.Count - 1].controls.play();
				if (DelayUpDown.Value > 0)
				{
					await Task.Delay((int)DelayUpDown.Value);
				}
			}
			players.Clear();
		}

		private void SelectPathButton_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName != "")
			{
				SelectPathButton.Text = openFileDialog1.FileName;
			}
		}
	}
}