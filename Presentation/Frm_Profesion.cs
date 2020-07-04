using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using C_Entidades;

namespace Presentation
{
    public partial class Frm_Profesion : Form
    {
        private bool Editarce = false;
        private string idProfesion;
        ProfesionE profesionE = new ProfesionE();
        ProfesionB profesionB = new ProfesionB();
        public Frm_Profesion()
        {
            InitializeComponent();
        }

        private void Frm_Profesion_Load(object sender, EventArgs e)
        {
            MostrarProfesion();
        }
        public void MostrarProfesion()
        {
            ProfesionB profesion = new ProfesionB();
            dgvProfesion.DataSource = profesion.ObtenerTodoProfesion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
          
        }
        public void LimpiarTexto()
        {
            Editarce = false;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtNivel.Text = "";
            txtNombre.Focus();
        }

        private void dgvProfesion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Editarce = true;
                DataGridViewRow row = this.dgvProfesion.Rows[e.RowIndex];
                //RECORDATORIO PERSONAL: NO TE OLVIDES DE ESTO
                //------------------------------------------------------
                idProfesion = dgvProfesion.CurrentRow.Cells[0].Value.ToString();
               // ------------------------------------------------------
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtNivel.Text = row.Cells["NIVEL"].Value.ToString();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {   
            
        }

        private void btnFlatGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;
            profesionE.Nombre = txtNombre.Text.ToUpper();
            profesionE.Descripcion = txtDescripcion.Text.ToUpper();
            profesionE.NIVEL = Convert.ToInt16(txtNivel.Text);
            profesionB.Create(profesionE);
            MessageBox.Show("SE GUARDO CON EXITO");
            MostrarProfesion();
        }

        private void btnFlatEliminar_Click(object sender, EventArgs e)
        {
            //SI EDITARSE ES VERDADERO ENTONCES QUE ELIMINE 
            
            if (Editarce == true)
            {
                profesionE.idProfesion = Convert.ToInt32(dgvProfesion.CurrentRow.Cells[0].Value.ToString());
                profesionB.Eliminar(profesionE);
                MessageBox.Show("SE ELIMINO CON EXITO");
                MostrarProfesion();
            }
            else
            {
                MessageBox.Show("NO SE ELIMINO CON EXITO");
            }
        }

        private void btnFlatEditar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;
            if (Editarce == true)

            {
                profesionE.idProfesion = Convert.ToInt32(idProfesion);
                profesionE.Nombre = txtNombre.Text.ToUpper();
                profesionE.Descripcion = txtDescripcion.Text.ToUpper();
                profesionE.NIVEL = Convert.ToInt16(txtNivel.Text);
                profesionB.Editar(profesionE);
                MessageBox.Show("SE ACTUALIZO CON EXITO");
                MostrarProfesion();
                Editarce = false;
                LimpiarTexto();
            }
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private bool Validacion()
        {
            bool resul = true;
            errorProvider1.Clear();
            //Verifico campos del cliente
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es Obligatorio");
                resul = false;
            }
            
            if (string.IsNullOrEmpty(txtNivel.Text))
            {
                errorProvider1.SetError(txtNivel, "El Nivel es Obligatorio");
                resul = false;
            }

            return resul;
        }
        private void btnFlatLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }
    }
}
