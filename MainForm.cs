/*
 * Created by SharpDevelop.
 * User: GiaRosArt
 * Date: 08/09/2023
 * Time: 09:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Time_Conversion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			cmbValue.SelectedItem = "Hours";
			cmbResults.SelectedItem = "Minutes";
			txtResults.Text = (float.Parse(txtValue.Text) * 60).ToString();
			//
		}
		
		
		void BtnCalculateClick(object sender, EventArgs e)
		{	
			float v;
			if(float.TryParse(txtValue.Text, out v))
			{
				if (cmbValue.Text == "Hours")
				{
					if (cmbResults.Text == "Hours")
					{
						txtResults.Text = txtValue.Text;
					}
					if (cmbResults.Text == "Minutes")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 60).ToString();
					}
					if (cmbResults.Text == "Seconds")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 3600).ToString();
					}
				}
				if (cmbValue.Text == "Minutes")
				{
					if (cmbResults.Text == "Hours")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 60).ToString();
					}
					if (cmbResults.Text == "Minutes")
					{
						txtResults.Text = txtValue.Text;
					}
					if (cmbResults.Text == "Seconds")
					{
						txtResults.Text = (float.Parse(txtValue.Text) * 60).ToString();
					}
				}
				if (cmbValue.Text == "Seconds")
				{
					if (cmbResults.Text == "Hours")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 3600).ToString();
					}
					if (cmbResults.Text == "Minutes")
					{
						txtResults.Text = (float.Parse(txtValue.Text) / 60).ToString();
					}
					if (cmbResults.Text == "Seconds")
					{
						txtResults.Text = txtValue.Text;
					}
				}
			}
			else
			{
				txtResults.Text = "Please inform a valid number!";
			}
		}
	}
}
