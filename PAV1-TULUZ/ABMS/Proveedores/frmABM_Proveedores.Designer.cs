namespace PAV1_TULUZ.ABMS.Proveedores
{
    partial class frmABM_Proveedores
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LimpiarCampos = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.Columna_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk_BoxActivos = new System.Windows.Forms.CheckBox();
            this.chk_BoxTodos = new System.Windows.Forms.CheckBox();
            this.txt_RazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LimpiarCampos);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.grillaProveedores);
            this.groupBox1.Controls.Add(this.chk_BoxActivos);
            this.groupBox1.Controls.Add(this.chk_BoxTodos);
            this.groupBox1.Controls.Add(this.txt_RazonSocial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(599, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Proveedores";
            // 
            // btn_LimpiarCampos
            // 
            this.btn_LimpiarCampos.Location = new System.Drawing.Point(341, 172);
            this.btn_LimpiarCampos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_LimpiarCampos.Name = "btn_LimpiarCampos";
            this.btn_LimpiarCampos.Size = new System.Drawing.Size(94, 39);
            this.btn_LimpiarCampos.TabIndex = 6;
            this.btn_LimpiarCampos.Text = "Limpiar";
            this.btn_LimpiarCampos.UseVisualStyleBackColor = true;
            this.btn_LimpiarCampos.Click += new System.EventHandler(this.btn_LimpiarCampos_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(473, 172);
            this.btn_Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(94, 39);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.AllowUserToAddRows = false;
            this.grillaProveedores.AllowUserToDeleteRows = false;
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columna_id,
            this.razonSocial,
            this.mail,
            this.telefono,
            this.activo});
            this.grillaProveedores.Location = new System.Drawing.Point(14, 219);
            this.grillaProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.ReadOnly = true;
            this.grillaProveedores.RowHeadersWidth = 51;
            this.grillaProveedores.RowTemplate.Height = 25;
            this.grillaProveedores.Size = new System.Drawing.Size(553, 301);
            this.grillaProveedores.TabIndex = 4;
            // 
            // Columna_id
            // 
            this.Columna_id.DataPropertyName = "proveedor_id";
            this.Columna_id.HeaderText = "id";
            this.Columna_id.MinimumWidth = 6;
            this.Columna_id.Name = "Columna_id";
            this.Columna_id.ReadOnly = true;
            this.Columna_id.Width = 40;
            // 
            // razonSocial
            // 
            this.razonSocial.DataPropertyName = "razon_social";
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 125;
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "Mail";
            this.mail.MinimumWidth = 6;
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            this.mail.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "proveedor_activo";
            this.activo.HeaderText = "Activo";
            this.activo.MinimumWidth = 6;
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 125;
            // 
            // chk_BoxActivos
            // 
            this.chk_BoxActivos.AutoSize = true;
            this.chk_BoxActivos.Location = new System.Drawing.Point(136, 125);
            this.chk_BoxActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_BoxActivos.Name = "chk_BoxActivos";
            this.chk_BoxActivos.Size = new System.Drawing.Size(104, 32);
            this.chk_BoxActivos.TabIndex = 3;
            this.chk_BoxActivos.Text = "Activos";
            this.chk_BoxActivos.UseVisualStyleBackColor = true;
            // 
            // chk_BoxTodos
            // 
            this.chk_BoxTodos.AutoSize = true;
            this.chk_BoxTodos.Location = new System.Drawing.Point(136, 84);
            this.chk_BoxTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_BoxTodos.Name = "chk_BoxTodos";
            this.chk_BoxTodos.Size = new System.Drawing.Size(89, 32);
            this.chk_BoxTodos.TabIndex = 2;
            this.chk_BoxTodos.Text = "Todos";
            this.chk_BoxTodos.UseVisualStyleBackColor = true;
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.Location = new System.Drawing.Point(136, 37);
            this.txt_RazonSocial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.Size = new System.Drawing.Size(141, 34);
            this.txt_RazonSocial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Razon Social";
            // 
            // id
            // 
            this.id.DataPropertyName = "proveedor_id";
            this.id.HeaderText = "id proveedor";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "proveedor_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id proveedor";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "id proveedor";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "id proveedor";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "proveedor_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Agregar.Location = new System.Drawing.Point(14, 577);
            this.btn_Agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(114, 40);
            this.btn_Agregar.TabIndex = 1;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.Location = new System.Drawing.Point(135, 577);
            this.btn_Editar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(114, 40);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Borrar.Location = new System.Drawing.Point(256, 577);
            this.btn_Borrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(114, 40);
            this.btn_Borrar.TabIndex = 3;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.Location = new System.Drawing.Point(498, 577);
            this.btn_Volver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(114, 40);
            this.btn_Volver.TabIndex = 4;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // frmABM_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 633);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_Borrar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmABM_Proveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROVEEDORES";
            this.Load += new System.EventHandler(this.frmABM_Proveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private CheckBox chk_BoxActivos;
        private CheckBox chk_BoxTodos;
        private TextBox txt_RazonSocial;
        private Button btn_Buscar;
        private DataGridView grillaProveedores;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Button btn_LimpiarCampos;
        private Button btn_Agregar;
        private Button btn_Editar;
        private Button btn_Borrar;
        private Button btn_Volver;
        private DataGridViewTextBoxColumn Columna_id;
        private DataGridViewTextBoxColumn razonSocial;
        private DataGridViewTextBoxColumn mail;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn activo;
    }
}