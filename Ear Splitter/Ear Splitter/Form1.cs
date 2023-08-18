using System.IO.Packaging;
using WMPLib;

namespace Ear_Splitter
{
	public partial class Form1 : Form
	{
		bool cont;
		List<WMPLib.WindowsMediaPlayer> players;
		public Form1()
		{
			InitializeComponent();
			cont = false;
			players = new();
		}

		private void NukeEarsButton_Click(object sender, EventArgs e)
		{
			if (OnOffLabel.Text == "Off")
			{
				players.Clear(); //Clear players just before beginning, not at end, so it doesn't interfere with aborting.
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
			while (cont)
			{
				players.Add(new WMPLib.WindowsMediaPlayer { URL = SelectPathButton.Text });
				players[players.Count - 1].controls.play();
				if (DelayUpDown.Value > 0)
				{
					await Task.Delay((int)DelayUpDown.Value);
				}
			}
		}

		private void SelectPathButton_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			if (openFileDialog1.FileName != "")
			{
				SelectPathButton.Text = openFileDialog1.FileName;
			}
		}

		private void AbortButton_Click(object sender, EventArgs e)
		{
			if (OnOffLabel.Text == "On")
			{
				OnOffLabel.Text = "Off";
			}
			cont = false;
			try
			{
				foreach(var player in players)
				{
					player.controls.stop();
				}
				players.Clear();
			}
			catch(Exception) { }
		}
	}
}