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

			_UpdateCommands();
		}

		void _UpdateCommands()
		{
			_ButtonCancel.Enabled = _Timer.Enabled;
			_ButtonStart.Enabled = !_Timer.Enabled;

			_ComboBoxInterval.Enabled = !_Timer.Enabled;
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
			if (_Timer.Enabled)
				return;

			_Timer.Enabled = true;

			int minutes = (int)_ComboBoxInterval.SelectedItem;
			_SecondsLeft = minutes * 60;
			//_SecondsLeft = 10;


			_UpdateCommands();
		}

		private void _ButtonCancel_Click(object sender, EventArgs e)
		{
			_StopTimer();
		}

	}
}
