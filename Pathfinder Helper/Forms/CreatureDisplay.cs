using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pathfinder_Helper.Forms
{
	public partial class CreatureDisplay : Form
	{
		private readonly string HTMLURL;
		public CreatureDisplay(string s)
		{
			InitializeComponent();

			int regVal = 7000;
			var browserVer = webBrowser.Version.Major;

			if (browserVer >= 11)
				regVal = 11001;
			else if (browserVer == 10)
				regVal = 10001;
			else if (browserVer == 9)
				regVal = 9999;
			else if (browserVer == 8)
				regVal = 8888;

			this.Text = s;
			RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
			Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", regVal, RegistryValueKind.DWord);
			Key.Close();

			HTMLURL = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),"TEMP.html");
		}

		public void LoadHtml(string html)
		{
			if (File.Exists(HTMLURL))
				File.Delete(HTMLURL);

			File.WriteAllText(HTMLURL, html);			

			webBrowser.Url = new Uri(HTMLURL);
		}

		public void LoadUrl(string url)
		{
			webBrowser.Url = new Uri(url);
		}

		public void LoadCreature(int CreatureId, bool isNpc)
		{
			// Construct a new HTML string from base data
			// Then call LoadHtml with the new HTML string
		}
	}
}
