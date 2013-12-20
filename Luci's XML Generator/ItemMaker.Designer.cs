namespace ItemMakerBeta
{
    partial class ItemMaker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemMaker));
            this.Splitter = new System.Windows.Forms.Panel();
            this.BorderBottom = new System.Windows.Forms.Panel();
            this.BorderRight = new System.Windows.Forms.Panel();
            this.BorderLeft = new System.Windows.Forms.Panel();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.TopBar = new System.Windows.Forms.Panel();
            this.IconButton = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Label();
            this.Soulbound = new System.Windows.Forms.CheckBox();
            this.RangeBox = new System.Windows.Forms.TextBox();
            this.RangeText = new System.Windows.Forms.Label();
            this.MinDmgLabel = new System.Windows.Forms.Label();
            this.MinDmgBox = new System.Windows.Forms.TextBox();
            this.MaxDmgLabel = new System.Windows.Forms.Label();
            this.MaxDmgBox = new System.Windows.Forms.TextBox();
            this.TypeList = new System.Windows.Forms.ComboBox();
            this.TextureLabel = new System.Windows.Forms.Label();
            this.TextureIDBox = new System.Windows.Forms.TextBox();
            this.CheckboxGroup = new System.Windows.Forms.GroupBox();
            this.Unreleased = new System.Windows.Forms.CheckBox();
            this.Untiered = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.Class = new System.Windows.Forms.Label();
            this.ClassList = new System.Windows.Forms.ComboBox();
            this.TextureType = new System.Windows.Forms.ComboBox();
            this.TierLabel = new System.Windows.Forms.Label();
            this.TierBox = new System.Windows.Forms.TextBox();
            this.ItemIDLabel = new System.Windows.Forms.Label();
            this.ItemIDBox = new System.Windows.Forms.TextBox();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.DisplayBox = new System.Windows.Forms.TextBox();
            this.Display = new System.Windows.Forms.Label();
            this.TopBar.SuspendLayout();
            this.CheckboxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Splitter
            // 
            this.Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.Splitter.Location = new System.Drawing.Point(510, 25);
            this.Splitter.Name = "Splitter";
            this.Splitter.Size = new System.Drawing.Size(4, 508);
            this.Splitter.TabIndex = 2;
            // 
            // BorderBottom
            // 
            this.BorderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.BorderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderBottom.Location = new System.Drawing.Point(0, 533);
            this.BorderBottom.Name = "BorderBottom";
            this.BorderBottom.Size = new System.Drawing.Size(1024, 4);
            this.BorderBottom.TabIndex = 3;
            // 
            // BorderRight
            // 
            this.BorderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.BorderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BorderRight.Location = new System.Drawing.Point(1020, 25);
            this.BorderRight.Name = "BorderRight";
            this.BorderRight.Size = new System.Drawing.Size(4, 508);
            this.BorderRight.TabIndex = 4;
            // 
            // BorderLeft
            // 
            this.BorderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(160)))), ((int)(((byte)(211)))));
            this.BorderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.BorderLeft.Location = new System.Drawing.Point(0, 25);
            this.BorderLeft.Name = "BorderLeft";
            this.BorderLeft.Size = new System.Drawing.Size(4, 508);
            this.BorderLeft.TabIndex = 5;
            // 
            // OutputBox
            // 
            this.OutputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBox.CausesValidation = false;
            this.OutputBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputBox.DetectUrls = false;
            this.OutputBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputBox.Location = new System.Drawing.Point(514, 25);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.OutputBox.ShortcutsEnabled = false;
            this.OutputBox.Size = new System.Drawing.Size(506, 508);
            this.OutputBox.TabIndex = 6;
            this.OutputBox.Text = "";
            // 
            // TopBar
            // 
            this.TopBar.BackgroundImage = global::ItemMakerBeta.Properties.Resources.TopBarBg;
            this.TopBar.Controls.Add(this.IconButton);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Close);
            this.TopBar.Controls.Add(this.TitleBar);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1024, 25);
            this.TopBar.TabIndex = 1;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // IconButton
            // 
            this.IconButton.BackColor = System.Drawing.Color.White;
            this.IconButton.BackgroundImage = global::ItemMakerBeta.Properties.Resources.Icon;
            this.IconButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconButton.Location = new System.Drawing.Point(4, 2);
            this.IconButton.Name = "IconButton";
            this.IconButton.Size = new System.Drawing.Size(20, 20);
            this.IconButton.TabIndex = 2;
            this.IconButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Icon_Click);
            this.IconButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.IconButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.IconButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = global::ItemMakerBeta.Properties.Resources.Minimize;
            this.Minimize.Location = new System.Drawing.Point(943, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(25, 20);
            this.Minimize.TabIndex = 0;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Close
            // 
            this.Close.BackgroundImage = global::ItemMakerBeta.Properties.Resources.Close;
            this.Close.Location = new System.Drawing.Point(970, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(50, 20);
            this.Close.TabIndex = 0;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Transparent;
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(1024, 25);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // Soulbound
            // 
            this.Soulbound.AutoSize = true;
            this.Soulbound.Location = new System.Drawing.Point(6, 19);
            this.Soulbound.Name = "Soulbound";
            this.Soulbound.Size = new System.Drawing.Size(88, 17);
            this.Soulbound.TabIndex = 7;
            this.Soulbound.Text = "Is Soulbound";
            this.Soulbound.UseVisualStyleBackColor = true;
            // 
            // RangeBox
            // 
            this.RangeBox.Enabled = false;
            this.RangeBox.Location = new System.Drawing.Point(104, 138);
            this.RangeBox.MaxLength = 3;
            this.RangeBox.Name = "RangeBox";
            this.RangeBox.Size = new System.Drawing.Size(98, 20);
            this.RangeBox.TabIndex = 8;
            // 
            // RangeText
            // 
            this.RangeText.AutoSize = true;
            this.RangeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RangeText.Location = new System.Drawing.Point(10, 141);
            this.RangeText.Name = "RangeText";
            this.RangeText.Size = new System.Drawing.Size(52, 13);
            this.RangeText.TabIndex = 9;
            this.RangeText.Text = "Range :";
            // 
            // MinDmgLabel
            // 
            this.MinDmgLabel.AutoSize = true;
            this.MinDmgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinDmgLabel.Location = new System.Drawing.Point(10, 167);
            this.MinDmgLabel.Name = "MinDmgLabel";
            this.MinDmgLabel.Size = new System.Drawing.Size(85, 13);
            this.MinDmgLabel.TabIndex = 10;
            this.MinDmgLabel.Text = "Min Damage :";
            // 
            // MinDmgBox
            // 
            this.MinDmgBox.Location = new System.Drawing.Point(104, 164);
            this.MinDmgBox.MaxLength = 3;
            this.MinDmgBox.Name = "MinDmgBox";
            this.MinDmgBox.Size = new System.Drawing.Size(98, 20);
            this.MinDmgBox.TabIndex = 11;
            this.MinDmgBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // MaxDmgLabel
            // 
            this.MaxDmgLabel.AutoSize = true;
            this.MaxDmgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxDmgLabel.Location = new System.Drawing.Point(10, 193);
            this.MaxDmgLabel.Name = "MaxDmgLabel";
            this.MaxDmgLabel.Size = new System.Drawing.Size(88, 13);
            this.MaxDmgLabel.TabIndex = 12;
            this.MaxDmgLabel.Text = "Max Damage :";
            // 
            // MaxDmgBox
            // 
            this.MaxDmgBox.Location = new System.Drawing.Point(104, 190);
            this.MaxDmgBox.MaxLength = 3;
            this.MaxDmgBox.Name = "MaxDmgBox";
            this.MaxDmgBox.Size = new System.Drawing.Size(98, 20);
            this.MaxDmgBox.TabIndex = 13;
            this.MaxDmgBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // TypeList
            // 
            this.TypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeList.FormattingEnabled = true;
            this.TypeList.Items.AddRange(new object[] {
            "Ground",
            "Object"});
            this.TypeList.Location = new System.Drawing.Point(104, 31);
            this.TypeList.MaxDropDownItems = 2;
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(98, 21);
            this.TypeList.Sorted = true;
            this.TypeList.TabIndex = 15;
            // 
            // TextureLabel
            // 
            this.TextureLabel.AutoSize = true;
            this.TextureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextureLabel.Location = new System.Drawing.Point(10, 114);
            this.TextureLabel.Name = "TextureLabel";
            this.TextureLabel.Size = new System.Drawing.Size(58, 13);
            this.TextureLabel.TabIndex = 17;
            this.TextureLabel.Text = "Texture :";
            // 
            // TextureIDBox
            // 
            this.TextureIDBox.Location = new System.Drawing.Point(208, 111);
            this.TextureIDBox.MaxLength = 64;
            this.TextureIDBox.Name = "TextureIDBox";
            this.TextureIDBox.Size = new System.Drawing.Size(147, 20);
            this.TextureIDBox.TabIndex = 16;
            this.TextureIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // CheckboxGroup
            // 
            this.CheckboxGroup.Controls.Add(this.Unreleased);
            this.CheckboxGroup.Controls.Add(this.Untiered);
            this.CheckboxGroup.Controls.Add(this.Soulbound);
            this.CheckboxGroup.Location = new System.Drawing.Point(13, 266);
            this.CheckboxGroup.Name = "CheckboxGroup";
            this.CheckboxGroup.Size = new System.Drawing.Size(199, 217);
            this.CheckboxGroup.TabIndex = 18;
            this.CheckboxGroup.TabStop = false;
            this.CheckboxGroup.Text = "Definers";
            // 
            // Unreleased
            // 
            this.Unreleased.AutoSize = true;
            this.Unreleased.Location = new System.Drawing.Point(6, 65);
            this.Unreleased.Name = "Unreleased";
            this.Unreleased.Size = new System.Drawing.Size(91, 17);
            this.Unreleased.TabIndex = 9;
            this.Unreleased.Text = "Is Unreleased";
            this.Unreleased.UseVisualStyleBackColor = true;
            // 
            // Untiered
            // 
            this.Untiered.AutoSize = true;
            this.Untiered.Location = new System.Drawing.Point(6, 42);
            this.Untiered.Name = "Untiered";
            this.Untiered.Size = new System.Drawing.Size(77, 17);
            this.Untiered.TabIndex = 8;
            this.Untiered.Text = "Is Untiered";
            this.Untiered.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(13, 489);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(199, 36);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Export Output";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.Export_Click);
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(10, 34);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(43, 13);
            this.Type.TabIndex = 20;
            this.Type.Text = "Type :";
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.Location = new System.Drawing.Point(10, 61);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(45, 13);
            this.Class.TabIndex = 22;
            this.Class.Text = "Class :";
            // 
            // ClassList
            // 
            this.ClassList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassList.FormattingEnabled = true;
            this.ClassList.Items.AddRange(new object[] {
            "Character",
            "Equipment"});
            this.ClassList.Location = new System.Drawing.Point(104, 58);
            this.ClassList.MaxDropDownItems = 2;
            this.ClassList.Name = "ClassList";
            this.ClassList.Size = new System.Drawing.Size(98, 21);
            this.ClassList.Sorted = true;
            this.ClassList.TabIndex = 21;
            // 
            // TextureType
            // 
            this.TextureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TextureType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextureType.FormattingEnabled = true;
            this.TextureType.Items.AddRange(new object[] {
            "Internal",
            "Production",
            "Testing"});
            this.TextureType.Location = new System.Drawing.Point(104, 111);
            this.TextureType.MaxDropDownItems = 2;
            this.TextureType.Name = "TextureType";
            this.TextureType.Size = new System.Drawing.Size(98, 21);
            this.TextureType.Sorted = true;
            this.TextureType.TabIndex = 23;
            // 
            // TierLabel
            // 
            this.TierLabel.AutoSize = true;
            this.TierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TierLabel.Location = new System.Drawing.Point(10, 88);
            this.TierLabel.Name = "TierLabel";
            this.TierLabel.Size = new System.Drawing.Size(37, 13);
            this.TierLabel.TabIndex = 25;
            this.TierLabel.Text = "Tier :";
            // 
            // TierBox
            // 
            this.TierBox.Location = new System.Drawing.Point(104, 85);
            this.TierBox.MaxLength = 2;
            this.TierBox.Name = "TierBox";
            this.TierBox.Size = new System.Drawing.Size(98, 20);
            this.TierBox.TabIndex = 24;
            this.TierBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumericOnly_KeyPress);
            // 
            // ItemIDLabel
            // 
            this.ItemIDLabel.AutoSize = true;
            this.ItemIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIDLabel.Location = new System.Drawing.Point(208, 34);
            this.ItemIDLabel.Name = "ItemIDLabel";
            this.ItemIDLabel.Size = new System.Drawing.Size(52, 13);
            this.ItemIDLabel.TabIndex = 27;
            this.ItemIDLabel.Text = "ItemID :";
            // 
            // ItemIDBox
            // 
            this.ItemIDBox.Location = new System.Drawing.Point(302, 31);
            this.ItemIDBox.MaxLength = 4;
            this.ItemIDBox.Name = "ItemIDBox";
            this.ItemIDBox.Size = new System.Drawing.Size(202, 20);
            this.ItemIDBox.TabIndex = 28;
            this.ItemIDBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HexadecimalOnly_KeyPress);
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Location = new System.Drawing.Point(302, 58);
            this.ItemNameBox.MaxLength = 64;
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(202, 20);
            this.ItemNameBox.TabIndex = 30;
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.Location = new System.Drawing.Point(208, 61);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(75, 13);
            this.ItemNameLabel.TabIndex = 29;
            this.ItemNameLabel.Text = "Item Name :";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // DisplayBox
            // 
            this.DisplayBox.Location = new System.Drawing.Point(302, 84);
            this.DisplayBox.MaxLength = 64;
            this.DisplayBox.Name = "DisplayBox";
            this.DisplayBox.Size = new System.Drawing.Size(202, 20);
            this.DisplayBox.TabIndex = 32;
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.Location = new System.Drawing.Point(208, 87);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(92, 13);
            this.Display.TabIndex = 31;
            this.Display.Text = "Display Name :";
            // 
            // ItemMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 537);
            this.Controls.Add(this.DisplayBox);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.ItemNameLabel);
            this.Controls.Add(this.ItemIDBox);
            this.Controls.Add(this.ItemIDLabel);
            this.Controls.Add(this.TierLabel);
            this.Controls.Add(this.TierBox);
            this.Controls.Add(this.TextureType);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.ClassList);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CheckboxGroup);
            this.Controls.Add(this.TextureLabel);
            this.Controls.Add(this.TextureIDBox);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.MaxDmgBox);
            this.Controls.Add(this.MaxDmgLabel);
            this.Controls.Add(this.MinDmgBox);
            this.Controls.Add(this.MinDmgLabel);
            this.Controls.Add(this.RangeText);
            this.Controls.Add(this.RangeBox);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.BorderLeft);
            this.Controls.Add(this.BorderRight);
            this.Controls.Add(this.BorderBottom);
            this.Controls.Add(this.Splitter);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopBar.ResumeLayout(false);
            this.CheckboxGroup.ResumeLayout(false);
            this.CheckboxGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Label TitleBar;
        private System.Windows.Forms.Panel Splitter;
        private System.Windows.Forms.Panel BorderBottom;
        private System.Windows.Forms.Panel BorderRight;
        private System.Windows.Forms.Panel BorderLeft;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Panel IconButton;
        private System.Windows.Forms.CheckBox Soulbound;
        private System.Windows.Forms.TextBox RangeBox;
        private System.Windows.Forms.Label RangeText;
        private System.Windows.Forms.Label MinDmgLabel;
        private System.Windows.Forms.TextBox MinDmgBox;
        private System.Windows.Forms.Label MaxDmgLabel;
        private System.Windows.Forms.TextBox MaxDmgBox;
        private System.Windows.Forms.ComboBox TypeList;
        private System.Windows.Forms.Label TextureLabel;
        private System.Windows.Forms.TextBox TextureIDBox;
        private System.Windows.Forms.GroupBox CheckboxGroup;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.ComboBox ClassList;
        private System.Windows.Forms.ComboBox TextureType;
        private System.Windows.Forms.Label TierLabel;
        private System.Windows.Forms.TextBox TierBox;
        private System.Windows.Forms.Label ItemIDLabel;
        private System.Windows.Forms.TextBox ItemIDBox;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.CheckBox Unreleased;
        private System.Windows.Forms.CheckBox Untiered;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.TextBox DisplayBox;
        private System.Windows.Forms.Label Display;

    }
}

