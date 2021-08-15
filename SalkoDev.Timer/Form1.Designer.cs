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
			this._ButtonStart.Location = new System.Drawing.Point(12, 168);
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
			this._ButtonCancel.Location = new System.Drawing.Point(150, 168);
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
			this._LabelChooseMinutes.Location = new System.Drawing.Point(9, 143);
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
			this._ComboBoxInterval.Location = new System.Drawing.Point(108, 140);
			this._ComboBoxInterval.Name = "_ComboBoxInterval";
			this._ComboBoxInterval.Size = new System.Drawing.Size(165, 21);
			this._ComboBoxInterval.TabIndex = 5;
			// 
			// _Timer
			// 
			this._Timer.Interval = 1000;
			this._Timer.Tick += new System.EventHandler(this._Timer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 203);
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
	}
}

