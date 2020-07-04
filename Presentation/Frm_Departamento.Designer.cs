namespace Presentation
{
    partial class Frm_Departamento
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDepartamento = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescipcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MoverFrm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFlatGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlatEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlatEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlatLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDepartamento
            // 
            this.dgvDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartamento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamento.EnableHeadersVisualStyles = false;
            this.dgvDepartamento.Location = new System.Drawing.Point(392, 0);
            this.dgvDepartamento.Name = "dgvDepartamento";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDepartamento.RowHeadersWidth = 51;
            this.dgvDepartamento.RowTemplate.Height = 24;
            this.dgvDepartamento.Size = new System.Drawing.Size(655, 571);
            this.dgvDepartamento.TabIndex = 0;
            this.dgvDepartamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamento_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(46, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescipcion
            // 
            this.txtDescipcion.Location = new System.Drawing.Point(46, 158);
            this.txtDescipcion.Multiline = true;
            this.txtDescipcion.Name = "txtDescipcion";
            this.txtDescipcion.Size = new System.Drawing.Size(303, 134);
            this.txtDescipcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "DESCRIPCION";
            // 
            // MoverFrm
            // 
            this.MoverFrm.Fixed = true;
            this.MoverFrm.Horizontal = true;
            this.MoverFrm.TargetControl = null;
            this.MoverFrm.Vertical = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFlatGuardar);
            this.groupBox1.Controls.Add(this.btnFlatEditar);
            this.groupBox1.Controls.Add(this.btnFlatEliminar);
            this.groupBox1.Controls.Add(this.btnFlatLimpiar);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescipcion);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 571);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DEPARTAMENTO";
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
            this.btnFlatGuardar.Location = new System.Drawing.Point(181, 324);
            this.btnFlatGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatGuardar.Name = "btnFlatGuardar";
            this.btnFlatGuardar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatGuardar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatGuardar.selected = false;
            this.btnFlatGuardar.Size = new System.Drawing.Size(168, 75);
            this.btnFlatGuardar.TabIndex = 12;
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
            this.btnFlatEditar.Location = new System.Drawing.Point(13, 433);
            this.btnFlatEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatEditar.Name = "btnFlatEditar";
            this.btnFlatEditar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatEditar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatEditar.selected = false;
            this.btnFlatEditar.Size = new System.Drawing.Size(156, 75);
            this.btnFlatEditar.TabIndex = 11;
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
            this.btnFlatEliminar.Location = new System.Drawing.Point(181, 433);
            this.btnFlatEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatEliminar.Name = "btnFlatEliminar";
            this.btnFlatEliminar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatEliminar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatEliminar.selected = false;
            this.btnFlatEliminar.Size = new System.Drawing.Size(168, 75);
            this.btnFlatEliminar.TabIndex = 10;
            this.btnFlatEliminar.Text = "ELIMINAR";
            this.btnFlatEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlatEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnFlatEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlatEliminar.Click += new System.EventHandler(this.btnFlatEliminar_Click);
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
            this.btnFlatLimpiar.Location = new System.Drawing.Point(13, 324);
            this.btnFlatLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatLimpiar.Name = "btnFlatLimpiar";
            this.btnFlatLimpiar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatLimpiar.selected = false;
            this.btnFlatLimpiar.Size = new System.Drawing.Size(156, 75);
            this.btnFlatLimpiar.TabIndex = 9;
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
            // Frm_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1048, 571);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDepartamento);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Departamento";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamento)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescipcion;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl MoverFrm;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatLimpiar;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatGuardar;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatEditar;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

