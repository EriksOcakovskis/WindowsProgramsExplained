namespace WindowsProgramsExplained
{
	partial class ApplicationListItem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_DisplayName = new System.Windows.Forms.Label();
			this.label_ShortDescription = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_Importance = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label_PerformanceImpact = new System.Windows.Forms.Label();
			this.button_Uninstall = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label_DisplayName
			// 
			this.label_DisplayName.AutoSize = true;
			this.label_DisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label_DisplayName.Location = new System.Drawing.Point(-3, 10);
			this.label_DisplayName.Name = "label_DisplayName";
			this.label_DisplayName.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label_DisplayName.Size = new System.Drawing.Size(126, 13);
			this.label_DisplayName.TabIndex = 0;
			this.label_DisplayName.Text = "Application Name";
			// 
			// label_ShortDescription
			// 
			this.label_ShortDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_ShortDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label_ShortDescription.Location = new System.Drawing.Point(518, 0);
			this.label_ShortDescription.Name = "label_ShortDescription";
			this.label_ShortDescription.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label_ShortDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label_ShortDescription.Size = new System.Drawing.Size(249, 33);
			this.label_ShortDescription.TabIndex = 1;
			this.label_ShortDescription.Text = "Short but descriptive description.";
			this.label_ShortDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label2.Location = new System.Drawing.Point(-3, 43);
			this.label2.Name = "label2";
			this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label2.Size = new System.Drawing.Size(94, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Importance:";
			// 
			// label_Importance
			// 
			this.label_Importance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_Importance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label_Importance.Location = new System.Drawing.Point(518, 33);
			this.label_Importance.Name = "label_Importance";
			this.label_Importance.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label_Importance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label_Importance.Size = new System.Drawing.Size(249, 33);
			this.label_Importance.TabIndex = 3;
			this.label_Importance.Text = "Critical";
			this.label_Importance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label5.Location = new System.Drawing.Point(-3, 76);
			this.label5.Name = "label5";
			this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label5.Size = new System.Drawing.Size(143, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Performance impact:";
			// 
			// label_PerformanceImpact
			// 
			this.label_PerformanceImpact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label_PerformanceImpact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
			this.label_PerformanceImpact.Location = new System.Drawing.Point(518, 66);
			this.label_PerformanceImpact.Name = "label_PerformanceImpact";
			this.label_PerformanceImpact.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.label_PerformanceImpact.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label_PerformanceImpact.Size = new System.Drawing.Size(249, 33);
			this.label_PerformanceImpact.TabIndex = 5;
			this.label_PerformanceImpact.Text = "High";
			this.label_PerformanceImpact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button_Uninstall
			// 
			this.button_Uninstall.Location = new System.Drawing.Point(655, 114);
			this.button_Uninstall.Name = "button_Uninstall";
			this.button_Uninstall.Size = new System.Drawing.Size(106, 35);
			this.button_Uninstall.TabIndex = 6;
			this.button_Uninstall.Text = "Uninstall";
			this.button_Uninstall.UseVisualStyleBackColor = true;
			this.button_Uninstall.Click += new System.EventHandler(this.button_Uninstall_Click);
			// 
			// ApplicationListItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.Controls.Add(this.button_Uninstall);
			this.Controls.Add(this.label_PerformanceImpact);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label_Importance);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label_ShortDescription);
			this.Controls.Add(this.label_DisplayName);
			this.Name = "ApplicationListItem";
			this.Size = new System.Drawing.Size(764, 152);
			this.Load += new System.EventHandler(this.ApplicationListItem_Load);
			this.Click += new System.EventHandler(this.ApplicationListItem_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_DisplayName;
		private System.Windows.Forms.Label label_ShortDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_Importance;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label_PerformanceImpact;
		private System.Windows.Forms.Button button_Uninstall;
	}
}
