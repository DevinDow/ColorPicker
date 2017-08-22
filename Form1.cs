using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ColorPicker
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private bool changing = false;

		private System.Windows.Forms.Button button;
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Label lblRed;
		private System.Windows.Forms.NumericUpDown numRed;
		private System.Windows.Forms.NumericUpDown numGreen;
		private System.Windows.Forms.Label lblGreen;
		private System.Windows.Forms.NumericUpDown numBlue;
		private System.Windows.Forms.Label lblBlue;

		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();

			for (KnownColor i = KnownColor.ActiveBorder; i <= KnownColor.YellowGreen; i++)
				comboBox.Items.Add(i);
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.button = new System.Windows.Forms.Button();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.lblRed = new System.Windows.Forms.Label();
			this.numRed = new System.Windows.Forms.NumericUpDown();
			this.numGreen = new System.Windows.Forms.NumericUpDown();
			this.lblGreen = new System.Windows.Forms.Label();
			this.numBlue = new System.Windows.Forms.NumericUpDown();
			this.lblBlue = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numRed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numGreen)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numBlue)).BeginInit();
			this.SuspendLayout();
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(16, 16);
			this.button.Name = "button";
			this.button.TabIndex = 0;
			this.button.Text = "Pick Color";
			this.button.Click += new System.EventHandler(this.button_Click);
			// 
			// comboBox
			// 
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.Location = new System.Drawing.Point(120, 16);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(152, 21);
			this.comboBox.Sorted = true;
			this.comboBox.TabIndex = 1;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// lblRed
			// 
			this.lblRed.Location = new System.Drawing.Point(32, 60);
			this.lblRed.Name = "lblRed";
			this.lblRed.Size = new System.Drawing.Size(48, 20);
			this.lblRed.TabIndex = 2;
			this.lblRed.Text = "Red";
			this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numRed
			// 
			this.numRed.Location = new System.Drawing.Point(96, 60);
			this.numRed.Maximum = new System.Decimal(new int[] {
																					255,
																					0,
																					0,
																					0});
			this.numRed.Name = "numRed";
			this.numRed.Size = new System.Drawing.Size(56, 20);
			this.numRed.TabIndex = 4;
			this.numRed.ValueChanged += new System.EventHandler(this.num_ValueChanged);
			// 
			// numGreen
			// 
			this.numGreen.Location = new System.Drawing.Point(96, 88);
			this.numGreen.Maximum = new System.Decimal(new int[] {
																					  255,
																					  0,
																					  0,
																					  0});
			this.numGreen.Name = "numGreen";
			this.numGreen.Size = new System.Drawing.Size(56, 20);
			this.numGreen.TabIndex = 6;
			this.numGreen.ValueChanged += new System.EventHandler(this.num_ValueChanged);
			// 
			// lblGreen
			// 
			this.lblGreen.Location = new System.Drawing.Point(32, 88);
			this.lblGreen.Name = "lblGreen";
			this.lblGreen.Size = new System.Drawing.Size(48, 20);
			this.lblGreen.TabIndex = 5;
			this.lblGreen.Text = "Green";
			this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// numBlue
			// 
			this.numBlue.Location = new System.Drawing.Point(96, 120);
			this.numBlue.Maximum = new System.Decimal(new int[] {
																					 255,
																					 0,
																					 0,
																					 0});
			this.numBlue.Name = "numBlue";
			this.numBlue.Size = new System.Drawing.Size(56, 20);
			this.numBlue.TabIndex = 8;
			this.numBlue.ValueChanged += new System.EventHandler(this.num_ValueChanged);
			// 
			// lblBlue
			// 
			this.lblBlue.Location = new System.Drawing.Point(32, 120);
			this.lblBlue.Name = "lblBlue";
			this.lblBlue.Size = new System.Drawing.Size(48, 20);
			this.lblBlue.TabIndex = 7;
			this.lblBlue.Text = "Blue";
			this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 265);
			this.Controls.Add(this.numBlue);
			this.Controls.Add(this.lblBlue);
			this.Controls.Add(this.numGreen);
			this.Controls.Add(this.lblGreen);
			this.Controls.Add(this.numRed);
			this.Controls.Add(this.lblRed);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.button);
			this.Name = "Form1";
			this.Text = "Color Picker";
			((System.ComponentModel.ISupportInitialize)(this.numRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numGreen)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numBlue)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}


		private void button_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult res = colorDialog.ShowDialog();
			BackColor = colorDialog.Color;
			changing = true;
			setNumerics();
			setComboBoxSelection();
			changing = false;
		}

		private void setComboBoxSelection()
		{
			if (BackColor.IsKnownColor)
				comboBox.SelectedItem = BackColor.ToKnownColor();
			else
				comboBox.SelectedIndex = -1;
		}

		private void comboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (changing)
				return;

			if (comboBox.SelectedIndex >= 0)
			{
				BackColor = Color.FromName(comboBox.Items[comboBox.SelectedIndex].ToString());
				changing = true;
				setNumerics();
				changing = false;
			}
		}

		private void setNumerics()
		{
			numRed.Value = BackColor.R;
			numGreen.Value = BackColor.G;
			numBlue.Value = BackColor.B;
		}

		private void num_ValueChanged(object sender, System.EventArgs e)
		{
			if (changing)
				return;

			BackColor = Color.FromArgb((int)numRed.Value, (int)numGreen.Value, (int)numBlue.Value);		
			changing = true;
			setComboBoxSelection();
			changing = false;
		}
	}
}
