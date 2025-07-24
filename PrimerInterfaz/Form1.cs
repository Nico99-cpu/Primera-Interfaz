using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerInterfaz
{
    public partial class frmInterfaz : Form
    {
        public frmInterfaz()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //if(){
            //    if (txtNombre.Text == "")
            //        txtNombre.BackColor = Color.Red;
            //    else
            //    {
            //        txtNombre.BackColor = System.Drawing.SystemColors.Control;
            //        string Nombre = txtNombre.Text;
            //        string Apellido = txtApellido.Text;
            //        lstResultado.Items.Add("Nombre y Apellido: " + Nombre + " " + Apellido);
            //    }
            //    if (txtApellido.Text == "")
            //        txtApellido.BackColor = Color.Red;
            //    else
            //    {
            //        txtApellido.BackColor = System.Drawing.SystemColors.Control;
            //    }
            //    if (txtDireccion.Text == "")
            //        txtDireccion.BackColor = Color.Red;
            //    else
            //    {
            //        txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            //        string Direccion = txtDireccion.Text;
            //        lstResultado.Items.Add("Direccion: " + Direccion);

            //    }
            //    if (txtEdad.Text == "")
            //        txtEdad.BackColor = Color.Red;
            //    else
            //    {
            //        txtEdad.BackColor = System.Drawing.SystemColors.Control;
            //        string Edad = txtEdad.Text;
            //        lstResultado.Items.Add("Edad: " + Edad);
            //    }

            //}
            //else
            //    MessageBox.Show("Complete los campos faltantes");

            if (txtNombre.Text != "" && txtApellido.Text != "" && txtDireccion.Text != "" && txtEdad.Text != "")
            {
                // Todos los campos están completos → Fondo normal
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
                txtApellido.BackColor = System.Drawing.SystemColors.Window;
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;
                txtEdad.BackColor = System.Drawing.SystemColors.Window;

                // Obtener datos
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string Direccion = txtDireccion.Text;
                string Edad = txtEdad.Text;

                // Mostrar en la lista
                lstResultado.Items.Add("Nombre y Apellido: " + Nombre + " " + Apellido);
                lstResultado.Items.Add("Dirección: " + Direccion);
                lstResultado.Items.Add("Edad: " + Edad);
            }
            else
            {
                // Verificamos cada campo vacío y lo marcamos en rojo
                if (txtNombre.Text == "") txtNombre.BackColor = Color.Red;
                if (txtApellido.Text == "") txtApellido.BackColor = Color.Red;
                if (txtDireccion.Text == "") txtDireccion.BackColor = Color.Red;
                if (txtEdad.Text == "") txtEdad.BackColor = Color.Red;

                // Mostrar mensaje
                MessageBox.Show("Debe completar todos los campos para continuar.");
                txtNombre.BackColor = System.Drawing.SystemColors.Window;
                txtApellido.BackColor = System.Drawing.SystemColors.Window;
                txtDireccion.BackColor = System.Drawing.SystemColors.Window;
                txtEdad.BackColor = System.Drawing.SystemColors.Window;

            }









        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            DialogResult Resultado = MessageBox.Show("Estas seguro de salir de la aplicacion? ", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         

            if (Resultado == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
