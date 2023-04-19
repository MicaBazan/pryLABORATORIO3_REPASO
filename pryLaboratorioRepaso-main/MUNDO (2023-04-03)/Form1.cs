using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUNDO__2023_04_03_
{
    public partial class Form1 : Form
    {
        Paises p;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                p.Pais = Convert.ToInt32(txtPais.Text);
                p.Nombre = txtNombre.Text;
                p.Capital = txtCapital.Text;

                p.grabar();

                if (p.Pais == 0)
                {
                    MessageBox.Show("PAIS REPETIDO, NO SE PUDO GRABAR", "ERROR");
                }
                else
                {
                    txtPais.Text = "";
                    txtNombre.Text = "";
                    txtCapital.Text = "";

                    txtPais.Focus();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("INGRESE UN NUMERO....", "ERROR");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                p.Pais = Convert.ToInt32(txtPais.Text);
                p.buscar();
                if (p.Pais == 0)
                {
                    MessageBox.Show("NO EXISTE EL PAIS QUE ESTA CONSULTANDO", "ERROR");
                }
                else
                {
                    txtNombre.Text = p.Nombre;
                    txtCapital.Text = p.Capital;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese un numero...", "ERROR");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                p = new Paises();

                grilla.DataSource = p.getAll();
                grilla.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                MessageBox.Show("PROBLEMAS CON LA BASE DE DATOS", "ERROR");
                this.Close();
            }
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                p.Pais = Convert.ToInt32(txtPais.Text);
                p.eliminar();
                txtPais.Text = "";
                txtNombre.Text = "";
                txtCapital.Text = "";

                txtPais.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show("DEBE INGRESAR UN NUMERO....", "ERROR");
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                p.Pais = Convert.ToInt32(txtPais.Text);
                p.Nombre = txtNombre.Text;
                p.Capital = txtCapital.Text;
                p.modificar();
                txtPais.Text = "";
                txtNombre.Text = "";
                txtCapital.Text = "";

                txtPais.Focus();
            }
            //EXCEPTION: CLASE PARA MANEJAR EXCEPCIONES DE MANERA GENERAL
            catch(Exception ex)
            {
                MessageBox.Show("DEBE INGRESAR UN NUMERO....", "ERROR");
            }
            //SIEMPRE SE VA EJECUTAR
            //ESCRIBIR UN CODIGO QUE SE EJECUTA CUANDO 
            //SE EJECUTA LA EXCEPTION
            finally
            {
                MessageBox.Show("ESTA NOCHE ME COMO UN LOMITO");
            }
            
        }
    }
}
