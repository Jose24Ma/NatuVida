namespace CapaPresentacion
{
    partial class FrProductos
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
            this.tcProductos = new System.Windows.Forms.TabControl();
            this.tpIngresarPro = new System.Windows.Forms.TabPage();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tpConsultarPro = new System.Windows.Forms.TabPage();
            this.GridProductos = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbProductos2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpModificarPro = new System.Windows.Forms.TabPage();
            this.txtCantidadMod = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardarPro = new System.Windows.Forms.Button();
            this.txtValorMod = new System.Windows.Forms.TextBox();
            this.txtDescripcionMod = new System.Windows.Forms.TextBox();
            this.txtCodigoMod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConsultarProMod = new System.Windows.Forms.Button();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpEliminarPro = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbProducto4 = new System.Windows.Forms.ComboBox();
            this.tcProductos.SuspendLayout();
            this.tpIngresarPro.SuspendLayout();
            this.tpConsultarPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).BeginInit();
            this.tpModificarPro.SuspendLayout();
            this.tpEliminarPro.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de Productos";
            // 
            // tcProductos
            // 
            this.tcProductos.Controls.Add(this.tpIngresarPro);
            this.tcProductos.Controls.Add(this.tpConsultarPro);
            this.tcProductos.Controls.Add(this.tpModificarPro);
            this.tcProductos.Controls.Add(this.tpEliminarPro);
            this.tcProductos.Location = new System.Drawing.Point(93, 49);
            this.tcProductos.Name = "tcProductos";
            this.tcProductos.SelectedIndex = 0;
            this.tcProductos.Size = new System.Drawing.Size(595, 377);
            this.tcProductos.TabIndex = 1;
            // 
            // tpIngresarPro
            // 
            this.tpIngresarPro.Controls.Add(this.btnLimpiar);
            this.tpIngresarPro.Controls.Add(this.btnGuardar);
            this.tpIngresarPro.Controls.Add(this.txtCantidad);
            this.tpIngresarPro.Controls.Add(this.txtValor);
            this.tpIngresarPro.Controls.Add(this.txtDescripcion);
            this.tpIngresarPro.Controls.Add(this.txtCodigo);
            this.tpIngresarPro.Controls.Add(this.label5);
            this.tpIngresarPro.Controls.Add(this.label4);
            this.tpIngresarPro.Controls.Add(this.label3);
            this.tpIngresarPro.Controls.Add(this.label2);
            this.tpIngresarPro.Location = new System.Drawing.Point(4, 24);
            this.tpIngresarPro.Name = "tpIngresarPro";
            this.tpIngresarPro.Padding = new System.Windows.Forms.Padding(3);
            this.tpIngresarPro.Size = new System.Drawing.Size(587, 349);
            this.tpIngresarPro.TabIndex = 0;
            this.tpIngresarPro.Text = "Ingresar productos";
            this.tpIngresarPro.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(360, 260);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 38);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(190, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(94, 35);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidad.Location = new System.Drawing.Point(190, 201);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(264, 29);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(190, 146);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(264, 29);
            this.txtValor.TabIndex = 6;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(190, 86);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(264, 29);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(190, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(264, 29);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // tpConsultarPro
            // 
            this.tpConsultarPro.Controls.Add(this.GridProductos);
            this.tpConsultarPro.Controls.Add(this.btnConsultar);
            this.tpConsultarPro.Controls.Add(this.cbProductos2);
            this.tpConsultarPro.Controls.Add(this.label6);
            this.tpConsultarPro.Location = new System.Drawing.Point(4, 24);
            this.tpConsultarPro.Name = "tpConsultarPro";
            this.tpConsultarPro.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultarPro.Size = new System.Drawing.Size(587, 349);
            this.tpConsultarPro.TabIndex = 1;
            this.tpConsultarPro.Text = "Consultar producto";
            this.tpConsultarPro.UseVisualStyleBackColor = true;
            this.tpConsultarPro.Click += new System.EventHandler(this.tpConsultarPro_Click);
            // 
            // GridProductos
            // 
            this.GridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductos.Location = new System.Drawing.Point(23, 135);
            this.GridProductos.Name = "GridProductos";
            this.GridProductos.RowTemplate.Height = 25;
            this.GridProductos.Size = new System.Drawing.Size(539, 197);
            this.GridProductos.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Teal;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(233, 80);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 38);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbProductos2
            // 
            this.cbProductos2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProductos2.FormattingEnabled = true;
            this.cbProductos2.Location = new System.Drawing.Point(157, 37);
            this.cbProductos2.Name = "cbProductos2";
            this.cbProductos2.Size = new System.Drawing.Size(274, 29);
            this.cbProductos2.TabIndex = 1;
            this.cbProductos2.SelectedIndexChanged += new System.EventHandler(this.cbProductos2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(45, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto:";
            // 
            // tpModificarPro
            // 
            this.tpModificarPro.Controls.Add(this.txtCantidadMod);
            this.tpModificarPro.Controls.Add(this.label12);
            this.tpModificarPro.Controls.Add(this.btnGuardarPro);
            this.tpModificarPro.Controls.Add(this.txtValorMod);
            this.tpModificarPro.Controls.Add(this.txtDescripcionMod);
            this.tpModificarPro.Controls.Add(this.txtCodigoMod);
            this.tpModificarPro.Controls.Add(this.label11);
            this.tpModificarPro.Controls.Add(this.label10);
            this.tpModificarPro.Controls.Add(this.label9);
            this.tpModificarPro.Controls.Add(this.btnConsultarProMod);
            this.tpModificarPro.Controls.Add(this.cbProducto);
            this.tpModificarPro.Controls.Add(this.label7);
            this.tpModificarPro.Location = new System.Drawing.Point(4, 24);
            this.tpModificarPro.Name = "tpModificarPro";
            this.tpModificarPro.Padding = new System.Windows.Forms.Padding(3);
            this.tpModificarPro.Size = new System.Drawing.Size(587, 349);
            this.tpModificarPro.TabIndex = 2;
            this.tpModificarPro.Text = "Modificar producto";
            this.tpModificarPro.UseVisualStyleBackColor = true;
            // 
            // txtCantidadMod
            // 
            this.txtCantidadMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantidadMod.Location = new System.Drawing.Point(188, 265);
            this.txtCantidadMod.Name = "txtCantidadMod";
            this.txtCantidadMod.Size = new System.Drawing.Size(246, 29);
            this.txtCantidadMod.TabIndex = 12;
            this.txtCantidadMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadMod_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(87, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 28);
            this.label12.TabIndex = 11;
            this.label12.Text = "Cantidad:";
            // 
            // btnGuardarPro
            // 
            this.btnGuardarPro.BackColor = System.Drawing.Color.Teal;
            this.btnGuardarPro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardarPro.Location = new System.Drawing.Point(230, 311);
            this.btnGuardarPro.Name = "btnGuardarPro";
            this.btnGuardarPro.Size = new System.Drawing.Size(144, 32);
            this.btnGuardarPro.TabIndex = 10;
            this.btnGuardarPro.Text = "Guardar Cambios";
            this.btnGuardarPro.UseVisualStyleBackColor = false;
            this.btnGuardarPro.Click += new System.EventHandler(this.btnGuardarPro_Click);
            // 
            // txtValorMod
            // 
            this.txtValorMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValorMod.Location = new System.Drawing.Point(188, 215);
            this.txtValorMod.Name = "txtValorMod";
            this.txtValorMod.Size = new System.Drawing.Size(246, 29);
            this.txtValorMod.TabIndex = 9;
            this.txtValorMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMod_KeyPress);
            // 
            // txtDescripcionMod
            // 
            this.txtDescripcionMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcionMod.Location = new System.Drawing.Point(188, 162);
            this.txtDescripcionMod.Name = "txtDescripcionMod";
            this.txtDescripcionMod.Size = new System.Drawing.Size(246, 29);
            this.txtDescripcionMod.TabIndex = 8;
            this.txtDescripcionMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionMod_KeyPress);
            // 
            // txtCodigoMod
            // 
            this.txtCodigoMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoMod.Location = new System.Drawing.Point(188, 113);
            this.txtCodigoMod.Name = "txtCodigoMod";
            this.txtCodigoMod.Size = new System.Drawing.Size(246, 29);
            this.txtCodigoMod.TabIndex = 7;
            this.txtCodigoMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoMod_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(120, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 28);
            this.label11.TabIndex = 6;
            this.label11.Text = "Valor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(64, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "Descripcion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(101, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "Codigo:";
            // 
            // btnConsultarProMod
            // 
            this.btnConsultarProMod.BackColor = System.Drawing.Color.Teal;
            this.btnConsultarProMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarProMod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultarProMod.Location = new System.Drawing.Point(230, 65);
            this.btnConsultarProMod.Name = "btnConsultarProMod";
            this.btnConsultarProMod.Size = new System.Drawing.Size(144, 32);
            this.btnConsultarProMod.TabIndex = 3;
            this.btnConsultarProMod.Text = "Consultar";
            this.btnConsultarProMod.UseVisualStyleBackColor = false;
            this.btnConsultarProMod.Click += new System.EventHandler(this.btnConsultarProMod_Click);
            // 
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(163, 22);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(332, 29);
            this.cbProducto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(26, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Producto:";
            // 
            // tpEliminarPro
            // 
            this.tpEliminarPro.Controls.Add(this.btnEliminar);
            this.tpEliminarPro.Controls.Add(this.label8);
            this.tpEliminarPro.Controls.Add(this.cbProducto4);
            this.tpEliminarPro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpEliminarPro.Location = new System.Drawing.Point(4, 24);
            this.tpEliminarPro.Name = "tpEliminarPro";
            this.tpEliminarPro.Padding = new System.Windows.Forms.Padding(3);
            this.tpEliminarPro.Size = new System.Drawing.Size(587, 349);
            this.tpEliminarPro.TabIndex = 3;
            this.tpEliminarPro.Text = "Eliminar producto";
            this.tpEliminarPro.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Teal;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(244, 113);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 44);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto:";
            // 
            // cbProducto4
            // 
            this.cbProducto4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProducto4.FormattingEnabled = true;
            this.cbProducto4.Location = new System.Drawing.Point(157, 45);
            this.cbProducto4.Name = "cbProducto4";
            this.cbProducto4.Size = new System.Drawing.Size(369, 29);
            this.cbProducto4.TabIndex = 1;
            // 
            // FrProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcProductos);
            this.Controls.Add(this.label1);
            this.Name = "FrProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrProductos_Load);
            this.tcProductos.ResumeLayout(false);
            this.tpIngresarPro.ResumeLayout(false);
            this.tpIngresarPro.PerformLayout();
            this.tpConsultarPro.ResumeLayout(false);
            this.tpConsultarPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).EndInit();
            this.tpModificarPro.ResumeLayout(false);
            this.tpModificarPro.PerformLayout();
            this.tpEliminarPro.ResumeLayout(false);
            this.tpEliminarPro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tcProductos;
        private TabPage tpIngresarPro;
        private TabPage tpConsultarPro;
        private TabPage tpModificarPro;
        private TabPage tpEliminarPro;
        private Button btnLimpiar;
        private Button btnGuardar;
        private TextBox txtCantidad;
        private TextBox txtValor;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbProductos2;
        private Label label6;
        private Button btnConsultar;
        private Label label7;
        private ComboBox cbProducto;
        private ComboBox cbProducto4;
        private Label label8;
        private Button btnConsultarProMod;
        private DataGridView GridProductos;
        private Button btnGuardarPro;
        private TextBox txtValorMod;
        private TextBox txtDescripcionMod;
        private TextBox txtCodigoMod;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button btnEliminar;
        private TextBox txtCantidadMod;
        private Label label12;
    }
}