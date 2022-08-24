namespace CapaPresentacion
{
    partial class FrClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiarCli = new System.Windows.Forms.Button();
            this.btnGuardarCli = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnConsultarCli = new System.Windows.Forms.Button();
            this.GridDatosCli = new System.Windows.Forms.DataGridView();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbClienteModificar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cbClienteEliminar = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosCli)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(288, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Cliente";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(84, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 361);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCorreo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnLimpiarCli);
            this.tabPage1.Controls.Add(this.btnGuardarCli);
            this.tabPage1.Controls.Add(this.txtTelefono);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.txtDocumento);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingresar cliente";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(217, 212);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(242, 27);
            this.txtCorreo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo Electronico:";
            // 
            // btnLimpiarCli
            // 
            this.btnLimpiarCli.Location = new System.Drawing.Point(370, 270);
            this.btnLimpiarCli.Name = "btnLimpiarCli";
            this.btnLimpiarCli.Size = new System.Drawing.Size(105, 41);
            this.btnLimpiarCli.TabIndex = 9;
            this.btnLimpiarCli.Text = "Limpiar";
            this.btnLimpiarCli.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCli
            // 
            this.btnGuardarCli.Location = new System.Drawing.Point(201, 270);
            this.btnGuardarCli.Name = "btnGuardarCli";
            this.btnGuardarCli.Size = new System.Drawing.Size(105, 41);
            this.btnGuardarCli.TabIndex = 8;
            this.btnGuardarCli.Text = "Guardar";
            this.btnGuardarCli.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefono.Location = new System.Drawing.Point(217, 169);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(242, 27);
            this.txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDireccion.Location = new System.Drawing.Point(217, 118);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(242, 27);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(217, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 27);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDocumento.Location = new System.Drawing.Point(217, 26);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(242, 27);
            this.txtDocumento.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(95, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nro Documento:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnConsultarCli);
            this.tabPage2.Controls.Add(this.GridDatosCli);
            this.tabPage2.Controls.Add(this.cbCliente);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar cliente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCli
            // 
            this.btnConsultarCli.BackColor = System.Drawing.Color.Teal;
            this.btnConsultarCli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarCli.Location = new System.Drawing.Point(282, 83);
            this.btnConsultarCli.Name = "btnConsultarCli";
            this.btnConsultarCli.Size = new System.Drawing.Size(101, 31);
            this.btnConsultarCli.TabIndex = 3;
            this.btnConsultarCli.Text = "Consular";
            this.btnConsultarCli.UseVisualStyleBackColor = false;
            // 
            // GridDatosCli
            // 
            this.GridDatosCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosCli.Location = new System.Drawing.Point(73, 120);
            this.GridDatosCli.Name = "GridDatosCli";
            this.GridDatosCli.RowTemplate.Height = 25;
            this.GridDatosCli.Size = new System.Drawing.Size(506, 207);
            this.GridDatosCli.TabIndex = 2;
            // 
            // cbCliente
            // 
            this.cbCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(200, 33);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(309, 29);
            this.cbCliente.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(73, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 46);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cliente:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.cbClienteModificar);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(646, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(503, 182);
            this.dataGridView1.TabIndex = 2;
            // 
            // cbClienteModificar
            // 
            this.cbClienteModificar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClienteModificar.FormattingEnabled = true;
            this.cbClienteModificar.Location = new System.Drawing.Point(200, 28);
            this.cbClienteModificar.Name = "cbClienteModificar";
            this.cbClienteModificar.Size = new System.Drawing.Size(319, 36);
            this.cbClienteModificar.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(72, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 46);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cliente:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbClienteEliminar);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(646, 333);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Eliminar cliente";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(273, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(69, 85);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(514, 201);
            this.dataGridView2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(69, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 46);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cliente:";
            // 
            // cbClienteEliminar
            // 
            this.cbClienteEliminar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClienteEliminar.FormattingEnabled = true;
            this.cbClienteEliminar.Location = new System.Drawing.Point(200, 22);
            this.cbClienteEliminar.Name = "cbClienteEliminar";
            this.cbClienteEliminar.Size = new System.Drawing.Size(333, 36);
            this.cbClienteEliminar.TabIndex = 4;
            // 
            // FrClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "FrClientes";
            this.Text = "Clientes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosCli)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button btnLimpiarCli;
        private Button btnGuardarCli;
        private TextBox txtCorreo;
        private Label label6;
        private Label label7;
        private Button btnConsultarCli;
        private DataGridView GridDatosCli;
        private ComboBox cbCliente;
        private Label label8;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox cbClienteModificar;
        private Label label9;
        private Button button2;
        private DataGridView dataGridView2;
        private ComboBox cbClienteEliminar;
    }
}