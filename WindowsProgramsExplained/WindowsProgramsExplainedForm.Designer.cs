namespace WindowsProgramsExplained
{
	partial class WindowsProgramsExplainedForm
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
			this.tabMainControl = new System.Windows.Forms.TabControl();
			this.tabInstalledApplications = new System.Windows.Forms.TabPage();
			this.applicationList1 = new WindowsProgramsExplained.ApplicationList();
			this.tabMainControl.SuspendLayout();
			this.tabInstalledApplications.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMainControl
			// 
			this.tabMainControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMainControl.Controls.Add(this.tabInstalledApplications);
			this.tabMainControl.Location = new System.Drawing.Point(12, 12);
			this.tabMainControl.Name = "tabMainControl";
			this.tabMainControl.SelectedIndex = 0;
			this.tabMainControl.Size = new System.Drawing.Size(782, 348);
			this.tabMainControl.TabIndex = 0;
			// 
			// tabInstalledApplications
			// 
			this.tabInstalledApplications.AutoScroll = true;
			this.tabInstalledApplications.Controls.Add(this.applicationList1);
			this.tabInstalledApplications.Location = new System.Drawing.Point(4, 22);
			this.tabInstalledApplications.Name = "tabInstalledApplications";
			this.tabInstalledApplications.Padding = new System.Windows.Forms.Padding(3);
			this.tabInstalledApplications.Size = new System.Drawing.Size(774, 322);
			this.tabInstalledApplications.TabIndex = 0;
			this.tabInstalledApplications.Text = "Installed applications";
			this.tabInstalledApplications.UseVisualStyleBackColor = true;
			// 
			// applicationList1
			// 
			this.applicationList1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.applicationList1.AutoScroll = true;
			this.applicationList1.AutoSize = true;
			this.applicationList1.Location = new System.Drawing.Point(6, 6);
			this.applicationList1.Name = "applicationList1";
			this.applicationList1.Size = new System.Drawing.Size(767, 10997);
			this.applicationList1.TabIndex = 0;
			// 
			// WindowsProgramsExplainedForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(806, 372);
			this.Controls.Add(this.tabMainControl);
			this.Name = "WindowsProgramsExplainedForm";
			this.Text = "Windows Programs Explained";
			this.tabMainControl.ResumeLayout(false);
			this.tabInstalledApplications.ResumeLayout(false);
			this.tabInstalledApplications.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabMainControl;
		private System.Windows.Forms.TabPage tabInstalledApplications;
		private ApplicationList applicationList1;
	}
}

