namespace ConversorF
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
            this.lblConversor = new System.Windows.Forms.Label();
            this.lbltipoConversor = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblRespuesta = new System.Windows.Forms.Label();
            this.cboA = new System.Windows.Forms.ComboBox();
            this.lblA = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboDe = new System.Windows.Forms.ComboBox();
            this.lblDe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConversor
            // 
            this.lblConversor.AutoSize = true;
            this.lblConversor.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversor.Location = new System.Drawing.Point(210, 32);
            this.lblConversor.Name = "lblConversor";
            this.lblConversor.Size = new System.Drawing.Size(271, 31);
            this.lblConversor.TabIndex = 0;
            this.lblConversor.Text = "Convertor de Monedas.";
            // 
            // lbltipoConversor
            // 
            this.lbltipoConversor.AutoSize = true;
            this.lbltipoConversor.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoConversor.ForeColor = System.Drawing.Color.Black;
            this.lbltipoConversor.Location = new System.Drawing.Point(12, 79);
            this.lbltipoConversor.Name = "lbltipoConversor";
            this.lbltipoConversor.Size = new System.Drawing.Size(235, 31);
            this.lbltipoConversor.TabIndex = 18;
            this.lbltipoConversor.Text = "Tipo de Convertidor";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(65, 129);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(105, 26);
            this.cboTipo.TabIndex = 17;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // lblRespuesta
            // 
            this.lblRespuesta.AutoSize = true;
            this.lblRespuesta.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuesta.ForeColor = System.Drawing.Color.Black;
            this.lblRespuesta.Location = new System.Drawing.Point(577, 262);
            this.lblRespuesta.Name = "lblRespuesta";
            this.lblRespuesta.Size = new System.Drawing.Size(26, 31);
            this.lblRespuesta.TabIndex = 16;
            this.lblRespuesta.Text = "?";
            // 
            // cboA
            // 
            this.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboA.FormattingEnabled = true;
            this.cboA.Location = new System.Drawing.Point(534, 110);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(110, 21);
            this.cboA.TabIndex = 15;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.ForeColor = System.Drawing.Color.Black;
            this.lblA.Location = new System.Drawing.Point(489, 100);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(39, 31);
            this.lblA.TabIndex = 14;
            this.lblA.Text = "A:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.BackColor = System.Drawing.Color.Transparent;
            this.btnConvertir.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.ForeColor = System.Drawing.Color.Black;
            this.btnConvertir.Location = new System.Drawing.Point(52, 202);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(130, 51);
            this.btnConvertir.TabIndex = 13;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = false;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(534, 220);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.Text = "1";
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboDe
            // 
            this.cboDe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDe.FormattingEnabled = true;
            this.cboDe.Location = new System.Drawing.Point(534, 172);
            this.cboDe.Name = "cboDe";
            this.cboDe.Size = new System.Drawing.Size(108, 21);
            this.cboDe.TabIndex = 11;
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDe.ForeColor = System.Drawing.Color.Black;
            this.lblDe.Location = new System.Drawing.Point(477, 162);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(51, 31);
            this.lblDe.TabIndex = 10;
            this.lblDe.Text = "De:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(702, 350);
            this.Controls.Add(this.lbltipoConversor);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.lblRespuesta);
            this.Controls.Add(this.cboA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cboDe);
            this.Controls.Add(this.lblDe);
            this.Controls.Add(this.lblConversor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConversor;
        private System.Windows.Forms.Label lbltipoConversor;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblRespuesta;
        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cboDe;
        private System.Windows.Forms.Label lblDe;
    }
}

