
namespace Practica230921
{
    partial class Form1
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
            this.txtDireccion = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreEdi = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbRentados = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAgg = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.AutoSize = true;
            this.txtDireccion.Location = new System.Drawing.Point(62, 145);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(67, 17);
            this.txtDireccion.TabIndex = 0;
            this.txtDireccion.Text = "Direccion";
            // 
            // txtCantidad
            // 
            this.txtCantidad.AutoSize = true;
            this.txtCantidad.Location = new System.Drawing.Point(22, 196);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(183, 17);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "Cantidad de departamentos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departamentos rentados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del edificio";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(966, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese los datos del edificio";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombreEdi
            // 
            this.tbNombreEdi.Location = new System.Drawing.Point(211, 103);
            this.tbNombreEdi.Name = "tbNombreEdi";
            this.tbNombreEdi.Size = new System.Drawing.Size(167, 22);
            this.tbNombreEdi.TabIndex = 5;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(211, 142);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(167, 22);
            this.tbDireccion.TabIndex = 6;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(211, 191);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(167, 22);
            this.tbCantidad.TabIndex = 7;
            // 
            // tbRentados
            // 
            this.tbRentados.Location = new System.Drawing.Point(211, 242);
            this.tbRentados.Name = "tbRentados";
            this.tbRentados.Size = new System.Drawing.Size(167, 22);
            this.tbRentados.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(25, 298);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(926, 276);
            this.listBox1.TabIndex = 9;
            // 
            // btnAgg
            // 
            this.btnAgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgg.Location = new System.Drawing.Point(424, 196);
            this.btnAgg.Name = "btnAgg";
            this.btnAgg.Size = new System.Drawing.Size(112, 42);
            this.btnAgg.TabIndex = 10;
            this.btnAgg.Text = "Ingresar";
            this.btnAgg.UseVisualStyleBackColor = true;
            this.btnAgg.Click += new System.EventHandler(this.btnAgg_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(864, 604);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 40);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha actual: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(672, 90);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 17);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "lblFecha";
            // 
            // lblReloj
            // 
            this.lblReloj.Location = new System.Drawing.Point(853, 90);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(153, 41);
            this.lblReloj.TabIndex = 14;
            this.lblReloj.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Hora actual:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 678);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbRentados);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombreEdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDireccion);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDireccion;
        private System.Windows.Forms.Label txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreEdi;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbRentados;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAgg;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblReloj;
        private System.Windows.Forms.Label label5;
    }
}

