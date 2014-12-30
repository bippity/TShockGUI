using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TShockGUI
{
    public partial class TShockGUI : Form
    {
        public TShockGUI()
        {
            InitializeComponent();
            buildParams();
        }

        private String buildParams()
        {
            string param = string.Empty;
            if (portText.Text != "")
            {
                param += "-port " + portText.Text;
            }
            if (worldpathTextBox.Text != "")
            {
                param += " -Worldpath \"" + worldpathTextBox.Text + "\"";
            }
            if (worldTextBox.Text != "")
            {
                param += " -world " + worldTextBox.Text;
            }
            if (ignoreversionCheckBox.Checked)
            {
                param += " -ignoreversion";
            }

            argsTextbox.Text = param;

            return param;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("TerrariaServer.exe", buildParams());
            }
            catch (Exception ex)
            {
                Close();
            }
        }

        private void createBatchButton_Click(object sender, EventArgs e)
        {
            string path = "StartServer.bat";
            string param = string.Empty;

            if (argsTextbox.Text == "")
            {
                param = buildParams();
            }
            else
            {
                param = argsTextbox.Text;
            }

            try
            {
                using (FileStream fs = File.Create(path))
                {
                    Byte[] output = new UTF8Encoding(true).GetBytes("start TerrariaServer.exe " + param);
                    fs.Write(output, 0, output.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void updateParamsButton_Click(object sender, EventArgs e)
        {
            buildParams();
        }

        private void ignoreversionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            buildParams();
        }

        private void portText_TextChanged(object sender, EventArgs e)
        {
            buildParams();
        }

        private void worldpathTextBox_TextChanged(object sender, EventArgs e)
        {
            buildParams();
        }

        private void logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://tshock.co/xf/");
        }
    }
}
