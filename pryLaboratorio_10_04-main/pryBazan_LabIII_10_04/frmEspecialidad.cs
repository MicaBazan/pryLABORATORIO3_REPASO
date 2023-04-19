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
    public partial class frmEspecialidad : Form
    {
        Especialidades esp;
        Medicos med;

        public frmEspecialidad()
        {
            InitializeComponent();
        }

        private void frmEspecialidad_Load(object sender, EventArgs e)
        {
            dgvMedicos.Columns.Add("MATRICULA", "MATRICULA");
            dgvMedicos.Columns.Add("NOMBRE", "NOMBRE");
            dgvMedicos.Columns.Add("CELULAR", "CELULAR");

            try
            {
                esp = new Especialidades();

                cbEspecialidad.DisplayMember = "nombre";
                cbEspecialidad.ValueMember = "especialidad";
                cbEspecialidad.DataSource = esp.getAll();

                med = new Medicos();
            }
            catch(Exception ex)
            {
                MessageBox.Show("PROBLEMAS CON A BASE DE DATOS", "ERROR");
                this.Close();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvMedicos.Rows.Clear();

            int especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);
              
            DataTable tabla = med.getAll();

            foreach (DataRow fila in tabla.Rows)
            {
                if (Convert.ToInt32(fila["especialidad"]) == especialidad)
                {
                        dgvMedicos.Rows.Add(fila["matricula"], fila["nombre"], fila["celular"]);

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm f2 = new frm();
            f2.ShowDialog();
        }
    }
}
