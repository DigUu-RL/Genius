using Genius.Classes;
using Genius.Properties;
using Color = Genius.Enums.Color;

namespace Genius.Forms
{
	public partial class MainForm : Form
	{
		private List<Color> Sequence { get; } = new();
		private List<Color> UserSequence { get; } = new();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LockOrUnlockButtons(false);
		}

		private async void PbYellow_MouseDown(object sender, MouseEventArgs e)
		{
			pbYellow.Image = Resources.lit_yellow;
			UserSequence.Add(Color.Yellow);
			await Play();
		}

		private void PbYellow_MouseUp(object sender, MouseEventArgs e)
		{
			TurnOffLights();
		}

		private async void PbBlue_MouseDown(object sender, MouseEventArgs e)
		{
			pbBlue.Image = Resources.lit_blue;
			UserSequence.Add(Color.Blue);
			await Play();
		}

		private void PbBlue_MouseUp(object sender, MouseEventArgs e)
		{
			TurnOffLights();
		}

		private async void PbGreen_MouseDown(object sender, MouseEventArgs e)
		{
			pbGreen.Image = Resources.lit_green;
			UserSequence.Add(Color.Green);
			await Play();
		}

		private void PbGreen_MouseUp(object sender, MouseEventArgs e)
		{
			TurnOffLights();
		}

		private async void PbRed_MouseDown(object sender, MouseEventArgs e)
		{
			pbRed.Image = Resources.lit_red;
			UserSequence.Add(Color.Red);
			await Play();
		}

		private void PbRed_MouseUp(object sender, MouseEventArgs e)
		{
			TurnOffLights();
		}

		private async void BtnStart_Click(object sender, EventArgs e)
		{
			if (rbEasy.Checked)
			{
				lblSequenceValue.Text = "15";
			}
			else if (rbNormal.Checked)
			{
				lblSequenceValue.Text = "20";
			}
			else if (rbHard.Checked)
			{
				lblSequenceValue.Text = "30";
			}
			else
			{
				lblSequenceValue.Text = "50";
			}

			CreateSequence();

			await ShowSequenceAsync();
		}

		private void CreateSequence()
		{
			Sequence.Clear();

			for (int i = 0; i < Convert.ToInt32(lblSequenceValue.Text); i++)
			{
				var random = new Random();
				int x = random.Next(4);
				Sequence.Add(x.ToColor());
			}
		}

		private async Task ShowSequenceAsync()
		{
			LockOrUnlockButtons(false);

			int count = default;
			int currentPosition = Convert.ToInt32(lblPositionValue.Text);
			currentPosition++;

			foreach (Color item in Sequence)
			{
				count++;

				await Task.Delay(300);

				switch (item)
				{
					case Color.Yellow:
						pbYellow.Image = Resources.lit_yellow;
						break;

					case Color.Blue:
						pbBlue.Image = Resources.lit_blue;
						break;

					case Color.Green:
						pbGreen.Image = Resources.lit_green;
						break;

					case Color.Red:
						pbRed.Image = Resources.lit_red;
						break;
				}

				await Task.Delay(300);

				TurnOffLights();

				if (count == currentPosition)
				{
					break;
				}
			}

			lblPositionValue.Text = currentPosition.ToString();

			LockOrUnlockButtons(true);
		}

		private void TurnOffLights()
		{
			pbYellow.Image = Resources.yellow;
			pbBlue.Image = Resources.blue;
			pbGreen.Image = Resources.green;
			pbRed.Image = Resources.red;
		}

		private async Task Play()
		{
			int score = Convert.ToInt32(lblScoreValue.Text);
			bool isFailure = false;

			int count = default;

			for (int i = 0; i < UserSequence.Count; i++)
			{
				if (Sequence[i] == UserSequence[i])
				{
					count++;

					score += 5;
					lblScoreValue.Text = score.ToString();
				}
				else
				{
					MessageBox.Show("Wrong! Thanks for playing Genius :)");

					TurnOffLights();

					lblScoreValue.Text = "0";
					lblPositionValue.Text = "0";

					Sequence.Clear();
					UserSequence.Clear();

					isFailure = true;

					break;
				}
			}

			if (count == Convert.ToInt32(lblSequenceValue.Text))
			{
				MessageBox.Show("Congrats! You finalized the Genius! :)" + 
					$"\nYour score: {lblScoreValue.Text}");

				Sequence.Clear();
				UserSequence.Clear();

				lblSequenceValue.Text = "0";
				lblPositionValue.Text = "0";
				lblScoreValue.Text = "0";
			}

			if (count == Convert.ToInt32(lblPositionValue.Text))
			{
				if (!isFailure)
				{
					UserSequence.Clear();

					await Task.Delay(200);
					await ShowSequenceAsync();
				}
			}
		}

		/// <summary>
		/// Bloqueia ou desbloqueia os botões das cores
		/// <para>Passe <see cref="true"/> para desbloquear os botões</para>
		/// <para>Passe <see cref="false"/> para bloquear os botões</para>
		/// </summary>
		private void LockOrUnlockButtons(bool value)
		{
			pbYellow.Enabled = value;
			pbBlue.Enabled = value;
			pbGreen.Enabled = value;
			pbRed.Enabled = value;
		}
	}
}
