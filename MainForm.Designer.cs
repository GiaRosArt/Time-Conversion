/*
 * Created by SharpDevelop.
 * User: GiaRosArt
 * Date: 08/09/2023
 * Time: 09:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Time_Conversion
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtValue = new System.Windows.Forms.TextBox();
			this.cmbValue = new System.Windows.Forms.ComboBox();
			this.txtResults = new System.Windows.Forms.TextBox();
			this.cmbResults = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtValue
			// 
			this.txtValue.Location = new System.Drawing.Point(28, 66);
			this.txtValue.Name = "txtValue";
			this.txtValue.Size = new System.Drawing.Size(166, 20);
			this.txtValue.TabIndex = 2;
			this.txtValue.Text = "1";
			// 
			// cmbValue
			// 
			this.cmbValue.FormattingEnabled = true;
			this.cmbValue.Items.AddRange(new object[] {
									"Hours",
									"Minutes",
									"Seconds"});
			this.cmbValue.Location = new System.Drawing.Point(28, 23);
			this.cmbValue.Name = "cmbValue";
			this.cmbValue.Size = new System.Drawing.Size(166, 21);
			this.cmbValue.TabIndex = 1;
			// 
			// txtResults
			// 
			this.txtResults.Location = new System.Drawing.Point(249, 66);
			this.txtResults.Name = "txtResults";
			this.txtResults.ReadOnly = true;
			this.txtResults.Size = new System.Drawing.Size(166, 20);
			this.txtResults.TabIndex = 1;
			// 
			// cmbResults
			// 
			this.cmbResults.FormattingEnabled = true;
			this.cmbResults.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.cmbResults.Items.AddRange(new object[] {
									"Hours",
									"Minutes",
									"Seconds"});
			this.cmbResults.Location = new System.Drawing.Point(249, 23);
			this.cmbResults.Name = "cmbResults";
			this.cmbResults.Size = new System.Drawing.Size(166, 21);
			this.cmbResults.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(199, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "TO";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(200, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "=";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(440, 23);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 63);
			this.btnCalculate.TabIndex = 5;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.BtnCalculateClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 110);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbResults);
			this.Controls.Add(this.txtResults);
			this.Controls.Add(this.cmbValue);
			this.Controls.Add(this.txtValue);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Time Conversion";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbResults;
		private System.Windows.Forms.TextBox txtResults;
		private System.Windows.Forms.ComboBox cmbValue;
		private System.Windows.Forms.TextBox txtValue;
	}
}
