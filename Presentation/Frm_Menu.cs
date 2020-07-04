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


namespace Presentation
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }
        public void AbrirFormullario(object formulariomenu)
        {
            if(this.paneldeFormulario.Controls.Count>0)
            {
                this.paneldeFormulario.Controls.RemoveAt(0);
                Form frm = formulariomenu as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.paneldeFormulario.Controls.Add(frm);
                this.paneldeFormulario.Tag = frm;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.BringToFront();
                frm.Show();
            }
        }
        private void btnMenuEmpleado_Click(object sender, EventArgs e)
        {

            AbrirFormullario(new Frm_Empleado());
        }

        private void btnmenuCargo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenuProfesion_Click(object sender, EventArgs e)
        {
        }

        private void btnMenuDepartamento_Click(object sender, EventArgs e)
        {
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnFlatEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormullario(new Frm_Empleado());
        }

        private void btnflatCargo_Click(object sender, EventArgs e)
        {
            AbrirFormullario(new Frm_Cargo());
        }

        private void btnFlatProfesion_Click(object sender, EventArgs e)
        {
            AbrirFormullario(new Frm_Profesion());

        }

        private void btnflatDepartamento_Click(object sender, EventArgs e)
        {
            AbrirFormullario(new Frm_Departamento());
        }
    }
}
