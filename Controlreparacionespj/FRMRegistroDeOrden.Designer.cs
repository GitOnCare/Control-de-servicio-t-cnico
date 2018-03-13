namespace Controlreparacionespj
{
    partial class FRMRegistroDeOrden
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.btnañadir = new System.Windows.Forms.Button();
            this.cmbxtipo = new System.Windows.Forms.ComboBox();
            this.txtdetalles = new System.Windows.Forms.TextBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.lblcelular = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcod_cliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.cmbestadofac = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtfnofactura = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvordenes = new System.Windows.Forms.DataGridView();
            this.idordenrep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaexp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btninsertar = new System.Windows.Forms.Button();
            this.txtcod_usuario = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.txtorden);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtabono);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbmarca);
            this.groupBox2.Controls.Add(this.btnañadir);
            this.groupBox2.Controls.Add(this.cmbxtipo);
            this.groupBox2.Controls.Add(this.txtdetalles);
            this.groupBox2.Controls.Add(this.cmbestado);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(122, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 402);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del aparato";
            // 
            // btneliminar
            // 
            this.btneliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Location = new System.Drawing.Point(216, 353);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(115, 37);
            this.btneliminar.TabIndex = 30;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtorden
            // 
            this.txtorden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtorden.Enabled = false;
            this.txtorden.Location = new System.Drawing.Point(96, 29);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(100, 25);
            this.txtorden.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 37);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Orden No.";
            // 
            // txtabono
            // 
            this.txtabono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtabono.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtabono.Location = new System.Drawing.Point(96, 299);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(100, 25);
            this.txtabono.TabIndex = 26;
            this.txtabono.Leave += new System.EventHandler(this.txtabono_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Abono";
            // 
            // cmbmarca
            // 
            this.cmbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarca.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Location = new System.Drawing.Point(95, 99);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(144, 25);
            this.cmbmarca.TabIndex = 24;
            // 
            // btnañadir
            // 
            this.btnañadir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnañadir.Location = new System.Drawing.Point(73, 353);
            this.btnañadir.Name = "btnañadir";
            this.btnañadir.Size = new System.Drawing.Size(115, 37);
            this.btnañadir.TabIndex = 23;
            this.btnañadir.Text = "Añadir";
            this.btnañadir.UseVisualStyleBackColor = true;
            this.btnañadir.Click += new System.EventHandler(this.btnañadir_Click);
            // 
            // cmbxtipo
            // 
            this.cmbxtipo.DisplayMember = "descripcion";
            this.cmbxtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxtipo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbxtipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxtipo.FormattingEnabled = true;
            this.cmbxtipo.Location = new System.Drawing.Point(95, 61);
            this.cmbxtipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxtipo.Name = "cmbxtipo";
            this.cmbxtipo.Size = new System.Drawing.Size(144, 25);
            this.cmbxtipo.TabIndex = 4;
            this.cmbxtipo.TabStop = false;
            // 
            // txtdetalles
            // 
            this.txtdetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetalles.Location = new System.Drawing.Point(95, 181);
            this.txtdetalles.Margin = new System.Windows.Forms.Padding(4);
            this.txtdetalles.Multiline = true;
            this.txtdetalles.Name = "txtdetalles";
            this.txtdetalles.Size = new System.Drawing.Size(236, 94);
            this.txtdetalles.TabIndex = 8;
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(96, 136);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(121, 25);
            this.cmbestado.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Detalles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcelular);
            this.groupBox1.Controls.Add(this.lblcelular);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtcod_cliente);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.cmbestadofac);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtfnofactura);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(122, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 308);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la factura";
            // 
            // txtcelular
            // 
            this.txtcelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcelular.Location = new System.Drawing.Point(124, 137);
            this.txtcelular.Mask = "000-000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.PromptChar = ' ';
            this.txtcelular.Size = new System.Drawing.Size(100, 25);
            this.txtcelular.TabIndex = 28;
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelular.Location = new System.Drawing.Point(4, 145);
            this.lblcelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(49, 17);
            this.lblcelular.TabIndex = 27;
            this.lblcelular.Text = "Celular";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(216, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 24);
            this.button1.TabIndex = 26;
            this.button1.Text = "Buscar...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcod_cliente
            // 
            this.txtcod_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcod_cliente.Enabled = false;
            this.txtcod_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod_cliente.Location = new System.Drawing.Point(124, 70);
            this.txtcod_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcod_cliente.Name = "txtcod_cliente";
            this.txtcod_cliente.Size = new System.Drawing.Size(64, 23);
            this.txtcod_cliente.TabIndex = 25;
            this.txtcod_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 76);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Código de cliente";
            // 
            // txttelefono
            // 
            this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttelefono.Location = new System.Drawing.Point(124, 173);
            this.txttelefono.Mask = "000-000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.PromptChar = ' ';
            this.txttelefono.Size = new System.Drawing.Size(100, 25);
            this.txttelefono.TabIndex = 23;
            this.txttelefono.Enter += new System.EventHandler(this.txttelefono_Enter_1);
            // 
            // cmbestadofac
            // 
            this.cmbestadofac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestadofac.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestadofac.FormattingEnabled = true;
            this.cmbestadofac.Location = new System.Drawing.Point(127, 251);
            this.cmbestadofac.Name = "cmbestadofac";
            this.cmbestadofac.Size = new System.Drawing.Size(121, 25);
            this.cmbestadofac.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Estado de factura";
            // 
            // txtcliente
            // 
            this.txtcliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(124, 107);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(236, 23);
            this.txtcliente.TabIndex = 1;
            this.txtcliente.Enter += new System.EventHandler(this.txtcliente_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de factura";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha ";
            // 
            // txtfnofactura
            // 
            this.txtfnofactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfnofactura.Enabled = false;
            this.txtfnofactura.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfnofactura.Location = new System.Drawing.Point(124, 37);
            this.txtfnofactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtfnofactura.Name = "txtfnofactura";
            this.txtfnofactura.Size = new System.Drawing.Size(64, 25);
            this.txtfnofactura.TabIndex = 0;
            this.txtfnofactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfnofactura_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 210);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 25);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cliente";
            // 
            // dgvordenes
            // 
            this.dgvordenes.AllowUserToAddRows = false;
            this.dgvordenes.AllowUserToDeleteRows = false;
            this.dgvordenes.AllowUserToResizeRows = false;
            this.dgvordenes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvordenes.ColumnHeadersHeight = 25;
            this.dgvordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvordenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idordenrep,
            this.idtipo,
            this.tipo,
            this.idmarca,
            this.marca,
            this.idestado,
            this.estado,
            this.detalles,
            this.abono,
            this.fechaexp});
            this.dgvordenes.Location = new System.Drawing.Point(567, 118);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.ReadOnly = true;
            this.dgvordenes.RowHeadersVisible = false;
            this.dgvordenes.RowHeadersWidth = 10;
            this.dgvordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordenes.Size = new System.Drawing.Size(705, 348);
            this.dgvordenes.TabIndex = 27;
            // 
            // idordenrep
            // 
            this.idordenrep.HeaderText = "Num. Orden";
            this.idordenrep.Name = "idordenrep";
            this.idordenrep.ReadOnly = true;
            // 
            // idtipo
            // 
            this.idtipo.HeaderText = "idtipo";
            this.idtipo.Name = "idtipo";
            this.idtipo.ReadOnly = true;
            this.idtipo.Visible = false;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // idmarca
            // 
            this.idmarca.HeaderText = "idmarca";
            this.idmarca.Name = "idmarca";
            this.idmarca.ReadOnly = true;
            this.idmarca.Visible = false;
            // 
            // marca
            // 
            this.marca.HeaderText = "Marca";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // idestado
            // 
            this.idestado.HeaderText = "idestado";
            this.idestado.Name = "idestado";
            this.idestado.ReadOnly = true;
            this.idestado.Visible = false;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // detalles
            // 
            this.detalles.HeaderText = "Detalles";
            this.detalles.Name = "detalles";
            this.detalles.ReadOnly = true;
            // 
            // abono
            // 
            this.abono.HeaderText = "Abono ";
            this.abono.Name = "abono";
            this.abono.ReadOnly = true;
            // 
            // fechaexp
            // 
            this.fechaexp.HeaderText = "Fecha de expiración ";
            this.fechaexp.Name = "fechaexp";
            this.fechaexp.ReadOnly = true;
            // 
            // btninsertar
            // 
            this.btninsertar.Location = new System.Drawing.Point(567, 50);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(75, 37);
            this.btninsertar.TabIndex = 26;
            this.btninsertar.Text = "Guardar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // txtcod_usuario
            // 
            this.txtcod_usuario.Location = new System.Drawing.Point(13, 68);
            this.txtcod_usuario.Name = "txtcod_usuario";
            this.txtcod_usuario.Size = new System.Drawing.Size(100, 20);
            this.txtcod_usuario.TabIndex = 30;
            // 
            // FRMRegistroDeOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 749);
            this.Controls.Add(this.txtcod_usuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvordenes);
            this.Controls.Add(this.btninsertar);
            this.Name = "FRMRegistroDeOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Orden";
            this.Load += new System.EventHandler(this.RegistroDeOrden_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.Button btnañadir;
        private System.Windows.Forms.ComboBox cmbxtipo;
        private System.Windows.Forms.TextBox txtdetalles;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfnofactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvordenes;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.ComboBox cmbestadofac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.TextBox txtorden;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn idordenrep;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn abono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaexp;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtcod_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.TextBox txtcod_usuario;
    }
}