using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1
{
    partial class Menu
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
            this.BtnEmpresa = new System.Windows.Forms.Button();
            this.BrnFree = new System.Windows.Forms.Button();
            this.BtnJr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEmpresa
            // 
            this.BtnEmpresa.Location = new System.Drawing.Point(33, 293);
            this.BtnEmpresa.Name = "BtnEmpresa";
            this.BtnEmpresa.Size = new System.Drawing.Size(219, 50);
            this.BtnEmpresa.TabIndex = 5;
            this.BtnEmpresa.Text = "Cuenta de empresa";
            this.BtnEmpresa.UseVisualStyleBackColor = true;
            this.BtnEmpresa.Click += new System.EventHandler(this.BtnEmpresa_Click);
            // 
            // BrnFree
            // 
            this.BrnFree.Location = new System.Drawing.Point(33, 179);
            this.BrnFree.Name = "BrnFree";
            this.BrnFree.Size = new System.Drawing.Size(219, 50);
            this.BrnFree.TabIndex = 4;
            this.BrnFree.Text = "Cuenta free";
            this.BrnFree.UseVisualStyleBackColor = true;
            this.BrnFree.Click += new System.EventHandler(this.BrnFree_Click);
            // 
            // BtnJr
            // 
            this.BtnJr.Location = new System.Drawing.Point(33, 73);
            this.BtnJr.Name = "BtnJr";
            this.BtnJr.Size = new System.Drawing.Size(219, 50);
            this.BtnJr.TabIndex = 3;
            this.BtnJr.Text = "Cuenta Jr";
            this.BtnJr.UseVisualStyleBackColor = true;
            this.BtnJr.Click += new System.EventHandler(this.BtnJr_Click_1);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(284, 417);
            this.Controls.Add(this.BtnEmpresa);
            this.Controls.Add(this.BrnFree);
            this.Controls.Add(this.BtnJr);
            this.Name = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;

        // 🔧 Campos que faltaban
        private System.Windows.Forms.Button BtnEmpresa;
        private System.Windows.Forms.Button BrnFree;
        private System.Windows.Forms.Button BtnJr;
    }
}

