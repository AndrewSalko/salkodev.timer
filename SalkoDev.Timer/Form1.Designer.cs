namespace SalkoDev.Timer
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
			if (disposing && (components != null))
			{
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this._LabelTimer = new System.Windows.Forms.Label();
			this._ButtonStart = new System.Windows.Forms.Button();
			this._ButtonCancel = new System.Windows.Forms.Button();
			this._LabelChooseMinutes = new System.Windows.Forms.Label();
			this._ComboBoxInterval = new System.Windows.Forms.ComboBox();
			this._Timer = new System.Windows.Forms.Timer(this.components);
			this._Button5 = new System.Windows.Forms.Button();
			this._Button10 = new System.Windows.Forms.Button();
			this._Button15 = new System.Windows.Forms.Button();
			this._Button20 = new System.Windows.Forms.Button();
			this._Button25 = new System.Windows.Forms.Button();
			this._Button30 = new System.Windows.Forms.Button();
			this._Button40 = new System.Windows.Forms.Button();
			this._Button45 = new System.Windows.Forms.Button();
			this._Button50 = new System.Windows.Forms.Button();
			this._Button60 = new System.Windows.Forms.Button();
			this._Button120 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Время до конца:";
			// 
			// _LabelTimer
			// 
			this._LabelTimer.AutoSize = true;
			this._LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._LabelTimer.Location = new System.Drawing.Point(12, 38);
			this._LabelTimer.Name = "_LabelTimer";
			this._LabelTimer.Size = new System.Drawing.Size(145, 55);
			this._LabelTimer.TabIndex = 1;
			this._LabelTimer.Text = "00:00";
			// 
			// _ButtonStart
			// 
			this._ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._ButtonStart.Location = new System.Drawing.Point(12, 238);
			this._ButtonStart.Name = "_ButtonStart";
			this._ButtonStart.Size = new System.Drawing.Size(132, 23);
			this._ButtonStart.TabIndex = 2;
			this._ButtonStart.Text = "Старт таймера";
			this._ButtonStart.UseVisualStyleBackColor = true;
			this._ButtonStart.Click += new System.EventHandler(this._ButtonStart_Click);
			// 
			// _ButtonCancel
			// 
			this._ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._ButtonCancel.Location = new System.Drawing.Point(150, 238);
			this._ButtonCancel.Name = "_ButtonCancel";
			this._ButtonCancel.Size = new System.Drawing.Size(123, 23);
			this._ButtonCancel.TabIndex = 3;
			this._ButtonCancel.Text = "Отменить";
			this._ButtonCancel.UseVisualStyleBackColor = true;
			this._ButtonCancel.Click += new System.EventHandler(this._ButtonCancel_Click);
			// 
			// _LabelChooseMinutes
			// 
			this._LabelChooseMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._LabelChooseMinutes.AutoSize = true;
			this._LabelChooseMinutes.Location = new System.Drawing.Point(9, 213);
			this._LabelChooseMinutes.Name = "_LabelChooseMinutes";
			this._LabelChooseMinutes.Size = new System.Drawing.Size(96, 13);
			this._LabelChooseMinutes.TabIndex = 4;
			this._LabelChooseMinutes.Text = "Время в минутах:";
			// 
			// _ComboBoxInterval
			// 
			this._ComboBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._ComboBoxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._ComboBoxInterval.FormattingEnabled = true;
			this._ComboBoxInterval.Location = new System.Drawing.Point(108, 210);
			this._ComboBoxInterval.Name = "_ComboBoxInterval";
			this._ComboBoxInterval.Size = new System.Drawing.Size(165, 21);
			this._ComboBoxInterval.TabIndex = 5;
			// 
			// _Timer
			// 
			this._Timer.Interval = 1000;
			this._Timer.Tick += new System.EventHandler(this._Timer_Tick);
			// 
			// _Button5
			// 
			this._Button5.Location = new System.Drawing.Point(15, 112);
			this._Button5.Name = "_Button5";
			this._Button5.Size = new System.Drawing.Size(75, 23);
			this._Button5.TabIndex = 6;
			this._Button5.Tag = "5";
			this._Button5.Text = "5 минут";
			this._Button5.UseVisualStyleBackColor = true;
			this._Button5.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button10
			// 
			this._Button10.Location = new System.Drawing.Point(96, 112);
			this._Button10.Name = "_Button10";
			this._Button10.Size = new System.Drawing.Size(52, 23);
			this._Button10.TabIndex = 7;
			this._Button10.Tag = "10";
			this._Button10.Text = "10";
			this._Button10.UseVisualStyleBackColor = true;
			this._Button10.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button15
			// 
			this._Button15.Location = new System.Drawing.Point(154, 112);
			this._Button15.Name = "_Button15";
			this._Button15.Size = new System.Drawing.Size(52, 23);
			this._Button15.TabIndex = 8;
			this._Button15.Tag = "15";
			this._Button15.Text = "15";
			this._Button15.UseVisualStyleBackColor = true;
			this._Button15.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button20
			// 
			this._Button20.Location = new System.Drawing.Point(212, 112);
			this._Button20.Name = "_Button20";
			this._Button20.Size = new System.Drawing.Size(52, 23);
			this._Button20.TabIndex = 9;
			this._Button20.Tag = "20";
			this._Button20.Text = "20";
			this._Button20.UseVisualStyleBackColor = true;
			this._Button20.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button25
			// 
			this._Button25.Location = new System.Drawing.Point(270, 112);
			this._Button25.Name = "_Button25";
			this._Button25.Size = new System.Drawing.Size(52, 23);
			this._Button25.TabIndex = 10;
			this._Button25.Tag = "25";
			this._Button25.Text = "25";
			this._Button25.UseVisualStyleBackColor = true;
			this._Button25.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button30
			// 
			this._Button30.Location = new System.Drawing.Point(328, 112);
			this._Button30.Name = "_Button30";
			this._Button30.Size = new System.Drawing.Size(75, 23);
			this._Button30.TabIndex = 11;
			this._Button30.Tag = "30";
			this._Button30.Text = "30 минут";
			this._Button30.UseVisualStyleBackColor = true;
			this._Button30.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button40
			// 
			this._Button40.Location = new System.Drawing.Point(15, 141);
			this._Button40.Name = "_Button40";
			this._Button40.Size = new System.Drawing.Size(75, 23);
			this._Button40.TabIndex = 12;
			this._Button40.Tag = "40";
			this._Button40.Text = "40 минут";
			this._Button40.UseVisualStyleBackColor = true;
			this._Button40.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button45
			// 
			this._Button45.Location = new System.Drawing.Point(96, 141);
			this._Button45.Name = "_Button45";
			this._Button45.Size = new System.Drawing.Size(52, 23);
			this._Button45.TabIndex = 13;
			this._Button45.Tag = "45";
			this._Button45.Text = "45";
			this._Button45.UseVisualStyleBackColor = true;
			this._Button45.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button50
			// 
			this._Button50.Location = new System.Drawing.Point(154, 141);
			this._Button50.Name = "_Button50";
			this._Button50.Size = new System.Drawing.Size(52, 23);
			this._Button50.TabIndex = 14;
			this._Button50.Tag = "50";
			this._Button50.Text = "50";
			this._Button50.UseVisualStyleBackColor = true;
			this._Button50.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button60
			// 
			this._Button60.Location = new System.Drawing.Point(212, 141);
			this._Button60.Name = "_Button60";
			this._Button60.Size = new System.Drawing.Size(75, 23);
			this._Button60.TabIndex = 15;
			this._Button60.Tag = "60";
			this._Button60.Text = "60 минут";
			this._Button60.UseVisualStyleBackColor = true;
			this._Button60.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// _Button120
			// 
			this._Button120.Location = new System.Drawing.Point(293, 141);
			this._Button120.Name = "_Button120";
			this._Button120.Size = new System.Drawing.Size(110, 23);
			this._Button120.TabIndex = 16;
			this._Button120.Tag = "120";
			this._Button120.Text = "120 минут";
			this._Button120.UseVisualStyleBackColor = true;
			this._Button120.Click += new System.EventHandler(this._ButtonPredefined_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 273);
			this.Controls.Add(this._Button120);
			this.Controls.Add(this._Button60);
			this.Controls.Add(this._Button50);
			this.Controls.Add(this._Button45);
			this.Controls.Add(this._Button40);
			this.Controls.Add(this._Button30);
			this.Controls.Add(this._Button25);
			this.Controls.Add(this._Button20);
			this.Controls.Add(this._Button15);
			this.Controls.Add(this._Button10);
			this.Controls.Add(this._Button5);
			this.Controls.Add(this._ComboBoxInterval);
			this.Controls.Add(this._LabelChooseMinutes);
			this.Controls.Add(this._ButtonCancel);
			this.Controls.Add(this._ButtonStart);
			this.Controls.Add(this._LabelTimer);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Таймер";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label _LabelTimer;
		private System.Windows.Forms.Button _ButtonStart;
		private System.Windows.Forms.Button _ButtonCancel;
		private System.Windows.Forms.Label _LabelChooseMinutes;
		private System.Windows.Forms.ComboBox _ComboBoxInterval;
		private System.Windows.Forms.Timer _Timer;
		private System.Windows.Forms.Button _Button5;
		private System.Windows.Forms.Button _Button10;
		private System.Windows.Forms.Button _Button15;
		private System.Windows.Forms.Button _Button20;
		private System.Windows.Forms.Button _Button25;
		private System.Windows.Forms.Button _Button30;
		private System.Windows.Forms.Button _Button40;
		private System.Windows.Forms.Button _Button45;
		private System.Windows.Forms.Button _Button50;
		private System.Windows.Forms.Button _Button60;
		private System.Windows.Forms.Button _Button120;
	}
}

