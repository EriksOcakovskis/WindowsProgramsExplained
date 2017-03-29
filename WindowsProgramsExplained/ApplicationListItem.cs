using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsProgramsExplained
{
	public partial class ApplicationListItem : UserControl
	{
		private const int expandedSize = 102;
		private const int condensedSize = 34;

		private ApplicationData data;
		private bool expanded = true;

		public ApplicationListItem(ApplicationData data)
		{
			this.data = data;

			InitializeComponent();
		}

		public void ToggleExpansion()
		{
			expanded = !expanded;
			if (expanded)
				Height = expandedSize;
			else
				Height = condensedSize;
		}

		private void SetupDataView()
		{
			label_DisplayName.Text = data.displayName;
			label_ShortDescription.Text = data.developer;
			label_Importance.Text = "Low";
			label_PerformanceImpact.Text = "Low";
		}

		private void ApplicationListItem_Load(object sender, EventArgs e)
		{
			SetupDataView();
			ToggleExpansion();
		}

		private void ApplicationListItem_Click(object sender, EventArgs e)
		{
			ToggleExpansion();
		}

		private void button_Uninstall_Click(object sender, EventArgs e)
		{
			Process process = new Process();
			//process.StartInfo.FileName = 
		}
	}
}
