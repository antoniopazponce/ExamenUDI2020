namespace Presentation
{
    partial class Frm_Profesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProfesion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNivel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFlatGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlatEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlatEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFlatLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesion)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProfesion
            // 
            this.dgvProfesion.BackgroundColor = System.Drawing.Color.Red;
            this.dgvProfesion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProfesion.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProfesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfesion.EnableHeadersVisualStyles = false;
            this.dgvProfesion.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvProfesion.Location = new System.Drawing.Point(0, 0);
            this.dgvProfesion.Name = "dgvProfesion";
            this.dgvProfesion.RowHeadersWidth = 51;
            this.dgvProfesion.RowTemplate.Height = 24;
            this.dgvProfesion.Size = new System.Drawing.Size(800, 216);
            this.dgvProfesion.TabIndex = 0;
            this.dgvProfesion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesion_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(125, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(125, 126);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(160, 47);
            this.txtDescripcion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "DESCRIPCION";
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(125, 82);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(144, 22);
            this.txtNivel.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(19, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "NIVEL";
            // 
            // btnFlatGuardar
            // 
            this.btnFlatGuardar.Activecolor = System.Drawing.Color.Silver;
            this.btnFlatGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnFlatGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlatGuardar.BorderRadius = 0;
            this.btnFlatGuardar.ButtonText = "GUARDAR";
            this.btnFlatGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlatGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFlatGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlatGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFlatGuardar.Iconimage = global::Presentation.Properties.Resources.salvar;
            this.btnFlatGuardar.Iconimage_right = null;
            this.btnFlatGuardar.Iconimage_right_Selected = null;
            this.btnFlatGuardar.Iconimage_Selected = null;
            this.btnFlatGuardar.IconMarginLeft = 0;
            this.btnFlatGuardar.IconMarginRight = 0;
            this.btnFlatGuardar.IconRightVisible = true;
            this.btnFlatGuardar.IconRightZoom = 0D;
            this.btnFlatGuardar.IconVisible = true;
            this.btnFlatGuardar.IconZoom = 90D;
            this.btnFlatGuardar.IsTab = false;
            this.btnFlatGuardar.Location = new System.Drawing.Point(405, 21);
            this.btnFlatGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatGuardar.Name = "btnFlatGuardar";
            this.btnFlatGuardar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatGuardar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatGuardar.selected = false;
            this.btnFlatGuardar.Size = new System.Drawing.Size(170, 60);
            this.btnFlatGuardar.TabIndex = 13;
            this.btnFlatGuardar.Text = "GUARDAR";
            this.btnFlatGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlatGuardar.Textcolor = System.Drawing.Color.Black;
            this.btnFlatGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlatGuardar.Click += new System.EventHandler(this.btnFlatGuardar_Click);
            // 
            // btnFlatEditar
            // 
            this.btnFlatEditar.Activecolor = System.Drawing.Color.Silver;
            this.btnFlatEditar.BackColor = System.Drawing.Color.Silver;
            this.btnFlatEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlatEditar.BorderRadius = 0;
            this.btnFlatEditar.ButtonText = "EDITAR";
            this.btnFlatEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlatEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFlatEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlatEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFlatEditar.Iconimage = global::Presentation.Properties.Resources.Editar;
            this.btnFlatEditar.Iconimage_right = null;
            this.btnFlatEditar.Iconimage_right_Selected = null;
            this.btnFlatEditar.Iconimage_Selected = null;
            this.btnFlatEditar.IconMarginLeft = 0;
            this.btnFlatEditar.IconMarginRight = 0;
            this.btnFlatEditar.IconRightVisible = true;
            this.btnFlatEditar.IconRightZoom = 0D;
            this.btnFlatEditar.IconVisible = true;
            this.btnFlatEditar.IconZoom = 90D;
            this.btnFlatEditar.IsTab = false;
            this.btnFlatEditar.Location = new System.Drawing.Point(405, 113);
            this.btnFlatEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatEditar.Name = "btnFlatEditar";
            this.btnFlatEditar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatEditar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatEditar.selected = false;
            this.btnFlatEditar.Size = new System.Drawing.Size(170, 60);
            this.btnFlatEditar.TabIndex = 14;
            this.btnFlatEditar.Text = "EDITAR";
            this.btnFlatEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlatEditar.Textcolor = System.Drawing.Color.Black;
            this.btnFlatEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlatEditar.Click += new System.EventHandler(this.btnFlatEditar_Click);
            // 
            // btnFlatEliminar
            // 
            this.btnFlatEliminar.Activecolor = System.Drawing.Color.Silver;
            this.btnFlatEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnFlatEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlatEliminar.BorderRadius = 0;
            this.btnFlatEliminar.ButtonText = "ELIMINAR";
            this.btnFlatEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlatEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFlatEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlatEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFlatEliminar.Iconimage = global::Presentation.Properties.Resources.basura;
            this.btnFlatEliminar.Iconimage_right = null;
            this.btnFlatEliminar.Iconimage_right_Selected = null;
            this.btnFlatEliminar.Iconimage_Selected = null;
            this.btnFlatEliminar.IconMarginLeft = 0;
            this.btnFlatEliminar.IconMarginRight = 0;
            this.btnFlatEliminar.IconRightVisible = true;
            this.btnFlatEliminar.IconRightZoom = 0D;
            this.btnFlatEliminar.IconVisible = true;
            this.btnFlatEliminar.IconZoom = 90D;
            this.btnFlatEliminar.IsTab = false;
            this.btnFlatEliminar.Location = new System.Drawing.Point(629, 21);
            this.btnFlatEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatEliminar.Name = "btnFlatEliminar";
            this.btnFlatEliminar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatEliminar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatEliminar.selected = false;
            this.btnFlatEliminar.Size = new System.Drawing.Size(153, 60);
            this.btnFlatEliminar.TabIndex = 15;
            this.btnFlatEliminar.Text = "ELIMINAR";
            this.btnFlatEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlatEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnFlatEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlatEliminar.Click += new System.EventHandler(this.btnFlatEliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFlatLimpiar);
            this.panel1.Controls.Add(this.btnFlatEliminar);
            this.panel1.Controls.Add(this.btnFlatEditar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFlatGuardar);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtNivel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 234);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnFlatLimpiar
            // 
            this.btnFlatLimpiar.Activecolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.BackColor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlatLimpiar.BorderRadius = 0;
            this.btnFlatLimpiar.ButtonText = "LIMPIAR";
            this.btnFlatLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlatLimpiar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFlatLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFlatLimpiar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFlatLimpiar.Iconimage = global::Presentation.Properties.Resources.limpieza;
            this.btnFlatLimpiar.Iconimage_right = null;
            this.btnFlatLimpiar.Iconimage_right_Selected = null;
            this.btnFlatLimpiar.Iconimage_Selected = null;
            this.btnFlatLimpiar.IconMarginLeft = 0;
            this.btnFlatLimpiar.IconMarginRight = 0;
            this.btnFlatLimpiar.IconRightVisible = true;
            this.btnFlatLimpiar.IconRightZoom = 0D;
            this.btnFlatLimpiar.IconVisible = true;
            this.btnFlatLimpiar.IconZoom = 90D;
            this.btnFlatLimpiar.IsTab = false;
            this.btnFlatLimpiar.Location = new System.Drawing.Point(626, 98);
            this.btnFlatLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatLimpiar.Name = "btnFlatLimpiar";
            this.btnFlatLimpiar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatLimpiar.selected = false;
            this.btnFlatLimpiar.Size = new System.Drawing.Size(156, 75);
            this.btnFlatLimpiar.TabIndex = 16;
            this.btnFlatLimpiar.Text = "LIMPIAR";
            this.btnFlatLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlatLimpiar.Textcolor = System.Drawing.Color.Black;
            this.btnFlatLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlatLimpiar.Click += new System.EventHandler(this.btnFlatLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Profesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProfesion);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Profesion";
            this.Text = "Frm_Profesion";
            this.Load += new System.EventHandler(this.Frm_Profesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProfesion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNivel;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatEliminar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}