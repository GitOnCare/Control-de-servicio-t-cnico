namespace Controlreparacionespj
{
    partial class FRMMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reparacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.regiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mecánicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvordenes = new System.Windows.Forms.DataGridView();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reparacionesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.mecánicosToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reparacionesToolStripMenuItem
            // 
            this.reparacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.añaToolStripMenuItem});
            this.reparacionesToolStripMenuItem.Name = "reparacionesToolStripMenuItem";
            this.reparacionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.reparacionesToolStripMenuItem.Text = "Reparaciones";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultaToolStripMenuItem.Text = "Registrar";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // añaToolStripMenuItem
            // 
            this.añaToolStripMenuItem.Name = "añaToolStripMenuItem";
            this.añaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.añaToolStripMenuItem.Text = "Consultar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem1,
            this.regiToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // consultaToolStripMenuItem1
            // 
            this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
            this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.consultaToolStripMenuItem1.Text = "Registrar";
            // 
            // regiToolStripMenuItem
            // 
            this.regiToolStripMenuItem.Name = "regiToolStripMenuItem";
            this.regiToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.regiToolStripMenuItem.Text = "Consultar";
            // 
            // mecánicosToolStripMenuItem
            // 
            this.mecánicosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.mecánicosToolStripMenuItem.Name = "mecánicosToolStripMenuItem";
            this.mecánicosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.mecánicosToolStripMenuItem.Text = "Mecánicos";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirModificarToolStripMenuItem,
            this.consultarToolStripMenuItem1});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // añadirModificarToolStripMenuItem
            // 
            this.añadirModificarToolStripMenuItem.Name = "añadirModificarToolStripMenuItem";
            this.añadirModificarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.añadirModificarToolStripMenuItem.Text = "Añadir / Modificar";
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            // 
            // dgvordenes
            // 
            this.dgvordenes.AllowUserToAddRows = false;
            this.dgvordenes.AllowUserToDeleteRows = false;
            this.dgvordenes.AllowUserToResizeRows = false;
            this.dgvordenes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvordenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvordenes.ColumnHeadersHeight = 25;
            this.dgvordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvordenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_factura,
            this.idtipo,
            this.Cliente,
            this.idestado,
            this.estado,
            this.Total});
            this.dgvordenes.Location = new System.Drawing.Point(22, 59);
            this.dgvordenes.Name = "dgvordenes";
            this.dgvordenes.ReadOnly = true;
            this.dgvordenes.RowHeadersVisible = false;
            this.dgvordenes.RowHeadersWidth = 10;
            this.dgvordenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvordenes.Size = new System.Drawing.Size(407, 348);
            this.dgvordenes.TabIndex = 28;
            // 
            // id_factura
            // 
            this.id_factura.HeaderText = "Num. Orden";
            this.id_factura.Name = "id_factura";
            this.id_factura.ReadOnly = true;
            // 
            // idtipo
            // 
            this.idtipo.HeaderText = "idtipo";
            this.idtipo.Name = "idtipo";
            this.idtipo.ReadOnly = true;
            this.idtipo.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Tipo";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
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
            // Total
            // 
            this.Total.HeaderText = "Sub total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FRMMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 684);
            this.Controls.Add(this.dgvordenes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRMMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvordenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reparacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem regiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mecánicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dgvordenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}