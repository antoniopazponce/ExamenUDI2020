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
using BunifuAnimatorNS;

namespace Presentation
{
    public partial class Frm_Empleado : Form
    {
        
        public bool Genero = false;
        //
        private bool editarce = false;
        string _idEmpleado;
        EmpleadoB eB = new EmpleadoB();
        EmpleadoE eE = new EmpleadoE();
     
        public Frm_Empleado()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Load(object sender, EventArgs e)
        {
            
            Listar_CargoEmpleado();
            Listar_ProfesionEmpleado();
        }
        /// <summary>
        /// METODO QUE USO PARA EL COMBO BOX CARGO
        /// </summary>
        public void Listar_CargoEmpleado()
        {
            CargoB cargo = new CargoB();
            cmboxIdCargo.DataSource = cargo.ObtenerCargo();
            cmboxIdCargo.DisplayMember = "Nombre";
            cmboxIdCargo.ValueMember = "idCargo";
        }
        /// <summary>
        /// METODO QUE USO PARA EL COMBO BOX PROFESION
        /// </summary>
        public void  Listar_ProfesionEmpleado()
        {
            ProfesionB profesion = new ProfesionB();
            cmboxIdProfesion.DataSource = profesion.ObtenerTodoProfesion();
            cmboxIdProfesion.DisplayMember = "Nombre";
            cmboxIdProfesion.ValueMember = "idProfesion";
        }
        /// <summary>
        /// BOTON GUARDAR 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;

            try
            {
                eE.idCargo = Convert.ToInt32(cmboxIdCargo.SelectedValue);
                eE.idProfesion = Convert.ToInt32(cmboxIdProfesion.SelectedValue);
                eE.NombreCompleto = txtNombre.Text.ToUpper();
                eE.CI = txtCi.Text.ToUpper();
                eE.FechaNacimiento = dtimeFechaNacimiento.Value;
                eE.LugarNacimiento = txtLugarN.Text.ToUpper();
                eE.Sexo = Genero;
                eE.Direccion = txtdireccion.Text;
                eE.Telefono = txtTelefono.Text;
                eE.Celular = txtCelular.Text;
                eE.FechaIngreso = Convert.ToDateTime(dTimeFechaIngreso.Value);
                eE.Sueldo = Convert.ToDecimal(txtSueldo.Text);
                eB.CreateEmpleado(eE);
                VerEmpleado();
                LimpiarTexto();
                MessageBox.Show("SE AGREGO CON EXITO","EXITO",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR" + ex);
            }
        }

        private void checkbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = false;
        }

        private void checkbtnFemenino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = true;
        }
        /// <summary>
        /// BONT MOSTRAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bntMostar_Click(object sender, EventArgs e)
        {
            VerEmpleado();
        }
        /// <summary>
        /// METODO QUE VALIDA SI HAY INFORMACION EN LOS TEXT BOX IMPORTANTES
        /// </summary>
        /// <returns></returns>
       private bool Validacion()
        {
            bool resul = true;
            errorProvider1.Clear();
            //Verifico campos del cliente
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es Obligatorio");
                resul= false;
            }
            if(string.IsNullOrEmpty(txtSueldo.Text))
            {
                errorProvider1.SetError(txtSueldo, "el sueldo es Obligatorio");
                resul = false;
            }
            if (string.IsNullOrEmpty(txtCi.Text))
            {
                errorProvider1.SetError(txtCi, "El CI es Obligatorio");
                resul = false;
            }
           
            return resul;
        }
        /// <summary>
        /// BOTON ELIMINAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(editarce == true)
            {
                DialogResult r = MessageBox.Show("ESTAS SE ELIMINARA EL EMPLEADO ESTAS SEGRUR@?", "ALERTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (r == DialogResult.OK)
                {
                    try
                    {
                        eE.idEmpleado = Convert.ToInt32(dgvEmpleado.CurrentRow.Cells[0].Value.ToString());
                        eB.Eliminar(eE);
                        VerEmpleado();
                        LimpiarTexto();
                        MessageBox.Show("Se elimino con exito");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("nO Se elimino con exito" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("SE CANCELO", "CANCELADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("PARA ELIMINAR PRIMERO DEBE SELECCIONAR A UN EMPLEADO");

            }
        }

        private void cmboxIdProfesion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// EVENTO PARA QUE CON UN CLICK PASE LA INFORMACION 
        /// DE UN DGV A LOS TXTBOX Y OTROS
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                editarce = true;
                DataGridViewRow row = this.dgvEmpleado.Rows[e.RowIndex];
                _idEmpleado = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = row.Cells["NombreCompleto"].Value.ToString();
                txtCi.Text = row.Cells["CI"].Value.ToString();
                dtimeFechaNacimiento.Value =Convert.ToDateTime( row.Cells["FechaNacimiento"].Value.ToString());
                txtLugarN.Text = row.Cells["LugarNacimiento"].Value.ToString();
                Genero =Convert.ToBoolean( row.Cells["Sexo"].Value.ToString());
                txtdireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtCelular.Text = row.Cells["Celular"].Value.ToString();
                dTimeFechaIngreso.Value = Convert.ToDateTime(row.Cells["FechaIngreso"].Value.ToString());
                txtSueldo.Text = row.Cells["Sueldo"].Value.ToString();
                cmboxIdProfesion.SelectedValue = Convert.ToInt32(row.Cells["idProfesion"].Value.ToString());
                cmboxIdCargo.SelectedValue = Convert.ToInt32(row.Cells["idCargo"].Value.ToString());
            }
        }
        /// <summary>
        /// BOTON EDITAR
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!Validacion())
                return;
            if(editarce==true)
            {
                eE.idEmpleado = Convert.ToInt32(_idEmpleado);
                eE.NombreCompleto = txtNombre.Text.ToUpper();
                eE.idCargo = Convert.ToInt32(cmboxIdCargo.SelectedValue);
                eE.idProfesion = Convert.ToInt32(cmboxIdProfesion.SelectedValue);
                eE.CI = txtCi.Text.ToUpper();
                eE.FechaNacimiento = dtimeFechaNacimiento.Value;
                eE.LugarNacimiento = txtLugarN.Text.ToUpper();
                eE.Sexo = Genero;
                eE.Direccion = txtdireccion.Text;
                eE.Telefono = txtTelefono.Text;
                eE.Celular = txtCelular.Text;
                eE.FechaIngreso = Convert.ToDateTime(dTimeFechaIngreso.Value);
                eE.Sueldo = Convert.ToDecimal(txtSueldo.Text);
                eB.EditarEmpledo(eE);
                MessageBox.Show("SE edito CON EXITO","EXITO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                VerEmpleado();
                LimpiarTexto();
            }
            else
            {
                MessageBox.Show("PARA ACTUALIZAR DEBE SELECCIONAR A UN EMPLEADO");
                LimpiarTexto();
            }
        }
        /// <summary>
        /// METODO QUE ME PERMITE VER LOS EMPLEADOS
        /// </summary>
        public void VerEmpleado()
        {
            EmpleadoB empleado = new EmpleadoB();
            dgvEmpleado.DataSource = empleado.MostrarEmpleado();
        }
        /// <summary>
        /// METODO QUE LIMPIA LOS TEXT BOX
        /// </summary>
        public void LimpiarTexto()
        {
            editarce = false;
            txtNombre.Text = "";
            txtCi.Text = "";
            txtLugarN.Text = "";
            txtdireccion.Text = "";
            txtTelefono.Text = "";
            txtCelular.Text = "";
            txtSueldo.Text = "";
            cmboxIdProfesion.SelectedValue = "";
            cmboxIdCargo.SelectedValue = "";
        }
        /// <summary>
        /// BOTON QUE BUSCA POR NOMBRE AL EMPLEADO
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            if (!(txtBuscarNombre.Text==""))
            {
                eE.NombreCompleto = txtBuscarNombre.Text;
                dgvEmpleado.DataSource = eB.BuscarPorNombre(eE);
            }
        }

        private void btnFlatLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTexto();
        }
    }
        
}
