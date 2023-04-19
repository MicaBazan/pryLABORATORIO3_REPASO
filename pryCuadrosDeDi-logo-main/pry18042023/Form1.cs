using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry18042023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = textBox1.ForeColor;
 
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.ForeColor = MyDialog.Color;
                label1.ForeColor = MyDialog.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
            textBox1.Font = fontDialog1.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
            string ruta = folderBrowserDialog1.SelectedPath;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
