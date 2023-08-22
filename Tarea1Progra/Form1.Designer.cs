
namespace Tarea1Progra
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
            this.lblTipoConversor = new System.Windows.Forms.Label();
            this.lblDeConversor = new System.Windows.Forms.Label();
            this.lblAConversor = new System.Windows.Forms.Label();
            this.lblCantidadConversor = new System.Windows.Forms.Label();
            this.lblRespuestaConversor = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.CboTipoConversor = new System.Windows.Forms.ComboBox();
            this.CboDeConversor = new System.Windows.Forms.ComboBox();
            this.CboAconversor = new System.Windows.Forms.ComboBox();
            this.txtCantidadConversor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTipoConversor
            // 
            this.lblTipoConversor.AutoSize = true;
            this.lblTipoConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConversor.Location = new System.Drawing.Point(77, 47);
            this.lblTipoConversor.Name = "lblTipoConversor";
            this.lblTipoConversor.Size = new System.Drawing.Size(39, 19);
            this.lblTipoConversor.TabIndex = 0;
            this.lblTipoConversor.Text = "Tipo:";
            // 
            // lblDeConversor
            // 
            this.lblDeConversor.AutoSize = true;
            this.lblDeConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeConversor.Location = new System.Drawing.Point(77, 111);
            this.lblDeConversor.Name = "lblDeConversor";
            this.lblDeConversor.Size = new System.Drawing.Size(30, 19);
            this.lblDeConversor.TabIndex = 1;
            this.lblDeConversor.Text = "De:";
            // 
            // lblAConversor
            // 
            this.lblAConversor.AutoSize = true;
            this.lblAConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAConversor.Location = new System.Drawing.Point(77, 168);
            this.lblAConversor.Name = "lblAConversor";
            this.lblAConversor.Size = new System.Drawing.Size(23, 19);
            this.lblAConversor.TabIndex = 2;
            this.lblAConversor.Text = "A:";
            // 
            // lblCantidadConversor
            // 
            this.lblCantidadConversor.AutoSize = true;
            this.lblCantidadConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadConversor.Location = new System.Drawing.Point(77, 224);
            this.lblCantidadConversor.Name = "lblCantidadConversor";
            this.lblCantidadConversor.Size = new System.Drawing.Size(67, 19);
            this.lblCantidadConversor.TabIndex = 3;
            this.lblCantidadConversor.Text = "Cantidad:";
            // 
            // lblRespuestaConversor
            // 
            this.lblRespuestaConversor.AutoSize = true;
            this.lblRespuestaConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaConversor.Location = new System.Drawing.Point(77, 280);
            this.lblRespuestaConversor.Name = "lblRespuestaConversor";
            this.lblRespuestaConversor.Size = new System.Drawing.Size(85, 19);
            this.lblRespuestaConversor.TabIndex = 4;
            this.lblRespuestaConversor.Text = "Respuesta: ?";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(128, 314);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(190, 99);
            this.btnConvertir.TabIndex = 5;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // CboTipoConversor
            // 
            this.CboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipoConversor.FormattingEnabled = true;
            this.CboTipoConversor.Items.AddRange(new object[] {
            "Moneda",
            "Masa",
            "Volumen",
            "Longitud",
            "Almacenamiento",
            "Tiempo"});
            this.CboTipoConversor.Location = new System.Drawing.Point(129, 45);
            this.CboTipoConversor.Name = "CboTipoConversor";
            this.CboTipoConversor.Size = new System.Drawing.Size(190, 27);
            this.CboTipoConversor.TabIndex = 6;
            this.CboTipoConversor.TextChanged += new System.EventHandler(this.CboTipoConversor_TextChanged);
            // 
            // CboDeConversor
            // 
            this.CboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDeConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboDeConversor.FormattingEnabled = true;
            this.CboDeConversor.Location = new System.Drawing.Point(128, 111);
            this.CboDeConversor.Name = "CboDeConversor";
            this.CboDeConversor.Size = new System.Drawing.Size(190, 27);
            this.CboDeConversor.TabIndex = 7;
            // 
            // CboAconversor
            // 
            this.CboAconversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboAconversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboAconversor.FormattingEnabled = true;
            this.CboAconversor.Location = new System.Drawing.Point(128, 168);
            this.CboAconversor.Name = "CboAconversor";
            this.CboAconversor.Size = new System.Drawing.Size(190, 27);
            this.CboAconversor.TabIndex = 8;
            // 
            // txtCantidadConversor
            // 
            this.txtCantidadConversor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadConversor.Location = new System.Drawing.Point(168, 222);
            this.txtCantidadConversor.Name = "txtCantidadConversor";
            this.txtCantidadConversor.Size = new System.Drawing.Size(162, 26);
            this.txtCantidadConversor.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantidadConversor);
            this.Controls.Add(this.CboAconversor);
            this.Controls.Add(this.CboDeConversor);
            this.Controls.Add(this.CboTipoConversor);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.lblRespuestaConversor);
            this.Controls.Add(this.lblCantidadConversor);
            this.Controls.Add(this.lblAConversor);
            this.Controls.Add(this.lblDeConversor);
            this.Controls.Add(this.lblTipoConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoConversor;
        private System.Windows.Forms.Label lblDeConversor;
        private System.Windows.Forms.Label lblAConversor;
        private System.Windows.Forms.Label lblCantidadConversor;
        private System.Windows.Forms.Label lblRespuestaConversor;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.ComboBox CboTipoConversor;
        private System.Windows.Forms.ComboBox CboDeConversor;
        private System.Windows.Forms.ComboBox CboAconversor;
        private System.Windows.Forms.TextBox txtCantidadConversor;
    }
}

