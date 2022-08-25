﻿namespace CapaPresentacion
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
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tpEliminarPro = new System.Windows.Forms.TabPage();
            this.cbProducto4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(248, 21);
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
            this.tcProductos.Location = new System.Drawing.Point(97, 61);
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
            this.btnLimpiar.Location = new System.Drawing.Point(343, 263);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(94, 38);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(176, 263);
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
            this.txtCantidad.Location = new System.Drawing.Point(190, 187);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(264, 29);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(190, 131);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(264, 29);
            this.txtValor.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescripcion.Location = new System.Drawing.Point(190, 82);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(264, 29);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigo.Location = new System.Drawing.Point(190, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(264, 29);
            this.txtCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(98, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 83);
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
            this.GridProductos.Location = new System.Drawing.Point(71, 120);
            this.GridProductos.Name = "GridProductos";
            this.GridProductos.RowTemplate.Height = 25;
            this.GridProductos.Size = new System.Drawing.Size(462, 197);
            this.GridProductos.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Teal;
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(232, 76);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(114, 38);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // cbProductos2
            // 
            this.cbProductos2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProductos2.FormattingEnabled = true;
            this.cbProductos2.Location = new System.Drawing.Point(154, 28);
            this.cbProductos2.Name = "cbProductos2";
            this.cbProductos2.Size = new System.Drawing.Size(342, 36);
            this.cbProductos2.TabIndex = 1;
            this.cbProductos2.SelectedIndexChanged += new System.EventHandler(this.cbProductos2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(51, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto:";
            // 
            // tpModificarPro
            // 
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
            // cbProducto
            // 
            this.cbProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(173, 60);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(332, 36);
            this.cbProducto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(36, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Producto:";
            // 
            // tpEliminarPro
            // 
            this.tpEliminarPro.Controls.Add(this.cbProducto4);
            this.tpEliminarPro.Controls.Add(this.label8);
            this.tpEliminarPro.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpEliminarPro.Location = new System.Drawing.Point(4, 24);
            this.tpEliminarPro.Name = "tpEliminarPro";
            this.tpEliminarPro.Padding = new System.Windows.Forms.Padding(3);
            this.tpEliminarPro.Size = new System.Drawing.Size(587, 349);
            this.tpEliminarPro.TabIndex = 3;
            this.tpEliminarPro.Text = "Eliminar producto";
            this.tpEliminarPro.UseVisualStyleBackColor = true;
            // 
            // cbProducto4
            // 
            this.cbProducto4.FormattingEnabled = true;
            this.cbProducto4.Location = new System.Drawing.Point(172, 50);
            this.cbProducto4.Name = "cbProducto4";
            this.cbProducto4.Size = new System.Drawing.Size(332, 45);
            this.cbProducto4.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 37);
            this.label8.TabIndex = 0;
            this.label8.Text = "Producto:";
            // 
            // FrProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcProductos);
            this.Controls.Add(this.label1);
            this.Name = "FrProductos";
            this.Text = "FrProductos";
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
        private DataGridView GridProductos;
        private Button btnConsultar;
        private Label label7;
        private ComboBox cbProducto;
        private ComboBox cbProducto4;
        private Label label8;
    }
}