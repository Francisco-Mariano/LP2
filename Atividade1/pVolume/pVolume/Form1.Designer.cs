
namespace PVolume
{
    partial class btnFechar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnFechar));
            this.lblRaio = new System.Windows.Forms.Label();
            this.llblAltura = new System.Windows.Forms.Label();
            this.txtRaio = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCVCilindro = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCVCdro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRaio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRaio.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblRaio.Location = new System.Drawing.Point(62, 29);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(85, 18);
            this.lblRaio.TabIndex = 0;
            this.lblRaio.Text = "Informe Raio:";
            // 
            // llblAltura
            // 
            this.llblAltura.AutoSize = true;
            this.llblAltura.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llblAltura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.llblAltura.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.llblAltura.Location = new System.Drawing.Point(53, 86);
            this.llblAltura.Name = "llblAltura";
            this.llblAltura.Size = new System.Drawing.Size(92, 18);
            this.llblAltura.TabIndex = 1;
            this.llblAltura.Text = "Informe Altura:";
            // 
            // txtRaio
            // 
            this.txtRaio.Location = new System.Drawing.Point(12, 48);
            this.txtRaio.Name = "txtRaio";
            this.txtRaio.Size = new System.Drawing.Size(137, 22);
            this.txtRaio.TabIndex = 2;
            this.txtRaio.TextChanged += new System.EventHandler(this.txtRaio_TextChanged);
            this.txtRaio.Validating += new System.ComponentModel.CancelEventHandler(this.txtRaio_Validating);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(12, 106);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(135, 22);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            this.txtAltura.Validating += new System.ComponentModel.CancelEventHandler(this.txtAltura_Validating);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(504, 106);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 25);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtCVCilindro
            // 
            this.txtCVCilindro.Enabled = false;
            this.txtCVCilindro.Location = new System.Drawing.Point(312, 47);
            this.txtCVCilindro.Name = "txtCVCilindro";
            this.txtCVCilindro.ReadOnly = true;
            this.txtCVCilindro.Size = new System.Drawing.Size(267, 22);
            this.txtCVCilindro.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(312, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 25);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCVCdro
            // 
            this.lblCVCdro.AutoSize = true;
            this.lblCVCdro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCVCdro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCVCdro.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCVCdro.Location = new System.Drawing.Point(393, 29);
            this.lblCVCdro.Name = "lblCVCdro";
            this.lblCVCdro.Size = new System.Drawing.Size(186, 18);
            this.lblCVCdro.TabIndex = 8;
            this.lblCVCdro.Text = "Cálculo do Volume do Cilindro:";
            // 
            // btnFechar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lblCVCdro);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCVCilindro);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtRaio);
            this.Controls.Add(this.llblAltura);
            this.Controls.Add(this.lblRaio);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "btnFechar";
            this.Text = "Cálculo do Volume do Cilindro";
            this.TransparencyKey = System.Drawing.Color.SkyBlue;
            this.Load += new System.EventHandler(this.Fechar);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label llblAltura;
        private System.Windows.Forms.TextBox txtRaio;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtCVCilindro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCVCdro;
    }
}

