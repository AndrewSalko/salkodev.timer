using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace SalkoDev.Timer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Button[] _ButtonsPredefined;

		int _SecondsLeft;

		private void Form1_Load(object sender, EventArgs e)
		{
			_ComboBoxInterval.Items.Clear();
			for (int i = 2; i < 121; i++)
			{
				_ComboBoxInterval.Items.Add(i);
			}

			_ComboBoxInterval.SelectedIndex = 0;
			_LabelTimer.Text = string.Empty;

			_ButtonsPredefined = new Button[]
			{
				_Button5, _Button10, _Button15, _Button20, _Button25, _Button30, _Button40, _Button45, _Button50, _Button60, _Button120
			};

			_UpdateCommands();
		}

		void _UpdateCommands()
		{
			bool timerEnabled = _Timer.Enabled;

			_ButtonCancel.Enabled = timerEnabled;
			_ButtonStart.Enabled = !timerEnabled;

			_ComboBoxInterval.Enabled = !timerEnabled;

			foreach (Button button in _ButtonsPredefined)
			{
				button.Enabled = !timerEnabled;
			}
		}

		private void _Timer_Tick(object sender, EventArgs e)
		{
			_SecondsLeft--;
			if (_SecondsLeft <= 0)
			{
				_PlaySound();
				_StopTimer();

				_LabelTimer.Text = "Время вышло!";
			}
			else
			{
				string minSec = string.Format("{0}:{1:00}", _SecondsLeft / 60, _SecondsLeft % 60);
				_LabelTimer.Text = minSec;				
			}
		}

		void _PlaySound()
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.WindowState = FormWindowState.Normal;				
			}

			this.BringToFront();
			this.Activate();

			string mediaPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), @"Media\notify.wav");			
			SoundPlayer simpleSound = new SoundPlayer(mediaPath);
			simpleSound.Play();
		}

		void _StopTimer()
		{
			if (_Timer.Enabled)
			{
				_Timer.Enabled = false;
			}

			_UpdateCommands();
		}

		private void _ButtonStart_Click(object sender, EventArgs e)
		{
			int minutes = (int)_ComboBoxInterval.SelectedItem;

			_Start(minutes);
		}

		void _Start(int minutes)
		{
			if (_Timer.Enabled)
				return;

			_Timer.Enabled = true;

			_SecondsLeft = minutes * 60;

			_UpdateCommands();
		}


		private void _ButtonCancel_Click(object sender, EventArgs e)
		{
			_StopTimer();
		}

		private void _ButtonPredefined_Click(object sender, EventArgs e)
		{
			try
			{
				Button b = (Button)sender;
				int minutes = int.Parse(b.Tag as string);

				_Start(minutes);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
