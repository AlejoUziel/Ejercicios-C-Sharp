namespace CalcularNomina
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxNombre = new System.Windows.Forms.TextBox();
            this.boxApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxDiasTrabajados = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPagoDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.boxResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(-37, -4);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(250, 12, 250, 12);
            this.label1.Size = new System.Drawing.Size(938, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULADORA DE NOMINA-TRABAJADOR ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres:";
            // 
            // boxNombre
            // 
            this.boxNombre.Location = new System.Drawing.Point(111, 95);
            this.boxNombre.Name = "boxNombre";
            this.boxNombre.Size = new System.Drawing.Size(239, 31);
            this.boxNombre.TabIndex = 2;
            // 
            // boxApellidos
            // 
            this.boxApellidos.Location = new System.Drawing.Point(533, 92);
            this.boxApellidos.Name = "boxApellidos";
            this.boxApellidos.Size = new System.Drawing.Size(239, 31);
            this.boxApellidos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos:";
            // 
            // boxDiasTrabajados
            // 
            this.boxDiasTrabajados.Location = new System.Drawing.Point(533, 183);
            this.boxDiasTrabajados.Name = "boxDiasTrabajados";
            this.boxDiasTrabajados.Size = new System.Drawing.Size(239, 31);
            this.boxDiasTrabajados.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dias trabajados:";
            // 
            // boxPagoDia
            // 
            this.boxPagoDia.Location = new System.Drawing.Point(111, 186);
            this.boxPagoDia.Name = "boxPagoDia";
            this.boxPagoDia.Size = new System.Drawing.Size(239, 31);
            this.boxPagoDia.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pago al dia:";
            // 
            // boxResultado
            // 
            this.boxResultado.Location = new System.Drawing.Point(111, 299);
            this.boxResultado.Multiline = true;
            this.boxResultado.Name = "boxResultado";
            this.boxResultado.Size = new System.Drawing.Size(661, 46);
            this.boxResultado.TabIndex = 10;
            this.boxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxResultado.TextChanged += new System.EventHandler(this.boxResultado_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(111, 392);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(226, 33);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(533, 392);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(226, 33);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pago Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.boxResultado);
            this.Controls.Add(this.boxDiasTrabajados);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxPagoDia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boxApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox boxNombre;
        private TextBox boxApellidos;
        private Label label3;
        private TextBox boxDiasTrabajados;
        private Label label4;
        private TextBox boxPagoDia;
        private Label label5;
        private TextBox boxResultado;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label6;
    }
}