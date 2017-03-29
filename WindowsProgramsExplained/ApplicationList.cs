using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WindowsProgramsExplained
{
	public partial class ApplicationList : UserControl
	{
		private List<ApplicationListItem> applicationListItems = new List<ApplicationListItem>();

		public ApplicationList()
		{
			InitializeComponent();
		}

		public void AddApplication(ApplicationData data)
		{
			ApplicationListItem applicationListItem = new ApplicationListItem(data);
			applicationListItem.Top += applicationListItems.Count * 40;
			Controls.Add(applicationListItem);
			applicationListItems.Add(applicationListItem);
		}

		private void ApplicationList_Load(object sender, EventArgs e)
		{

			LoadInstalledApplications();
		}

		private void LoadInstalledApplications()
		{
			string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
			using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
			{
				foreach (string subkey_name in key.GetSubKeyNames())
				{
					using (RegistryKey subkey = key.OpenSubKey(subkey_name))
					{
						try
						{
							ApplicationData data = new ApplicationData()
							{
								developer = subkey.GetValue("Publisher").ToString(),
								developerRating = "-9001",
								displayName = subkey.GetValue("DisplayName").ToString(),

								shortDescription = subkey.GetValue("Publisher").ToString(),
								fullDescription = "Notepad on steroids with styling.",

								importance = Importance.LOW,
								performanceImpact = PerformanceImpact.LOW
							};

							AddApplication(data);
						}
						catch (Exception ex)
						{

						}
					}
				}
			}
		}
	}
}
