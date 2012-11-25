using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WA_BG.Properties;

namespace WA_BG
{
	public partial class OptionsForm : Form
	{
		public OptionsForm()
		{
			InitializeComponent();
		}

		private void uiFolderSelectButton_Click(object sender, EventArgs e)
		{
			if (uiWoWFolderBrowserDialog.ShowDialog() == DialogResult.OK)
			{
				uiWoWPath.Text = uiWoWFolderBrowserDialog.SelectedPath;
			}
		}

		private void OptionsForm_Load(object sender, EventArgs e)
		{
			uiWoWPath.Text = Settings.Default.PathToWoW;
			uiCheckInterval.Value = Settings.Default.CheckInterval;
		}

		private void uiOkButton_Click(object sender, EventArgs e)
		{
			Settings.Default.PathToWoW = uiWoWPath.Text;
			Settings.Default.CheckInterval = uiCheckInterval.Value;
		}
	}
}
