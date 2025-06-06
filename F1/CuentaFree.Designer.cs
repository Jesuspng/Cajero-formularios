namespace F1
{
    partial class CuentaFree
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
            this.BtnRetirar = new System.Windows.Forms.Button();
            this.BtnDepositar = new System.Windows.Forms.Button();
            this.TxtCantRetiro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCantDeposito = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSaldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnRetirar
            // 
            this.BtnRetirar.Location = new System.Drawing.Point(100, 315);
            this.BtnRetirar.Name = "BtnRetirar";
            this.BtnRetirar.Size = new System.Drawing.Size(140, 34);
            this.BtnRetirar.TabIndex = 25;
            this.BtnRetirar.Text = "Retirar";
            this.BtnRetirar.UseVisualStyleBackColor = true;
            this.BtnRetirar.Click += new System.EventHandler(this.BtnRetirar_Click_1);
            // 
            // BtnDepositar
            // 
            this.BtnDepositar.Location = new System.Drawing.Point(100, 230);
            this.BtnDepositar.Name = "BtnDepositar";
            this.BtnDepositar.Size = new System.Drawing.Size(140, 34);
            this.BtnDepositar.TabIndex = 24;
            this.BtnDepositar.Text = "Depositar";
            this.BtnDepositar.UseVisualStyleBackColor = true;
            this.BtnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click_1);
            // 
            // TxtCantRetiro
            // 
            this.TxtCantRetiro.Location = new System.Drawing.Point(179, 289);
            this.TxtCantRetiro.Name = "TxtCantRetiro";
            this.TxtCantRetiro.Size = new System.Drawing.Size(132, 20);
            this.TxtCantRetiro.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ingrese la cantidad a retirar";
            // 
            // TxtCantDeposito
            // 
            this.TxtCantDeposito.Location = new System.Drawing.Point(179, 204);
            this.TxtCantDeposito.Name = "TxtCantDeposito";
            this.TxtCantDeposito.Size = new System.Drawing.Size(132, 20);
            this.TxtCantDeposito.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ingrese la cantidad a depositar";
            // 
            // TxtNum
            // 
            this.TxtNum.Enabled = false;
            this.TxtNum.Location = new System.Drawing.Point(179, 126);
            this.TxtNum.Name = "TxtNum";
            this.TxtNum.Size = new System.Drawing.Size(132, 20);
            this.TxtNum.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Numero de ceunta";
            // 
            // TxtSaldo
            // 
            this.TxtSaldo.Enabled = false;
            this.TxtSaldo.Location = new System.Drawing.Point(179, 84);
            this.TxtSaldo.Name = "TxtSaldo";
            this.TxtSaldo.Size = new System.Drawing.Size(132, 20);
            this.TxtSaldo.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Saldo";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(100, 383);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(140, 34);
            this.BtnCerrar.TabIndex = 15;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Enabled = false;
            this.TxtNombre.Location = new System.Drawing.Point(179, 34);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(132, 20);
            this.TxtNombre.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de cuenta";
            // 
            // CuentaFree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.BtnRetirar);
            this.Controls.Add(this.BtnDepositar);
            this.Controls.Add(this.TxtCantRetiro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtCantDeposito);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Name = "CuentaFree";
            this.Text = "CuentaFree";
            this.Load += new System.EventHandler(this.CuentaFree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRetirar;
        private System.Windows.Forms.Button BtnDepositar;
        private System.Windows.Forms.TextBox TxtCantRetiro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCantDeposito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSaldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
    }
}