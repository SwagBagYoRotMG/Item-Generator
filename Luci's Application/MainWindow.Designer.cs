namespace BaseLayout
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.BorderBottom = new System.Windows.Forms.PictureBox();
            this.BorderLeft = new System.Windows.Forms.PictureBox();
            this.BorderRight = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MaximizeButton = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.FormIcon = new System.Windows.Forms.PictureBox();
            this.BorderTopTitle = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.CryptDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.CryptDescription = new System.Windows.Forms.Panel();
            this.DescOTHER = new System.Windows.Forms.Label();
            this.DescSERIALBox = new System.Windows.Forms.TextBox();
            this.DescCREATEDBox = new System.Windows.Forms.TextBox();
            this.DescDEVBox = new System.Windows.Forms.TextBox();
            this.DescTITLEBox = new System.Windows.Forms.TextBox();
            this.DescNAMEBox = new System.Windows.Forms.TextBox();
            this.SerialGen = new System.Windows.Forms.Button();
            this.DescOTHERBox = new System.Windows.Forms.RichTextBox();
            this.DescSERIAL = new System.Windows.Forms.Label();
            this.DescCREATED = new System.Windows.Forms.Label();
            this.DescDEV = new System.Windows.Forms.Label();
            this.DescTITLE = new System.Windows.Forms.Label();
            this.DescNAME = new System.Windows.Forms.Label();
            this.CryptExplorer = new System.Windows.Forms.Panel();
            this.TestBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BorderBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).BeginInit();
            this.CryptDisplay.SuspendLayout();
            this.CryptDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackgroundImage = global::BaseLayout.Properties.Resources.TopBarBg;
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 753);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(1024, 15);
            this.BorderBottom.TabIndex = 1;
            this.BorderBottom.TabStop = false;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackgroundImage = global::BaseLayout.Properties.Resources.TopBarBg;
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 24);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(5, 729);
            this.BorderLeft.TabIndex = 2;
            this.BorderLeft.TabStop = false;
            // 
            // BorderRight
            // 
            this.BorderRight.BackgroundImage = global::BaseLayout.Properties.Resources.TopBarBg;
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(1019, 24);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(5, 729);
            this.BorderRight.TabIndex = 3;
            this.BorderRight.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::BaseLayout.Properties.Resources.Close;
            this.CloseButton.Location = new System.Drawing.Point(969, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(50, 20);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.TabStop = false;
            this.CloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CloseWindow);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseWindowHoverOn);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseWindowHoverOff);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackgroundImage = global::BaseLayout.Properties.Resources.Maximize;
            this.MaximizeButton.Enabled = false;
            this.MaximizeButton.Location = new System.Drawing.Point(944, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(25, 20);
            this.MaximizeButton.TabIndex = 5;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaximizeWindow);
            this.MaximizeButton.MouseEnter += new System.EventHandler(this.MaximizeWindowHoverOn);
            this.MaximizeButton.MouseLeave += new System.EventHandler(this.MaximizeWindowHoverOff);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::BaseLayout.Properties.Resources.Minimize;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeButton.Location = new System.Drawing.Point(919, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 20);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MinimizeWindow);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeWindowHoverOn);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeWindowHoverOff);
            // 
            // FormIcon
            // 
            this.FormIcon.BackColor = System.Drawing.Color.Transparent;
            this.FormIcon.BackgroundImage = global::BaseLayout.Properties.Resources.Icon;
            this.FormIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FormIcon.Location = new System.Drawing.Point(5, 1);
            this.FormIcon.Name = "FormIcon";
            this.FormIcon.Size = new System.Drawing.Size(22, 22);
            this.FormIcon.TabIndex = 7;
            this.FormIcon.TabStop = false;
            this.FormIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MaximizeWindow);
            this.FormIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveableOn);
            this.FormIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveableMove);
            this.FormIcon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveableOff);
            // 
            // BorderTopTitle
            // 
            this.BorderTopTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.BorderTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorderTopTitle.Font = new System.Drawing.Font("Zephyr", 12F);
            this.BorderTopTitle.Location = new System.Drawing.Point(0, 0);
            this.BorderTopTitle.Name = "BorderTopTitle";
            this.BorderTopTitle.Size = new System.Drawing.Size(1024, 24);
            this.BorderTopTitle.TabIndex = 8;
            this.BorderTopTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BorderTopTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MaximizeWindow);
            this.BorderTopTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveableOn);
            this.BorderTopTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveableMove);
            this.BorderTopTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MoveableOff);
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.Version.Location = new System.Drawing.Point(943, 754);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(80, 13);
            this.Version.TabIndex = 9;
            this.Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Copyright
            // 
            this.Copyright.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.Copyright.Location = new System.Drawing.Point(0, 754);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(1024, 13);
            this.Copyright.TabIndex = 10;
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CryptDisplay
            // 
            this.CryptDisplay.BackColor = System.Drawing.Color.White;
            this.CryptDisplay.Controls.Add(this.TestBox);
            this.CryptDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.CryptDisplay.Location = new System.Drawing.Point(310, 24);
            this.CryptDisplay.Name = "CryptDisplay";
            this.CryptDisplay.Padding = new System.Windows.Forms.Padding(5);
            this.CryptDisplay.Size = new System.Drawing.Size(709, 729);
            this.CryptDisplay.TabIndex = 11;
            // 
            // CryptDescription
            // 
            this.CryptDescription.BackColor = System.Drawing.Color.White;
            this.CryptDescription.Controls.Add(this.DescOTHER);
            this.CryptDescription.Controls.Add(this.DescSERIALBox);
            this.CryptDescription.Controls.Add(this.DescCREATEDBox);
            this.CryptDescription.Controls.Add(this.DescDEVBox);
            this.CryptDescription.Controls.Add(this.DescTITLEBox);
            this.CryptDescription.Controls.Add(this.DescNAMEBox);
            this.CryptDescription.Controls.Add(this.SerialGen);
            this.CryptDescription.Controls.Add(this.DescOTHERBox);
            this.CryptDescription.Controls.Add(this.DescSERIAL);
            this.CryptDescription.Controls.Add(this.DescCREATED);
            this.CryptDescription.Controls.Add(this.DescDEV);
            this.CryptDescription.Controls.Add(this.DescTITLE);
            this.CryptDescription.Controls.Add(this.DescNAME);
            this.CryptDescription.Location = new System.Drawing.Point(5, 531);
            this.CryptDescription.Name = "CryptDescription";
            this.CryptDescription.Padding = new System.Windows.Forms.Padding(3);
            this.CryptDescription.Size = new System.Drawing.Size(299, 222);
            this.CryptDescription.TabIndex = 13;
            // 
            // DescOTHER
            // 
            this.DescOTHER.AutoSize = true;
            this.DescOTHER.Location = new System.Drawing.Point(11, 106);
            this.DescOTHER.Margin = new System.Windows.Forms.Padding(3);
            this.DescOTHER.Name = "DescOTHER";
            this.DescOTHER.Size = new System.Drawing.Size(96, 13);
            this.DescOTHER.TabIndex = 6;
            this.DescOTHER.Text = "Project Description";
            // 
            // DescSERIALBox
            // 
            this.DescSERIALBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescSERIALBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescSERIALBox.Location = new System.Drawing.Point(103, 87);
            this.DescSERIALBox.MaxLength = 29;
            this.DescSERIALBox.Name = "DescSERIALBox";
            this.DescSERIALBox.Size = new System.Drawing.Size(190, 13);
            this.DescSERIALBox.TabIndex = 12;
            // 
            // DescCREATEDBox
            // 
            this.DescCREATEDBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescCREATEDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescCREATEDBox.Location = new System.Drawing.Point(103, 68);
            this.DescCREATEDBox.MaxLength = 10;
            this.DescCREATEDBox.Name = "DescCREATEDBox";
            this.DescCREATEDBox.Size = new System.Drawing.Size(190, 13);
            this.DescCREATEDBox.TabIndex = 11;
            // 
            // DescDEVBox
            // 
            this.DescDEVBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescDEVBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescDEVBox.Location = new System.Drawing.Point(103, 49);
            this.DescDEVBox.MaxLength = 32;
            this.DescDEVBox.Name = "DescDEVBox";
            this.DescDEVBox.Size = new System.Drawing.Size(190, 13);
            this.DescDEVBox.TabIndex = 10;
            // 
            // DescTITLEBox
            // 
            this.DescTITLEBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescTITLEBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescTITLEBox.Location = new System.Drawing.Point(103, 30);
            this.DescTITLEBox.MaxLength = 32;
            this.DescTITLEBox.Name = "DescTITLEBox";
            this.DescTITLEBox.Size = new System.Drawing.Size(190, 13);
            this.DescTITLEBox.TabIndex = 9;
            // 
            // DescNAMEBox
            // 
            this.DescNAMEBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescNAMEBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescNAMEBox.Location = new System.Drawing.Point(103, 11);
            this.DescNAMEBox.MaxLength = 64;
            this.DescNAMEBox.Name = "DescNAMEBox";
            this.DescNAMEBox.Size = new System.Drawing.Size(190, 13);
            this.DescNAMEBox.TabIndex = 8;
            // 
            // SerialGen
            // 
            this.SerialGen.Enabled = false;
            this.SerialGen.Location = new System.Drawing.Point(218, 193);
            this.SerialGen.Name = "SerialGen";
            this.SerialGen.Size = new System.Drawing.Size(75, 23);
            this.SerialGen.TabIndex = 0;
            this.SerialGen.Text = "Generator";
            this.SerialGen.UseVisualStyleBackColor = true;
            this.SerialGen.Visible = false;
            this.SerialGen.Click += new System.EventHandler(this.SerialGen_Click);
            // 
            // DescOTHERBox
            // 
            this.DescOTHERBox.BackColor = System.Drawing.Color.White;
            this.DescOTHERBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescOTHERBox.ForeColor = System.Drawing.Color.DimGray;
            this.DescOTHERBox.Location = new System.Drawing.Point(6, 125);
            this.DescOTHERBox.MaxLength = 300;
            this.DescOTHERBox.Name = "DescOTHERBox";
            this.DescOTHERBox.ReadOnly = true;
            this.DescOTHERBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.DescOTHERBox.Size = new System.Drawing.Size(287, 91);
            this.DescOTHERBox.TabIndex = 7;
            this.DescOTHERBox.Text = "";
            // 
            // DescSERIAL
            // 
            this.DescSERIAL.AutoSize = true;
            this.DescSERIAL.Location = new System.Drawing.Point(11, 87);
            this.DescSERIAL.Margin = new System.Windows.Forms.Padding(3);
            this.DescSERIAL.Name = "DescSERIAL";
            this.DescSERIAL.Size = new System.Drawing.Size(75, 13);
            this.DescSERIAL.TabIndex = 5;
            this.DescSERIAL.Text = "Project Serial :";
            // 
            // DescCREATED
            // 
            this.DescCREATED.AutoSize = true;
            this.DescCREATED.Location = new System.Drawing.Point(11, 68);
            this.DescCREATED.Margin = new System.Windows.Forms.Padding(3);
            this.DescCREATED.Name = "DescCREATED";
            this.DescCREATED.Size = new System.Drawing.Size(83, 13);
            this.DescCREATED.TabIndex = 4;
            this.DescCREATED.Text = "Project Started :";
            // 
            // DescDEV
            // 
            this.DescDEV.AutoSize = true;
            this.DescDEV.Location = new System.Drawing.Point(11, 49);
            this.DescDEV.Margin = new System.Windows.Forms.Padding(3);
            this.DescDEV.Name = "DescDEV";
            this.DescDEV.Size = new System.Drawing.Size(80, 13);
            this.DescDEV.TabIndex = 3;
            this.DescDEV.Text = "Project Author :";
            // 
            // DescTITLE
            // 
            this.DescTITLE.AutoSize = true;
            this.DescTITLE.Location = new System.Drawing.Point(11, 30);
            this.DescTITLE.Margin = new System.Windows.Forms.Padding(3);
            this.DescTITLE.Name = "DescTITLE";
            this.DescTITLE.Size = new System.Drawing.Size(69, 13);
            this.DescTITLE.TabIndex = 2;
            this.DescTITLE.Text = "Project Title :";
            // 
            // DescNAME
            // 
            this.DescNAME.AutoSize = true;
            this.DescNAME.Location = new System.Drawing.Point(11, 11);
            this.DescNAME.Margin = new System.Windows.Forms.Padding(3);
            this.DescNAME.Name = "DescNAME";
            this.DescNAME.Size = new System.Drawing.Size(77, 13);
            this.DescNAME.TabIndex = 1;
            this.DescNAME.Text = "Project Name :";
            // 
            // CryptExplorer
            // 
            this.CryptExplorer.BackColor = System.Drawing.Color.White;
            this.CryptExplorer.Location = new System.Drawing.Point(5, 24);
            this.CryptExplorer.Name = "CryptExplorer";
            this.CryptExplorer.Size = new System.Drawing.Size(299, 501);
            this.CryptExplorer.TabIndex = 14;
            // 
            // TestBox
            // 
            this.TestBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TestBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TestBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestBox.Image = global::BaseLayout.Properties.Resources.Icon;
            this.TestBox.Location = new System.Drawing.Point(8, 8);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(150, 150);
            this.TestBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TestBox.TabIndex = 0;
            this.TestBox.TabStop = false;
            this.TestBox.Click += new System.EventHandler(this.onClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.CryptExplorer);
            this.Controls.Add(this.CryptDescription);
            this.Controls.Add(this.CryptDisplay);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.FormIcon);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.MaximizeButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderTopTitle);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.BorderBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.FormUpdate);
            ((System.ComponentModel.ISupportInitialize)(this.BorderBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FormIcon)).EndInit();
            this.CryptDisplay.ResumeLayout(false);
            this.CryptDescription.ResumeLayout(false);
            this.CryptDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BorderBottom;
        private System.Windows.Forms.PictureBox BorderLeft;
        private System.Windows.Forms.PictureBox BorderRight;
        private System.Windows.Forms.PictureBox CloseButton;
        public System.Windows.Forms.PictureBox MaximizeButton;
        private System.Windows.Forms.PictureBox MinimizeButton;
        public System.Windows.Forms.PictureBox FormIcon;
        public System.Windows.Forms.Label BorderTopTitle;
        public System.Windows.Forms.Label Version;
        public System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.FlowLayoutPanel CryptDisplay;
        private System.Windows.Forms.Panel CryptDescription;
        private System.Windows.Forms.Panel CryptExplorer;
        public System.Windows.Forms.Button SerialGen;
        public System.Windows.Forms.Label DescOTHER;
        public System.Windows.Forms.Label DescSERIAL;
        public System.Windows.Forms.Label DescCREATED;
        public System.Windows.Forms.Label DescDEV;
        public System.Windows.Forms.Label DescTITLE;
        public System.Windows.Forms.Label DescNAME;
        public System.Windows.Forms.TextBox DescSERIALBox;
        public System.Windows.Forms.TextBox DescCREATEDBox;
        public System.Windows.Forms.TextBox DescDEVBox;
        public System.Windows.Forms.TextBox DescTITLEBox;
        public System.Windows.Forms.TextBox DescNAMEBox;
        public System.Windows.Forms.RichTextBox DescOTHERBox;
        private System.Windows.Forms.PictureBox TestBox;
    }
}

