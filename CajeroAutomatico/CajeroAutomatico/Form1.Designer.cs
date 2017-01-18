namespace CajeroAutomatico
{
    partial class frm_Cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cajero));
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txt_Cincuenta = new System.Windows.Forms.TextBox();
            this.txt_Diez = new System.Windows.Forms.TextBox();
            this.txt_Peso = new System.Windows.Forms.TextBox();
            this.txt_Cien = new System.Windows.Forms.TextBox();
            this.txt_Docientos = new System.Windows.Forms.TextBox();
            this.txt_Mil = new System.Windows.Forms.TextBox();
            this.btn_Corregir = new System.Windows.Forms.Button();
            this.btn_Retirar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.pcb_Mil = new System.Windows.Forms.PictureBox();
            this.pcb_Docientos = new System.Windows.Forms.PictureBox();
            this.pcb_Cien = new System.Windows.Forms.PictureBox();
            this.pcb_Cincuenta = new System.Windows.Forms.PictureBox();
            this.pcb_Diez = new System.Windows.Forms.PictureBox();
            this.pcb_Peso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Mil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Docientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Cien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Cincuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Diez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Peso)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(138, 9);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(161, 23);
            this.lbl_Cantidad.TabIndex = 0;
            this.lbl_Cantidad.Text = "Dinero a retirar:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(127, 35);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(189, 20);
            this.txt_Cantidad.TabIndex = 1;
            // 
            // txt_Cincuenta
            // 
            this.txt_Cincuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cincuenta.Location = new System.Drawing.Point(156, 285);
            this.txt_Cincuenta.Name = "txt_Cincuenta";
            this.txt_Cincuenta.Size = new System.Drawing.Size(64, 38);
            this.txt_Cincuenta.TabIndex = 2;
            // 
            // txt_Diez
            // 
            this.txt_Diez.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Diez.Location = new System.Drawing.Point(156, 212);
            this.txt_Diez.Name = "txt_Diez";
            this.txt_Diez.Size = new System.Drawing.Size(64, 38);
            this.txt_Diez.TabIndex = 3;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Peso.Location = new System.Drawing.Point(156, 142);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(64, 38);
            this.txt_Peso.TabIndex = 4;
            // 
            // txt_Cien
            // 
            this.txt_Cien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cien.Location = new System.Drawing.Point(232, 142);
            this.txt_Cien.Name = "txt_Cien";
            this.txt_Cien.Size = new System.Drawing.Size(64, 38);
            this.txt_Cien.TabIndex = 5;
            // 
            // txt_Docientos
            // 
            this.txt_Docientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Docientos.Location = new System.Drawing.Point(232, 212);
            this.txt_Docientos.Name = "txt_Docientos";
            this.txt_Docientos.Size = new System.Drawing.Size(64, 38);
            this.txt_Docientos.TabIndex = 6;
            // 
            // txt_Mil
            // 
            this.txt_Mil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mil.Location = new System.Drawing.Point(232, 285);
            this.txt_Mil.Name = "txt_Mil";
            this.txt_Mil.Size = new System.Drawing.Size(64, 38);
            this.txt_Mil.TabIndex = 7;
            this.txt_Mil.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // btn_Corregir
            // 
            this.btn_Corregir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Corregir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Corregir.Image")));
            this.btn_Corregir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Corregir.Location = new System.Drawing.Point(164, 61);
            this.btn_Corregir.Name = "btn_Corregir";
            this.btn_Corregir.Size = new System.Drawing.Size(120, 43);
            this.btn_Corregir.TabIndex = 11;
            this.btn_Corregir.Text = "Corregir     ";
            this.btn_Corregir.UseVisualStyleBackColor = true;
            this.btn_Corregir.Click += new System.EventHandler(this.btn_Corregir_Click);
            // 
            // btn_Retirar
            // 
            this.btn_Retirar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Retirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retirar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Retirar.Image")));
            this.btn_Retirar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Retirar.Location = new System.Drawing.Point(37, 61);
            this.btn_Retirar.Name = "btn_Retirar";
            this.btn_Retirar.Size = new System.Drawing.Size(120, 43);
            this.btn_Retirar.TabIndex = 12;
            this.btn_Retirar.Text = "       Retirar";
            this.btn_Retirar.UseVisualStyleBackColor = false;
            this.btn_Retirar.Click += new System.EventHandler(this.btn_Retirar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.Image")));
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancelar.Location = new System.Drawing.Point(290, 61);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 43);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar     ";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // pcb_Mil
            // 
            this.pcb_Mil.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Mil.Image")));
            this.pcb_Mil.Location = new System.Drawing.Point(300, 276);
            this.pcb_Mil.Name = "pcb_Mil";
            this.pcb_Mil.Size = new System.Drawing.Size(138, 58);
            this.pcb_Mil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Mil.TabIndex = 14;
            this.pcb_Mil.TabStop = false;
            // 
            // pcb_Docientos
            // 
            this.pcb_Docientos.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Docientos.Image")));
            this.pcb_Docientos.Location = new System.Drawing.Point(302, 201);
            this.pcb_Docientos.Name = "pcb_Docientos";
            this.pcb_Docientos.Size = new System.Drawing.Size(138, 58);
            this.pcb_Docientos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Docientos.TabIndex = 15;
            this.pcb_Docientos.TabStop = false;
            // 
            // pcb_Cien
            // 
            this.pcb_Cien.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Cien.Image")));
            this.pcb_Cien.Location = new System.Drawing.Point(302, 133);
            this.pcb_Cien.Name = "pcb_Cien";
            this.pcb_Cien.Size = new System.Drawing.Size(138, 58);
            this.pcb_Cien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Cien.TabIndex = 16;
            this.pcb_Cien.TabStop = false;
            // 
            // pcb_Cincuenta
            // 
            this.pcb_Cincuenta.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Cincuenta.Image")));
            this.pcb_Cincuenta.Location = new System.Drawing.Point(12, 276);
            this.pcb_Cincuenta.Name = "pcb_Cincuenta";
            this.pcb_Cincuenta.Size = new System.Drawing.Size(138, 61);
            this.pcb_Cincuenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Cincuenta.TabIndex = 17;
            this.pcb_Cincuenta.TabStop = false;
            // 
            // pcb_Diez
            // 
            this.pcb_Diez.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Diez.Image")));
            this.pcb_Diez.Location = new System.Drawing.Point(53, 198);
            this.pcb_Diez.Name = "pcb_Diez";
            this.pcb_Diez.Size = new System.Drawing.Size(63, 61);
            this.pcb_Diez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Diez.TabIndex = 18;
            this.pcb_Diez.TabStop = false;
            // 
            // pcb_Peso
            // 
            this.pcb_Peso.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Peso.Image")));
            this.pcb_Peso.Location = new System.Drawing.Point(53, 130);
            this.pcb_Peso.Name = "pcb_Peso";
            this.pcb_Peso.Size = new System.Drawing.Size(63, 61);
            this.pcb_Peso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Peso.TabIndex = 19;
            this.pcb_Peso.TabStop = false;
            // 
            // frm_Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 427);
            this.Controls.Add(this.pcb_Peso);
            this.Controls.Add(this.pcb_Diez);
            this.Controls.Add(this.pcb_Cincuenta);
            this.Controls.Add(this.pcb_Cien);
            this.Controls.Add(this.pcb_Docientos);
            this.Controls.Add(this.pcb_Mil);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Retirar);
            this.Controls.Add(this.btn_Corregir);
            this.Controls.Add(this.txt_Mil);
            this.Controls.Add(this.txt_Docientos);
            this.Controls.Add(this.txt_Cien);
            this.Controls.Add(this.txt_Peso);
            this.Controls.Add(this.txt_Diez);
            this.Controls.Add(this.txt_Cincuenta);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Cajero";
            this.Text = "Cajero Automatico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Mil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Docientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Cien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Cincuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Diez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Peso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.TextBox txt_Cincuenta;
        private System.Windows.Forms.TextBox txt_Diez;
        private System.Windows.Forms.TextBox txt_Peso;
        private System.Windows.Forms.TextBox txt_Cien;
        private System.Windows.Forms.TextBox txt_Docientos;
        private System.Windows.Forms.TextBox txt_Mil;
        private System.Windows.Forms.Button btn_Corregir;
        private System.Windows.Forms.Button btn_Retirar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.PictureBox pcb_Mil;
        private System.Windows.Forms.PictureBox pcb_Docientos;
        private System.Windows.Forms.PictureBox pcb_Cien;
        private System.Windows.Forms.PictureBox pcb_Cincuenta;
        private System.Windows.Forms.PictureBox pcb_Diez;
        private System.Windows.Forms.PictureBox pcb_Peso;
    }
}

