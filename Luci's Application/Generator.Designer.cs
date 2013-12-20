namespace BaseLayout
{
    partial class Generator
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
            this.GenButton = new System.Windows.Forms.Button();
            this.GenOutput = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(13, 13);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(288, 48);
            this.GenButton.TabIndex = 1;
            this.GenButton.Text = "Generate Key";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // GenOutput
            // 
            this.GenOutput.Location = new System.Drawing.Point(13, 67);
            this.GenOutput.MaxLength = 29000;
            this.GenOutput.Name = "GenOutput";
            this.GenOutput.ReadOnly = true;
            this.GenOutput.Size = new System.Drawing.Size(356, 234);
            this.GenOutput.TabIndex = 2;
            this.GenOutput.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(308, 41);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Times to \r\nRepeat";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GenOutput);
            this.Controls.Add(this.GenButton);
            this.Name = "Generator";
            this.Text = "Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.RichTextBox GenOutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}