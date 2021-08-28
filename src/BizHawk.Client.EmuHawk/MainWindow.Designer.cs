﻿
namespace BizHawk.Client.EmuHawk
{
	partial class MainWindow
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
			this.label8 = new System.Windows.Forms.Label();
			this.EventsThisGameListBox = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.EventNameTextBox = new System.Windows.Forms.TextBox();
			this.RAMValuesToCheckTextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.RAMMinChangeNumericInput = new System.Windows.Forms.NumericUpDown();
			this.label13 = new System.Windows.Forms.Label();
			this.RAMMaxChangeNumericInput = new System.Windows.Forms.NumericUpDown();
			this.label14 = new System.Windows.Forms.Label();
			this.EventDelayNumericInput = new System.Windows.Forms.NumericUpDown();
			this.EventEnabledCheckBox = new System.Windows.Forms.CheckBox();
			this.EventRAMBaseComboBox = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.GamesWithEventsListBox = new System.Windows.Forms.ListBox();
			this.ResetGameToDefaultButton = new System.Windows.Forms.Button();
			this.ShowOrAddCurrentGame = new System.Windows.Forms.Button();
			this.AddNewEventButton = new System.Windows.Forms.Button();
			this.EventCalculationExample = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.EventDomainComboBox = new System.Windows.Forms.ComboBox();
			this.SaveEventChangesButton = new System.Windows.Forms.Button();
			this.RemoveEventButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.RAMMinChangeNumericInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RAMMaxChangeNumericInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EventDelayNumericInput)).BeginInit();
			this.SuspendLayout();
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(12, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(114, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "Games with events";
			// 
			// EventsThisGameListBox
			// 
			this.EventsThisGameListBox.FormattingEnabled = true;
			this.EventsThisGameListBox.Location = new System.Drawing.Point(15, 261);
			this.EventsThisGameListBox.Name = "EventsThisGameListBox";
			this.EventsThisGameListBox.Size = new System.Drawing.Size(326, 56);
			this.EventsThisGameListBox.TabIndex = 19;
			this.EventsThisGameListBox.Tag = "eventSelect";
			this.EventsThisGameListBox.SelectedIndexChanged += new System.EventHandler(this.EventsThisGameListBox_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 244);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(123, 13);
			this.label9.TabIndex = 20;
			this.label9.Tag = "eventSelect";
			this.label9.Text = "Events for this game";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(354, 261);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 13);
			this.label10.TabIndex = 21;
			this.label10.Tag = "eventEdit";
			this.label10.Text = "Event Name";
			this.label10.Click += new System.EventHandler(this.label10_Click);
			// 
			// EventNameTextBox
			// 
			this.EventNameTextBox.Location = new System.Drawing.Point(426, 258);
			this.EventNameTextBox.Name = "EventNameTextBox";
			this.EventNameTextBox.Size = new System.Drawing.Size(362, 20);
			this.EventNameTextBox.TabIndex = 22;
			this.EventNameTextBox.Tag = "eventEdit";
			this.EventNameTextBox.TextChanged += new System.EventHandler(this.EventNameTextBox_TextChanged);
			// 
			// RAMValuesToCheckTextBox
			// 
			this.RAMValuesToCheckTextBox.Location = new System.Drawing.Point(473, 307);
			this.RAMValuesToCheckTextBox.Name = "RAMValuesToCheckTextBox";
			this.RAMValuesToCheckTextBox.Size = new System.Drawing.Size(314, 20);
			this.RAMValuesToCheckTextBox.TabIndex = 23;
			this.RAMValuesToCheckTextBox.Tag = "eventEdit";
			this.RAMValuesToCheckTextBox.TextChanged += new System.EventHandler(this.RAMValuesToCheckTextBox_TextChanged);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(354, 310);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(113, 13);
			this.label11.TabIndex = 24;
			this.label11.Tag = "eventEdit";
			this.label11.Text = "RAM values to check:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(351, 414);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 13);
			this.label12.TabIndex = 25;
			this.label12.Tag = "eventEdit";
			this.label12.Text = "Min Change";
			// 
			// RAMMinChangeNumericInput
			// 
			this.RAMMinChangeNumericInput.Location = new System.Drawing.Point(421, 412);
			this.RAMMinChangeNumericInput.Maximum = new decimal(new int[] {
			2147483647,
			0,
			0,
			0});
			this.RAMMinChangeNumericInput.Minimum = new decimal(new int[] {
			2147483647,
			0,
			0,
			-2147483648});
			this.RAMMinChangeNumericInput.Name = "RAMMinChangeNumericInput";
			this.RAMMinChangeNumericInput.Size = new System.Drawing.Size(138, 20);
			this.RAMMinChangeNumericInput.TabIndex = 26;
			this.RAMMinChangeNumericInput.Tag = "eventEdit";
			this.RAMMinChangeNumericInput.ValueChanged += new System.EventHandler(this.RAMMinChangeNumericInput_ValueChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(567, 416);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(67, 13);
			this.label13.TabIndex = 27;
			this.label13.Tag = "eventEdit";
			this.label13.Text = "Max Change";
			this.label13.Click += new System.EventHandler(this.label13_Click);
			// 
			// RAMMaxChangeNumericInput
			// 
			this.RAMMaxChangeNumericInput.Location = new System.Drawing.Point(635, 412);
			this.RAMMaxChangeNumericInput.Maximum = new decimal(new int[] {
			2147483647,
			0,
			0,
			0});
			this.RAMMaxChangeNumericInput.Minimum = new decimal(new int[] {
			2147483647,
			0,
			0,
			-2147483648});
			this.RAMMaxChangeNumericInput.Name = "RAMMaxChangeNumericInput";
			this.RAMMaxChangeNumericInput.Size = new System.Drawing.Size(152, 20);
			this.RAMMaxChangeNumericInput.TabIndex = 28;
			this.RAMMaxChangeNumericInput.Tag = "eventEdit";
			this.RAMMaxChangeNumericInput.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(351, 440);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(34, 13);
			this.label14.TabIndex = 29;
			this.label14.Tag = "eventEdit";
			this.label14.Text = "Delay";
			// 
			// EventDelayNumericInput
			// 
			this.EventDelayNumericInput.Location = new System.Drawing.Point(391, 438);
			this.EventDelayNumericInput.Name = "EventDelayNumericInput";
			this.EventDelayNumericInput.Size = new System.Drawing.Size(168, 20);
			this.EventDelayNumericInput.TabIndex = 30;
			this.EventDelayNumericInput.Tag = "eventEdit";
			this.EventDelayNumericInput.ValueChanged += new System.EventHandler(this.EventDelayNumericInput_ValueChanged);
			// 
			// EventEnabledCheckBox
			// 
			this.EventEnabledCheckBox.AutoSize = true;
			this.EventEnabledCheckBox.Location = new System.Drawing.Point(425, 284);
			this.EventEnabledCheckBox.Name = "EventEnabledCheckBox";
			this.EventEnabledCheckBox.Size = new System.Drawing.Size(65, 17);
			this.EventEnabledCheckBox.TabIndex = 31;
			this.EventEnabledCheckBox.Tag = "eventEdit";
			this.EventEnabledCheckBox.Text = "Enabled";
			this.EventEnabledCheckBox.UseVisualStyleBackColor = true;
			this.EventEnabledCheckBox.CheckedChanged += new System.EventHandler(this.EventEnabledCheckBox_CheckedChanged);
			// 
			// EventRAMBaseComboBox
			// 
			this.EventRAMBaseComboBox.FormattingEnabled = true;
			this.EventRAMBaseComboBox.Items.AddRange(new object[] {
			"256",
			"100",
			"10"});
			this.EventRAMBaseComboBox.Location = new System.Drawing.Point(391, 333);
			this.EventRAMBaseComboBox.Name = "EventRAMBaseComboBox";
			this.EventRAMBaseComboBox.Size = new System.Drawing.Size(113, 21);
			this.EventRAMBaseComboBox.TabIndex = 32;
			this.EventRAMBaseComboBox.Tag = "eventEdit";
			this.EventRAMBaseComboBox.SelectedIndexChanged += new System.EventHandler(this.EventRAMBaseComboBox_SelectedIndexChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(354, 333);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(31, 13);
			this.label15.TabIndex = 33;
			this.label15.Tag = "eventEdit";
			this.label15.Text = "Base";
			this.label15.Click += new System.EventHandler(this.label15_Click);
			// 
			// GamesWithEventsListBox
			// 
			this.GamesWithEventsListBox.FormattingEnabled = true;
			this.GamesWithEventsListBox.Location = new System.Drawing.Point(12, 26);
			this.GamesWithEventsListBox.Name = "GamesWithEventsListBox";
			this.GamesWithEventsListBox.Size = new System.Drawing.Size(776, 186);
			this.GamesWithEventsListBox.TabIndex = 38;
			this.GamesWithEventsListBox.SelectedIndexChanged += new System.EventHandler(this.GamesWithEventsListBox_SelectedIndexChanged);
			// 
			// ResetGameToDefaultButton
			// 
			this.ResetGameToDefaultButton.Location = new System.Drawing.Point(12, 357);
			this.ResetGameToDefaultButton.Name = "ResetGameToDefaultButton";
			this.ResetGameToDefaultButton.Size = new System.Drawing.Size(152, 23);
			this.ResetGameToDefaultButton.TabIndex = 39;
			this.ResetGameToDefaultButton.Tag = "eventSelect";
			this.ResetGameToDefaultButton.Text = "Reset Game to Default";
			this.ResetGameToDefaultButton.UseVisualStyleBackColor = true;
			this.ResetGameToDefaultButton.Click += new System.EventHandler(this.ResetGameToDefaultButton_Click);
			// 
			// ShowOrAddCurrentGame
			// 
			this.ShowOrAddCurrentGame.Location = new System.Drawing.Point(12, 218);
			this.ShowOrAddCurrentGame.Name = "ShowOrAddCurrentGame";
			this.ShowOrAddCurrentGame.Size = new System.Drawing.Size(152, 23);
			this.ShowOrAddCurrentGame.TabIndex = 40;
			this.ShowOrAddCurrentGame.Text = "Show/Add Current Game";
			this.ShowOrAddCurrentGame.UseVisualStyleBackColor = true;
			this.ShowOrAddCurrentGame.Click += new System.EventHandler(this.button2_Click);
			// 
			// AddNewEventButton
			// 
			this.AddNewEventButton.Location = new System.Drawing.Point(189, 323);
			this.AddNewEventButton.Name = "AddNewEventButton";
			this.AddNewEventButton.Size = new System.Drawing.Size(152, 23);
			this.AddNewEventButton.TabIndex = 41;
			this.AddNewEventButton.Tag = "eventSelect";
			this.AddNewEventButton.Text = "Add New Event";
			this.AddNewEventButton.UseVisualStyleBackColor = true;
			this.AddNewEventButton.Click += new System.EventHandler(this.AddNewEventButton_Click);
			// 
			// EventCalculationExample
			// 
			this.EventCalculationExample.AutoSize = true;
			this.EventCalculationExample.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EventCalculationExample.Location = new System.Drawing.Point(355, 357);
			this.EventCalculationExample.Name = "EventCalculationExample";
			this.EventCalculationExample.Size = new System.Drawing.Size(68, 11);
			this.EventCalculationExample.TabIndex = 42;
			this.EventCalculationExample.Tag = "eventEdit";
			this.EventCalculationExample.Text = "Example: ";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(521, 336);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(43, 13);
			this.label18.TabIndex = 43;
			this.label18.Tag = "eventEdit";
			this.label18.Text = "Domain";
			this.label18.Click += new System.EventHandler(this.label18_Click);
			// 
			// EventDomainComboBox
			// 
			this.EventDomainComboBox.FormattingEnabled = true;
			this.EventDomainComboBox.Items.AddRange(new object[] {
			"DEFAULT",
			"RAM",
			"WRAM",
			"CartRAM",
			"VRAM",
			"HRAM",
			"RDRAM",
			"68K RAM",
			"Work Ram High",
			"Work Ram Low",
			"IWRAM",
			"EWRAM"});
			this.EventDomainComboBox.Location = new System.Drawing.Point(570, 333);
			this.EventDomainComboBox.Name = "EventDomainComboBox";
			this.EventDomainComboBox.Size = new System.Drawing.Size(218, 21);
			this.EventDomainComboBox.TabIndex = 44;
			this.EventDomainComboBox.Tag = "eventEdit";
			this.EventDomainComboBox.Text = "DEFAULT";
			this.EventDomainComboBox.SelectedIndexChanged += new System.EventHandler(this.EventDomainComboBox_SelectedIndexChanged);
			// 
			// SaveEventChangesButton
			// 
			this.SaveEventChangesButton.Location = new System.Drawing.Point(635, 440);
			this.SaveEventChangesButton.Name = "SaveEventChangesButton";
			this.SaveEventChangesButton.Size = new System.Drawing.Size(152, 23);
			this.SaveEventChangesButton.TabIndex = 45;
			this.SaveEventChangesButton.Tag = "eventSelect";
			this.SaveEventChangesButton.Text = "Save Changes";
			this.SaveEventChangesButton.UseVisualStyleBackColor = true;
			this.SaveEventChangesButton.Click += new System.EventHandler(this.SaveEventChangesButton_Click);
			// 
			// RemoveEventButton
			// 
			this.RemoveEventButton.Location = new System.Drawing.Point(12, 323);
			this.RemoveEventButton.Name = "RemoveEventButton";
			this.RemoveEventButton.Size = new System.Drawing.Size(152, 23);
			this.RemoveEventButton.TabIndex = 47;
			this.RemoveEventButton.Text = "Remove Event";
			this.RemoveEventButton.UseVisualStyleBackColor = true;
			this.RemoveEventButton.Click += new System.EventHandler(this.RemoveEventButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 479);
			this.Controls.Add(this.RemoveEventButton);
			this.Controls.Add(this.SaveEventChangesButton);
			this.Controls.Add(this.EventDomainComboBox);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.EventCalculationExample);
			this.Controls.Add(this.AddNewEventButton);
			this.Controls.Add(this.ShowOrAddCurrentGame);
			this.Controls.Add(this.ResetGameToDefaultButton);
			this.Controls.Add(this.GamesWithEventsListBox);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.EventRAMBaseComboBox);
			this.Controls.Add(this.EventEnabledCheckBox);
			this.Controls.Add(this.EventDelayNumericInput);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.RAMMaxChangeNumericInput);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.RAMMinChangeNumericInput);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.RAMValuesToCheckTextBox);
			this.Controls.Add(this.EventNameTextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.EventsThisGameListBox);
			this.Controls.Add(this.label8);
			this.Name = "MainWindow";
			this.Text = "Event Shuffler Setup";
			((System.ComponentModel.ISupportInitialize)(this.RAMMinChangeNumericInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RAMMaxChangeNumericInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EventDelayNumericInput)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListBox EventsThisGameListBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox EventNameTextBox;
		private System.Windows.Forms.TextBox RAMValuesToCheckTextBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown RAMMinChangeNumericInput;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.NumericUpDown RAMMaxChangeNumericInput;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown EventDelayNumericInput;
		private System.Windows.Forms.CheckBox EventEnabledCheckBox;
		private System.Windows.Forms.ComboBox EventRAMBaseComboBox;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ListBox GamesWithEventsListBox;
		private System.Windows.Forms.Button ResetGameToDefaultButton;
		private System.Windows.Forms.Button ShowOrAddCurrentGame;
		private System.Windows.Forms.Button AddNewEventButton;
		private System.Windows.Forms.Label EventCalculationExample;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox EventDomainComboBox;
		private System.Windows.Forms.Button SaveEventChangesButton;
		private System.Windows.Forms.Button RemoveEventButton;
	}
}

