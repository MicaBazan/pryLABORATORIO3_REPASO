using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBazan_LabIII_10_04
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicos med = new Medicos();
            listBox1.DisplayMember = "nombre";
            listBox1.ValueMember = "matricula";
            listBox1.DataSource = med.getAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedValue.ToString());
            MessageBox.Show(listBox1.Text);
            MessageBox.Show(listBox1.SelectedIndex.ToString());
        }
    }
}
