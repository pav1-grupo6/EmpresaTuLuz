namespace PAV1_TULUZ.ABMS.Proveedores
{
    partial class frmModificacion_Proveedores
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_RazonSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txtModificarProveedorTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(113, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Mail";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(159, 114);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 23);
            this.txt_Mail.TabIndex = 16;
            this.txt_Mail.TextChanged += new System.EventHandler(this.txt_Mail_TextChanged);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(159, 155);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 23);
            this.txt_Telefono.TabIndex = 15;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.txt_Telefono_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(85, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefono";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.Location = new System.Drawing.Point(159, 76);
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.Size = new System.Drawing.Size(100, 23);
            this.txt_RazonSocial.TabIndex = 13;
            this.txt_RazonSocial.TextChanged += new System.EventHandler(this.txt_RazonSocial_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Razon Social";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.Location = new System.Drawing.Point(179, 267);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 30);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(55, 267);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(120, 30);
            this.btn_Modificar.TabIndex = 10;
            this.btn_Modificar.Text = "Aceptar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txtModificarProveedorTitle
            // 
            this.txtModificarProveedorTitle.AutoSize = true;
            this.txtModificarProveedorTitle.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtModificarProveedorTitle.Location = new System.Drawing.Point(55, 23);
            this.txtModificarProveedorTitle.Name = "txtModificarProveedorTitle";
            this.txtModificarProveedorTitle.Size = new System.Drawing.Size(275, 37);
            this.txtModificarProveedorTitle.TabIndex = 9;
            this.txtModificarProveedorTitle.Text = "Modificar Proveedor";
            this.txtModificarProveedorTitle.Click += new System.EventHandler(this.txt_Mail_TextChanged);
            // 
            // frmModificacion_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_RazonSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.txtModificarProveedorTitle);
            this.Name = "frmModificacion_Proveedores";
            this.Text = "Editar Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox txt_Mail;
        private TextBox txt_Telefono;
        private Label label3;
        private TextBox txt_RazonSocial;
        private Label label2;
        private Button btn_Cancelar;
        private Button btn_Modificar;
        private Label txtModificarProveedorTitle;
    }
}