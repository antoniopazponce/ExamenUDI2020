using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Entidades;
using Business;

namespace Presentation
{
    public partial class Frm_Departamento : Form
    {
        private string idDepartamento;
        private bool editarce = false;
        DepartamentoB departamentoB = new DepartamentoB();
        DepartamentoE departamentoE = new DepartamentoE();
        public Frm_Departamento()
        {
            InitializeComponent();
        }

        private void Frm_Departamento_Load(object sender, EventArgs e)
        {
            MostrarDepartamento();
        } 
        /// <summary>
        /// metodo auxiliar que mostrara la tabla departamento
        /// </summary>
        public void MostrarDepartamento()
        {
            DepartamentoB departamentoFrmB = new DepartamentoB();
            dgvDepartamento.DataSource = departamentoFrmB.MostrarDepartamentos();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            
           
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// metodo auxiliar que limpiara todo los textos
        /// </summary>
        public void LimpiarTexto()
        {
            editarce = false;
            txtNombre.Text = "";
            txtDescipcion.Text = "";
            txtNombre.Focus();
        }

        private void dgvDepartamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editarce = true;
                DataGridViewRow row = this.dgvDepartamento.Rows[e.RowIndex];
                //RECORDATORIO PARA ANTONIO: NO TE OLVIDES DE ESTO
                //------------------------------------------------------
                idDepartamento = dgvDepartamento.CurrentRow.Cells[0].Value.ToString();
                // ------------------------------------------------------
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescipcion.Text = row.Cells["Descripcion"].Value.ToString();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void CerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFlatLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();

        }

        private void btnFlatGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;
            try
            {
                departamentoE.Nombre = txtNombre.Text.ToUpper();
                departamentoE.Descripcion = txtDescipcion.Text.ToUpper();
                departamentoB.Create(departamentoE);

                MessageBox.Show(" SE GUARDO CON EXITO");
                MostrarDepartamento();
                LimpiarTexto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void btnFlatEditar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;
            if (editarce == true)
            {
                try
                {
                    departamentoE.idDepartamento = Convert.ToInt32(idDepartamento);
                    departamentoE.Nombre = txtNombre.Text.ToUpper();
                    departamentoE.Descripcion = txtDescipcion.Text.ToUpper();
                    departamentoB.EditarDepartamento(departamentoE);

                    MessageBox.Show(" SE EDITO CON EXITO");
                    MostrarDepartamento();
                    editarce = false;
                    LimpiarTexto();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex);
                }
            }
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
            

            return resul;
        }
        private void btnFlatEliminar_Click(object sender, EventArgs e)
        {
            if (editarce == true)
            {
                departamentoE.idDepartamento = Convert.ToInt32(dgvDepartamento.CurrentRow.Cells[0].Value.ToString());
                departamentoB.EliminarDepartamento(departamentoE);

                MessageBox.Show("Se elimino Correctamente");
                MostrarDepartamento();
            }
            else
            {
                MessageBox.Show("NO SE elimino Correctamente");

            }
        }
    }
}
