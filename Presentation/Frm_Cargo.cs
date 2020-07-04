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
    public partial class Frm_Cargo : Form
    {
        private bool editarce = false;
        private string iDCargo;
        CargoE cE = new CargoE();
        CargoB cB = new CargoB();
        public Frm_Cargo()
        {
            InitializeComponent();
        }

        private void Frm_Cargo_Load(object sender, EventArgs e)
        {
            MostraCarga();
            Listar_Departamento();
            Listar_CargoDependiente();
        }
       public void Listar_CargoDependiente()
        {
            CargoB cargo = new CargoB();
            cmbidcategoria.DataSource = cargo.ObtenerCargo();
            cmbidcategoria.DisplayMember = "Nombre";
            cmbidcategoria.ValueMember = "idCargo";
        }
        public void Listar_Departamento()
        {
            DepartamentoB departamento = new DepartamentoB();
            cmbiddepartamento.DataSource = departamento.MostrarDepartamentos();
            cmbiddepartamento.DisplayMember = "Nombre";
            cmbiddepartamento.ValueMember = "idDepartamento";
        
        }
        private void MostraCarga()
        {
            CargoB cargo = new CargoB();
            dgvCargo.DataSource = cargo.ObtenerCargo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;
            try
            {


                cE.idCargoDependiente = Convert.ToInt32(cmbidcategoria.SelectedValue);
                cE.idDepartamento = Convert.ToInt32(cmbiddepartamento.SelectedValue);
                cE.Nombre = txtNombre.Text;
                cE.Descripcion = txtDescripcion.Text;
                cE.SueldoBase = Convert.ToDecimal(txtSueldo.Text);
                cB.AgregarCargo(cE);
                MessageBox.Show("SE GUARDO CON EXITO");
                MostraCarga();
                LimpiarTexto();
            }
            catch(Exception EX)
            {
                MessageBox.Show("ERROR" + EX);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(editarce == true)
            {
                cE.idCargo = Convert.ToInt32(dgvCargo.CurrentRow.Cells[0].Value.ToString());
                cB.Delete(cE);
                MessageBox.Show("SE ELIMINO CON EXITO");
                MostraCarga();
            }
            else
            {
                MessageBox.Show("NO SE PUDO ELIMINAR");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;
            if(editarce == true)
            {
                try
                {
                    cE.idCargo = Convert.ToInt32(iDCargo);
                    cE.Nombre = txtNombre.Text.ToUpper();
                    cE.Descripcion = txtDescripcion.Text.ToUpper();
                    cE.idCargoDependiente = Convert.ToInt32( cmbidcategoria.SelectedValue);
                    cE.idDepartamento = Convert.ToInt32(cmbiddepartamento.SelectedValue);
                    cE.SueldoBase = Convert.ToDecimal(txtSueldo.Text);
                    cB.Upadate(cE);
                    MessageBox.Show("SE ACTUALIZO CON EXITO");
                    editarce = false;
                    MostraCarga();
                    LimpiarTexto();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("ERROR" + ex);
                }
            }
        }
        public void LimpiarTexto()
        {
            editarce = false;
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtSueldo.Text = "";
            cmbidcategoria.Text = "";
            cmbiddepartamento.Text = "";
            txtNombre.Focus();
        }
        private void dgvCargo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                editarce = true;
                DataGridViewRow row = this.dgvCargo.Rows[e.RowIndex];
                iDCargo = dgvCargo.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
                txtSueldo.Text = row.Cells["SueldoBase"].Value.ToString();
                cmbiddepartamento.DisplayMember = row.Cells["idDepartamento"].Value.ToString();
                cmbidcategoria.DisplayMember = row.Cells["idCargoDependiente"].Value.ToString();
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
            if (string.IsNullOrEmpty(txtSueldo.Text))
            {
                errorProvider1.SetError(txtSueldo, "el sueldo es Obligatorio");
                resul = false;
            }
           

            return resul;
        }
    }

}
