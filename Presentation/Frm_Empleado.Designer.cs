namespace Presentation
{
    partial class Frm_Empleado
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmboxIdProfesion = new System.Windows.Forms.ComboBox();
            this.cmboxIdCargo = new System.Windows.Forms.ComboBox();
            this.LProfesion = new System.Windows.Forms.Label();
            this.LCargo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLugarN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtimeFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.dTimeFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.checkbtnMasculino = new System.Windows.Forms.CheckBox();
            this.checkbtnFemenino = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarNombre = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bntMostar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlatLimpiar = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmboxIdProfesion
            // 
            this.cmboxIdProfesion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmboxIdProfesion.FormattingEnabled = true;
            this.cmboxIdProfesion.Location = new System.Drawing.Point(17, 76);
            this.cmboxIdProfesion.Name = "cmboxIdProfesion";
            this.cmboxIdProfesion.Size = new System.Drawing.Size(219, 24);
            this.cmboxIdProfesion.TabIndex = 1;
            this.cmboxIdProfesion.SelectedIndexChanged += new System.EventHandler(this.cmboxIdProfesion_SelectedIndexChanged);
            // 
            // cmboxIdCargo
            // 
            this.cmboxIdCargo.FormattingEnabled = true;
            this.cmboxIdCargo.Location = new System.Drawing.Point(17, 150);
            this.cmboxIdCargo.Name = "cmboxIdCargo";
            this.cmboxIdCargo.Size = new System.Drawing.Size(219, 24);
            this.cmboxIdCargo.TabIndex = 2;
            // 
            // LProfesion
            // 
            this.LProfesion.AutoSize = true;
            this.LProfesion.Location = new System.Drawing.Point(14, 49);
            this.LProfesion.Name = "LProfesion";
            this.LProfesion.Size = new System.Drawing.Size(88, 17);
            this.LProfesion.TabIndex = 3;
            this.LProfesion.Text = "PROFESION";
            // 
            // LCargo
            // 
            this.LCargo.AutoSize = true;
            this.LCargo.Location = new System.Drawing.Point(14, 121);
            this.LCargo.Name = "LCargo";
            this.LCargo.Size = new System.Drawing.Size(58, 17);
            this.LCargo.TabIndex = 4;
            this.LCargo.Text = "CARGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(275, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCi
            // 
            this.txtCi.Location = new System.Drawing.Point(275, 145);
            this.txtCi.Name = "txtCi";
            this.txtCi.Size = new System.Drawing.Size(243, 22);
            this.txtCi.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "FECHA NACIMIENTO";
            // 
            // txtLugarN
            // 
            this.txtLugarN.Location = new System.Drawing.Point(17, 228);
            this.txtLugarN.Multiline = true;
            this.txtLugarN.Name = "txtLugarN";
            this.txtLugarN.Size = new System.Drawing.Size(243, 67);
            this.txtLugarN.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "LUGAR NACIMIENTO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(811, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "SEXO";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(275, 228);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(243, 67);
            this.txtdireccion.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(272, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "DIRECCION";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(537, 145);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(243, 22);
            this.txtTelefono.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "TELEFONO";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(537, 78);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(243, 22);
            this.txtCelular.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "CELULAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "FECHA INGRESO";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(41, 131);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(133, 22);
            this.txtSueldo.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "SUELDO";
            // 
            // dtimeFechaNacimiento
            // 
            this.dtimeFechaNacimiento.Location = new System.Drawing.Point(537, 228);
            this.dtimeFechaNacimiento.Name = "dtimeFechaNacimiento";
            this.dtimeFechaNacimiento.Size = new System.Drawing.Size(243, 22);
            this.dtimeFechaNacimiento.TabIndex = 26;
            // 
            // dTimeFechaIngreso
            // 
            this.dTimeFechaIngreso.Location = new System.Drawing.Point(41, 63);
            this.dTimeFechaIngreso.Name = "dTimeFechaIngreso";
            this.dTimeFechaIngreso.Size = new System.Drawing.Size(256, 22);
            this.dTimeFechaIngreso.TabIndex = 27;
            // 
            // checkbtnMasculino
            // 
            this.checkbtnMasculino.AutoSize = true;
            this.checkbtnMasculino.Location = new System.Drawing.Point(797, 79);
            this.checkbtnMasculino.Name = "checkbtnMasculino";
            this.checkbtnMasculino.Size = new System.Drawing.Size(110, 21);
            this.checkbtnMasculino.TabIndex = 28;
            this.checkbtnMasculino.Text = "MASCULINO";
            this.checkbtnMasculino.UseVisualStyleBackColor = true;
            this.checkbtnMasculino.CheckedChanged += new System.EventHandler(this.checkbtnMasculino_CheckedChanged);
            // 
            // checkbtnFemenino
            // 
            this.checkbtnFemenino.AutoSize = true;
            this.checkbtnFemenino.Location = new System.Drawing.Point(797, 113);
            this.checkbtnFemenino.Name = "checkbtnFemenino";
            this.checkbtnFemenino.Size = new System.Drawing.Size(101, 21);
            this.checkbtnFemenino.TabIndex = 29;
            this.checkbtnFemenino.Text = "FEMENINO";
            this.checkbtnFemenino.UseVisualStyleBackColor = true;
            this.checkbtnFemenino.CheckedChanged += new System.EventHandler(this.checkbtnFemenino_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleado.BackgroundColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.EnableHeadersVisualStyles = false;
            this.dgvEmpleado.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvEmpleado.Location = new System.Drawing.Point(53, 381);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(1130, 268);
            this.dgvEmpleado.TabIndex = 35;
            this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSueldo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dTimeFechaIngreso);
            this.groupBox1.Location = new System.Drawing.Point(923, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 309);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trabajo";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCi);
            this.groupBox2.Controls.Add(this.cmboxIdProfesion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmboxIdCargo);
            this.groupBox2.Controls.Add(this.checkbtnFemenino);
            this.groupBox2.Controls.Add(this.checkbtnMasculino);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.LProfesion);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.LCargo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtdireccion);
            this.groupBox2.Controls.Add(this.dtimeFechaNacimiento);
            this.groupBox2.Controls.Add(this.txtLugarN);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(913, 309);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFROMACION PERSONAL";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNombre.BackColor = System.Drawing.Color.White;
            this.txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarNombre.ForeColor = System.Drawing.Color.Black;
            this.txtBuscarNombre.Location = new System.Drawing.Point(61, 340);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(547, 15);
            this.txtBuscarNombre.TabIndex = 41;
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarNombre.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarNombre.ErrorImage = global::Presentation.Properties.Resources.Buscar;
            this.btnBuscarNombre.Image = global::Presentation.Properties.Resources.Buscar;
            this.btnBuscarNombre.ImageActive = null;
            this.btnBuscarNombre.Location = new System.Drawing.Point(646, 324);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(70, 51);
            this.btnBuscarNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscarNombre.TabIndex = 42;
            this.btnBuscarNombre.TabStop = false;
            this.btnBuscarNombre.Zoom = 10;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Presentation.Properties.Resources.CajaTexto;
            this.pictureBox1.Location = new System.Drawing.Point(53, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.Gray;
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.Silver;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "EDITAR";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = global::Presentation.Properties.Resources.Editar;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = true;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = true;
            this.btnEditar.IconZoom = 90D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(676, 667);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.Silver;
            this.btnEditar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(155, 68);
            this.btnEditar.TabIndex = 36;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.Textcolor = System.Drawing.Color.Black;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Activecolor = System.Drawing.Color.Gray;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.Silver;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderRadius = 0;
            this.btnEliminar.ButtonText = "ELIMINAR";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminar.Iconimage = global::Presentation.Properties.Resources.basura;
            this.btnEliminar.Iconimage_right = null;
            this.btnEliminar.Iconimage_right_Selected = null;
            this.btnEliminar.Iconimage_Selected = null;
            this.btnEliminar.IconMarginLeft = 0;
            this.btnEliminar.IconMarginRight = 0;
            this.btnEliminar.IconRightVisible = true;
            this.btnEliminar.IconRightZoom = 0D;
            this.btnEliminar.IconVisible = true;
            this.btnEliminar.IconZoom = 90D;
            this.btnEliminar.IsTab = false;
            this.btnEliminar.Location = new System.Drawing.Point(420, 667);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Normalcolor = System.Drawing.Color.Silver;
            this.btnEliminar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnEliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminar.selected = false;
            this.btnEliminar.Size = new System.Drawing.Size(185, 68);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Textcolor = System.Drawing.Color.Black;
            this.btnEliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // bntMostar
            // 
            this.bntMostar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bntMostar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bntMostar.BackColor = System.Drawing.Color.Silver;
            this.bntMostar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bntMostar.BorderRadius = 0;
            this.bntMostar.ButtonText = "Mostrar";
            this.bntMostar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntMostar.DisabledColor = System.Drawing.Color.Gray;
            this.bntMostar.Iconcolor = System.Drawing.Color.Transparent;
            this.bntMostar.Iconimage = global::Presentation.Properties.Resources.ojo;
            this.bntMostar.Iconimage_right = null;
            this.bntMostar.Iconimage_right_Selected = null;
            this.bntMostar.Iconimage_Selected = null;
            this.bntMostar.IconMarginLeft = 0;
            this.bntMostar.IconMarginRight = 0;
            this.bntMostar.IconRightVisible = true;
            this.bntMostar.IconRightZoom = 0D;
            this.bntMostar.IconVisible = true;
            this.bntMostar.IconZoom = 90D;
            this.bntMostar.IsTab = false;
            this.bntMostar.Location = new System.Drawing.Point(1062, 656);
            this.bntMostar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bntMostar.Name = "bntMostar";
            this.bntMostar.Normalcolor = System.Drawing.Color.Silver;
            this.bntMostar.OnHovercolor = System.Drawing.Color.Silver;
            this.bntMostar.OnHoverTextColor = System.Drawing.Color.White;
            this.bntMostar.selected = false;
            this.bntMostar.Size = new System.Drawing.Size(121, 51);
            this.bntMostar.TabIndex = 30;
            this.bntMostar.Text = "Mostrar";
            this.bntMostar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntMostar.Textcolor = System.Drawing.Color.Black;
            this.bntMostar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMostar.Click += new System.EventHandler(this.bntMostar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Activecolor = System.Drawing.Color.Gray;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Silver;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.BorderRadius = 0;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.DisabledColor = System.Drawing.Color.Gray;
            this.btnGuardar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGuardar.Iconimage = global::Presentation.Properties.Resources.Guardar;
            this.btnGuardar.Iconimage_right = null;
            this.btnGuardar.Iconimage_right_Selected = null;
            this.btnGuardar.Iconimage_Selected = null;
            this.btnGuardar.IconMarginLeft = 0;
            this.btnGuardar.IconMarginRight = 0;
            this.btnGuardar.IconRightVisible = true;
            this.btnGuardar.IconRightZoom = 0D;
            this.btnGuardar.IconVisible = true;
            this.btnGuardar.IconZoom = 90D;
            this.btnGuardar.IsTab = false;
            this.btnGuardar.Location = new System.Drawing.Point(120, 667);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Normalcolor = System.Drawing.Color.Silver;
            this.btnGuardar.OnHovercolor = System.Drawing.Color.SlateGray;
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuardar.selected = false;
            this.btnGuardar.Size = new System.Drawing.Size(204, 68);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.Textcolor = System.Drawing.Color.Black;
            this.btnGuardar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFlatLimpiar
            // 
            this.btnFlatLimpiar.Activecolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnFlatLimpiar.Location = new System.Drawing.Point(864, 667);
            this.btnFlatLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlatLimpiar.Name = "btnFlatLimpiar";
            this.btnFlatLimpiar.Normalcolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.OnHovercolor = System.Drawing.Color.Silver;
            this.btnFlatLimpiar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFlatLimpiar.selected = false;
            this.btnFlatLimpiar.Size = new System.Drawing.Size(162, 68);
            this.btnFlatLimpiar.TabIndex = 43;
            this.btnFlatLimpiar.Text = "LIMPIAR";
            this.btnFlatLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlatLimpiar.Textcolor = System.Drawing.Color.Black;
            this.btnFlatLimpiar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlatLimpiar.Click += new System.EventHandler(this.btnFlatLimpiar_Click);
            // 
            // Frm_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1282, 748);
            this.Controls.Add(this.btnFlatLimpiar);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.bntMostar);
            this.Controls.Add(this.btnGuardar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Empleado";
            this.Text = "Frm_Empleado";
            this.Load += new System.EventHandler(this.Frm_Empleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscarNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmboxIdProfesion;
        private System.Windows.Forms.ComboBox cmboxIdCargo;
        private System.Windows.Forms.Label LProfesion;
        private System.Windows.Forms.Label LCargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLugarN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuFlatButton btnGuardar;
        private System.Windows.Forms.DateTimePicker dtimeFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dTimeFechaIngreso;
        private System.Windows.Forms.CheckBox checkbtnMasculino;
        private System.Windows.Forms.CheckBox checkbtnFemenino;
        private Bunifu.Framework.UI.BunifuFlatButton bntMostar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscarNombre;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlatLimpiar;
    }
}