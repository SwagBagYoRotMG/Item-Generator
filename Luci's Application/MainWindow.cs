using System;
using System.Drawing;
using System.Windows.Forms;
using BaseLayout.Functions;
using BaseLayout.Properties;
using MySql.Data.MySqlClient;

namespace BaseLayout
{
    public partial class MainWindow : Form
    {
        private readonly MainFunctions _mF = new MainFunctions();
        private readonly Database _db = new Database();

        private bool _dragging;
        private Point _startPoint = new Point(0, 0);

        public MainWindow()
        {
            InitializeComponent();
            _mF.InitializeSystem(this);
            _mF.InitializeInformation(this);
        }

        #region ButtonInitializers

        private void MoveableOn(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void MoveableOff(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void MoveableMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - _startPoint.X, p.Y - _startPoint.Y);
        }

        private void MinimizeWindow(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MinimizeWindowHoverOn(object sender, EventArgs e)
        {
            MinimizeButton.BackgroundImage = Resources.MinimizeHover;
        }

        private void MinimizeWindowHoverOff(object sender, EventArgs e)
        {
            MinimizeButton.BackgroundImage = Resources.Minimize;
        }

        private void CloseWindow(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void CloseWindowHoverOn(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = Resources.CloseHover;
        }

        private void CloseWindowHoverOff(object sender, EventArgs e)
        {
            CloseButton.BackgroundImage = Resources.Close;
        }

        private void MaximizeWindow(object sender, MouseEventArgs e)
        {
            if (MaximizeButton.Enabled == false) return;
            WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            if (WindowState == FormWindowState.Maximized)
            {
                FormUpdate();
                CloseButton.Location = new Point(Width - 55, 0);
                MaximizeButton.Location = new Point(Width - 80, 0);
                MinimizeButton.Location = new Point(Width - 105, 0);
                Version.Location = new Point(Width - 80, Height - 14);
                Copyright.Location = new Point(0, Height - 14);
            }
            else
            {
                FormUpdate();
                CloseButton.Location = new Point(Width - 55, 0);
                MaximizeButton.Location = new Point(Width - 80, 0);
                MinimizeButton.Location = new Point(Width - 105, 0);
                Version.Location = new Point(Width - 80, Height - 14);
                Copyright.Location = new Point(0, Height - 14);
            }
        }

        private void MaximizeWindowHoverOn(object sender, EventArgs e)
        {
            MaximizeButton.BackgroundImage = WindowState == FormWindowState.Maximized ? Resources.MaximizeBigHover : Resources.MaximizeHover;
        }

        private void MaximizeWindowHoverOff(object sender, EventArgs e)
        {
            MaximizeButton.BackgroundImage = WindowState == FormWindowState.Maximized ? Resources.MaximizeBig : Resources.Maximize;
        }

        #endregion

        private void FormUpdate(object sender, EventArgs e)
        {
            CloseButton.Location = new Point(Width - 55, 0);
            MaximizeButton.Location = new Point(Width - 80, 0);
            MinimizeButton.Location = new Point(Width - 105, 0);
            Version.Location = new Point(Width - 80, Height - 14);
            Copyright.Location = new Point(0, Height - 14);

            if (MaximizeButton.Enabled) return;
            CloseButton.Location = new Point(Width - 55, 0);
            MinimizeButton.Location = new Point(Width - 80, 0);
            MaximizeButton.Visible = false;
        }

        private void FormUpdate()
        {
            MaximizeButton.BackgroundImage = WindowState == FormWindowState.Maximized ? Resources.MaximizeBig : Resources.Maximize;
        }

        private void SerialGen_Click(object sender, EventArgs e)
        {
            Generator gen = new Generator();
            gen.ShowDialog();
        }

        private void onClick(object sender, EventArgs e)
        {
            DescNAMEBox.Text = "Item Maker";
            DescTITLEBox.Text = "ItemMaker";
            DescDEVBox.Text = "Lucifer";
            DescCREATEDBox.Text = "07/12/2013";
            DescSERIALBox.Text = "91198-B93C2-D2DBD-6AB34-C3CF6";
            DescOTHERBox.Text = "A Realm of the Mad God XML Generator created by Lucifer. It will help generate just about everything you can use inside of a Realm of the Mad God Private Server.";
        }
    }
}
