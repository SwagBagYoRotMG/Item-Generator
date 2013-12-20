using System;
using System.Drawing;
using System.Windows.Forms;
using BaseLayout.Properties;

namespace BaseLayout.Functions
{
    public class MainFunctions
    {
        public string Title = "The Undead Crypt - Project Explorer";
        public string Version = "Version : ";
        public float VersionFloat = (float)0.1;
        public string Copyright = "Copyright © 2013 - The Undead Crypt";
        public int Width = 1024;
        public int Height = 768;

        private bool Debug = false;

        public void InitializeSystem(MainWindow mWindow)
        {
            if (Debug == true)
            { mWindow.SerialGen.Visible = true; mWindow.SerialGen.Enabled = true; }
            else
            { mWindow.SerialGen.Visible = false; mWindow.SerialGen.Enabled = false; }
            mWindow.FormIcon.BackgroundImage = Resources.Icon;
            mWindow.Width = Width;
            mWindow.Height = Height;
            mWindow.BorderTopTitle.Text = Title;
            mWindow.Copyright.Text = Copyright;
            mWindow.Version.Text = Version + VersionFloat;
        }

        public void InitializeInformation(MainWindow mWindow)
        {
            mWindow.DescNAMEBox.Text = "";
            mWindow.DescTITLEBox.Text = "";
            mWindow.DescDEVBox.Text = "";
            mWindow.DescCREATEDBox.Text = "";
            mWindow.DescSERIALBox.Text = "";
            mWindow.DescOTHERBox.Text = "";
        }
    }
}
