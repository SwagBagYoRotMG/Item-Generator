using System;
using System.Drawing;
using System.Windows.Forms;
using ItemMakerBeta.Base;
using ItemMakerBeta.Properties;

namespace ItemMakerBeta
{
    public partial class ItemMaker : Form
    {
        #region InitializeForm

        public ItemMaker()
        {
            InitializeComponent();
            EnableDoubleBuffering();
            _var.CheckBeta();
            TitleBar.Text = string.Format("{0} v{1} {2}", _var.Title, _var.Version, _var.Beta);
            InitializeTimer();
        }

        #endregion

        #region DoubleBuffer

        public void EnableDoubleBuffering()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.UserPaint |
                     ControlStyles.AllPaintingInWmPaint,
                true);
            UpdateStyles();
        }

        #endregion

        #region PrivateDefiners

        /* Imported Classes */
        private readonly Variables _var = new Variables();
        /* Privates */
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);

        #endregion

        #region CloseButton

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.CloseHover;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.Close;
        }

        #endregion

        #region MinimizeButton

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Resources.MinimizeHover;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Resources.Minimize;
        }

        #endregion

        #region ExportButton

        private void Export_Click(object sender, EventArgs e)
        {
            var sd = new SaveFileDialog
            {
                Filter = @"eXtensible Markup Language (*.xml)|*.xml",
                FileName = ItemNameBox.Text,
                Title = @"Export File"
            };
            if (sd.ShowDialog() == DialogResult.OK)
            {
                OutputBox.SaveFile(sd.FileName, RichTextBoxStreamType.UnicodePlainText);
                MessageBox.Show(@"Successfully Saved file to location");
            }
        }

        #endregion

        #region TextBoxSpecifications

        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)
                && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void HexadecimalOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        #endregion

        #region BarControl

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true; // _dragging is your variable flag
            _startPoint = new Point(e.X, e.Y);
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - _startPoint.X, p.Y - _startPoint.Y);
            }
        }

        #endregion

        #region UpdateTimer

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            OutputBox.Text = "";
            CheckboxValidator();
            InitializeTimer();
        }

        private void CheckboxValidator()
        {
            if (Unreleased.Enabled == false && Unreleased.Checked == false && !Untiered.Checked)
            {
                Unreleased.Enabled = true;
            }
            if (Untiered.Enabled == false && Untiered.Checked == false && !Unreleased.Checked)
            {
                Untiered.Enabled = true;
            }
            if (Untiered.Checked == false && Unreleased.Checked == false)
            {
                TierBox.Enabled = true;
            }
        }

        #endregion

        #region IconFunctions

        private void Icon_Click(object sender, MouseEventArgs e)
        {
            // TODO: Add Functionality to Icon
        }

        #endregion

        #region InitializeSystemFunctions

        private void InitializeTimer()
        {
            OutputBox.Text = @"";
            EnableDisableButtons();
            CheckTypeList();
            UpdateOutputBox();
        }

        private void CheckTypeList()
        {
            if (TypeList.Text == @"Object")
            {
                ItemIDBox.Enabled = true;
                ItemNameBox.Enabled = true;
                DisplayBox.Enabled = true;
                ClassList.Enabled = true;
                TierBox.Enabled = true;
                RangeBox.Enabled = false;
                MinDmgBox.Enabled = true;
                MaxDmgBox.Enabled = true;
                TextureType.Enabled = true;
                TextureIDBox.Enabled = true;
                Soulbound.Enabled = true;
                Untiered.Enabled = true;
                Unreleased.Enabled = true;
                ItemIDLabel.Text = @"Item ID";
                ItemNameLabel.Text = @"Item Name";
            }
            else if (TypeList.Text == @"Ground")
            {
                ItemIDBox.Enabled = true;
                ItemNameBox.Enabled = true;
                DisplayBox.Enabled = false;
                ClassList.Enabled = false;
                TierBox.Enabled = false;
                RangeBox.Enabled = false;
                MinDmgBox.Enabled = false;
                MaxDmgBox.Enabled = false;
                TextureType.Enabled = true;
                TextureIDBox.Enabled = true;
                Soulbound.Enabled = false;
                Untiered.Enabled = false;
                Unreleased.Enabled = false;
                ItemIDLabel.Text = @"Ground ID";
                ItemNameLabel.Text = @"Ground Name";
            }
            else if (TypeList.Text == @"")
            {
                ItemIDBox.Enabled = false;
                ItemNameBox.Enabled = false;
                DisplayBox.Enabled = false;
                ClassList.Enabled = false;
                TierBox.Enabled = false;
                RangeBox.Enabled = false;
                MinDmgBox.Enabled = false;
                MaxDmgBox.Enabled = false;
                TextureType.Enabled = false;
                TextureIDBox.Enabled = false;
                Soulbound.Enabled = false;
                Untiered.Enabled = false;
                Unreleased.Enabled = false;
                ItemIDLabel.Text = @"Item ID";
                ItemNameLabel.Text = @"Item Name";
            }
        }

        private void EnableDisableButtons()
        {
            Soulbound.Enabled = ClassList.Text == @"Equipment";
        }

        private void UpdateOutputBox()
        {
            if (TypeList.Text == @"Object")
            {
                if (TypeList.Text != @"")
                    OutputBox.Text += string.Format(@"<{0} type=""0x{1}"" id=""{2}"">
", TypeList.Text, ItemIDBox.Text, ItemNameBox.Text);
                if (DisplayBox.Text != @"")
                    OutputBox.Text += string.Format(@"  <DisplayId>{0}</DisplayId>
", DisplayBox.Text);
                if (ClassList.Text != @"")
                    OutputBox.Text += string.Format(@"  <Class>{0}</Class>
", ClassList.Text);
                if (ClassList.Text == @"Equipment")
                    OutputBox.Text += @"  <Item />
";
                if (TextureType.Text == @"Internal")
                    OutputBox.Text += @"  <Texture>Not Ready Yet!</Texture>
";
                else if (TextureType.Text == @"Production" && TextureIDBox.Text != "" ||
                         TextureType.Text == @"Testing" && TextureIDBox.Text != "")
                {
                    switch (TextureType.Text)
                    {
                        case @"Production":
                            OutputBox.Text += string.Format("  <RemoteTexture>" + "draw:{0}</RemoteTexture>\n", TextureIDBox.Text);
                            break;
                        case @"Testing":
                            OutputBox.Text += string.Format("  <RemoteTexture>" + "tdraw:{0}</RemoteTexture>\n", TextureIDBox.Text);
                            break;
                    }
                }
                if (Unreleased.Checked)
                {
                    TierBox.Enabled = false;
                    Untiered.Checked = false;
                    Untiered.Enabled = false;
                    OutputBox.Text += @"  <Tier>UR</Tier>
";
                }
                else if (Untiered.Checked)
                {
                    TierBox.Enabled = false;
                    Unreleased.Checked = false;
                    Unreleased.Enabled = false;
                }
                else if (TierBox.Text == "" && ClassList.Text == @"Equipment")
                    OutputBox.Text += @"  <Tier>0</Tier>
";
                else if (ClassList.Text == @"Equipment")
                    OutputBox.Text += string.Format("  <Tier>{0}</Tier>\n", TierBox.Text);
                if (MinDmgBox.Text != @"")
                    OutputBox.Text += string.Format("  <MinDamage>{0}</MinDamage>\n", MinDmgBox.Text);
                if (MaxDmgBox.Text != @"")
                    OutputBox.Text += string.Format("  <MaxDamage>{0}</MaxDamage>\n", MaxDmgBox.Text);
                if (Soulbound.Checked)
                    OutputBox.Text += @"  <Soulbound />
";
                if (TypeList.Text != @"")
                    OutputBox.Text += string.Format("</{0}>", TypeList.Text);
            }
        }

        #endregion
    }
}