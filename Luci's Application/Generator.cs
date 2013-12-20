using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BaseLayout
{
    public partial class Generator : Form
    {
        private const int HEX_MIN = 69905;   // Hex Value: 11111
        private const int HEX_MAX = 1048575; // Hex Value: FFFFF
        
        private Random rnd;

        public Generator()
        {
            InitializeComponent();
            this.rnd = new Random();
        }

        public string generateSerial(int sections, string separator)
        {
             string serial = "";
             for(int i = 0; i < sections; i++)
             {
                  serial+=this.rnd.Next(HEX_MIN, HEX_MAX).ToString("X");
                  if (i < (sections - 1)) serial += separator;
             }
             GenOutput.Text += serial + "\n";
             return serial;
        }

        private void GenButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "1";
            else if (textBox1.Text == "999")
                textBox1.Text = "1000";

            if (GenOutput.TextLength >= 29000)
                GenOutput.ResetText();

            int value = Int32.Parse(textBox1.Text);
            for (int i = 0; i < value; i++)
                if (textBox1.Text == "")
                {
                    value = 1;
                    generateSerial(5, "-");
                }
                else
                    generateSerial(5, "-");
        }
    }
}
