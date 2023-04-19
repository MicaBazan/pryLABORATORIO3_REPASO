using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryNodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* string[] frutas = { "UVA", "PERA", "NARANJA" };*/
            TreeNode abuelo;
            TreeNode padre;
            TreeNode hijo;

            abuelo = treeView1.Nodes.Add("ALIMENTOS");

            padre = abuelo.Nodes.Add("FRUTAS");
            hijo = padre.Nodes.Add("UVA");
            hijo.Tag = "$300";
            hijo = padre.Nodes.Add("MANZANA");
            hijo.Tag = "$400";
            hijo = padre.Nodes.Add("NARANJA");
            hijo.Tag = "$500";
            hijo = padre.Nodes.Add("BANANA");
            hijo.Tag = "$450";

            //foreach(string fruta in frutas)
            //{
            //    hijo = padre.Nodes.Add(fruta);
            //}

            padre = abuelo.Nodes.Add("VERDURAS");
            hijo = padre.Nodes.Add("ACELGA");
            hijo.Tag = "$350";
            hijo = padre.Nodes.Add("LECHUGA");
            hijo.Tag = "$200";
            hijo = padre.Nodes.Add("PIMIENTO");
            hijo.Tag = "$450";

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Level == 2)
            {
                lblNombre.Text = (e.Node.Text.ToString());
            }

            if(e.Node.Level == 2)
            {
                lblPrecio.Text = (e.Node.Tag.ToString());
            }
        }
    }
}
