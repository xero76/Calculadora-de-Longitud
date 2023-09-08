namespace Conversor_de_Unidades_de_Longitud
{
    partial class Form2
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cmborigen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.cmdconvertir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONVERTIR";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(125, 26);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(90, 20);
            this.txtvalor.TabIndex = 1;
            // 
            // cmborigen
            // 
            this.cmborigen.FormattingEnabled = true;
            this.cmborigen.Items.AddRange(new object[] {
            "Milimetros",
            "Centimetros",
            "Decimetros",
            "Metros",
            "Kilometros"});
            this.cmborigen.Location = new System.Drawing.Point(233, 24);
            this.cmborigen.Name = "cmborigen";
            this.cmborigen.Size = new System.Drawing.Size(121, 21);
            this.cmborigen.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Items.AddRange(new object[] {
            "Milimetros",
            "Centimetros",
            "Decimetros",
            "Metros",
            "Kilometros"});
            this.cmbdestino.Location = new System.Drawing.Point(382, 24);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(121, 21);
            this.cmbdestino.TabIndex = 4;
            this.cmbdestino.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmdconvertir
            // 
            this.cmdconvertir.Location = new System.Drawing.Point(52, 114);
            this.cmdconvertir.Name = "cmdconvertir";
            this.cmdconvertir.Size = new System.Drawing.Size(81, 23);
            this.cmdconvertir.TabIndex = 5;
            this.cmdconvertir.Text = "PROCESAR";
            this.cmdconvertir.UseVisualStyleBackColor = true;
            this.cmdconvertir.Click += new System.EventHandler(this.cmdconvertir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "RESULTADO";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(294, 113);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(91, 13);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "______________";
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(410, 166);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 8;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 201);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdconvertir);
            this.Controls.Add(this.cmbdestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmborigen);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox cmborigen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.Button cmdconvertir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button cmdSalir;
    }
}