namespace CapaPresentacion
{
    partial class FrFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GridFactura = new System.Windows.Forms.DataGridView();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCantiadad = new System.Windows.Forms.TextBox();
            this.tpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(267, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clientes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(328, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Productos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(36, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(306, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Factura:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(47, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Terminar Factura";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // GridFactura
            // 
            this.GridFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridFactura.Location = new System.Drawing.Point(47, 282);
            this.GridFactura.Name = "GridFactura";
            this.GridFactura.RowTemplate.Height = 25;
            this.GridFactura.Size = new System.Drawing.Size(606, 82);
            this.GridFactura.TabIndex = 8;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(141, 76);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(152, 29);
            this.txtNumero.TabIndex = 9;
            // 
            // txtCantiadad
            // 
            this.txtCantiadad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCantiadad.Location = new System.Drawing.Point(141, 236);
            this.txtCantiadad.Name = "txtCantiadad";
            this.txtCantiadad.Size = new System.Drawing.Size(164, 29);
            this.txtCantiadad.TabIndex = 12;
            // 
            // tpFecha
            // 
            this.tpFecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpFecha.Location = new System.Drawing.Point(405, 78);
            this.tpFecha.Name = "tpFecha";
            this.tpFecha.Size = new System.Drawing.Size(241, 29);
            this.tpFecha.TabIndex = 13;
            // 
            // cbClientes
            // 
            this.cbClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(141, 133);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(505, 29);
            this.cbClientes.TabIndex = 14;
            // 
            // cbProductos
            // 
            this.cbProductos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(141, 186);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(164, 29);
            this.cbProductos.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(432, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 29);
            this.textBox2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(432, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 32);
            this.button2.TabIndex = 17;
            this.button2.Text = "Agregar Producto";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FrFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 405);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.tpFecha);
            this.Controls.Add(this.txtCantiadad);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.GridFactura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrFactura";
            this.Text = "FrFactura";
            ((System.ComponentModel.ISupportInitialize)(this.GridFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private DataGridView GridFactura;
        private TextBox txtNumero;
        private TextBox txtCantiadad;
        private DateTimePicker tpFecha;
        private ComboBox cbClientes;
        private ComboBox cbProductos;
        private TextBox textBox2;
        private Button button2;
    }
}