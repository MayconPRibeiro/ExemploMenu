﻿
namespace ExemploMenu
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(271, 46);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(91, 31);
            this.Cadastrar.TabIndex = 0;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Consultar
            // 
            this.Consultar.Location = new System.Drawing.Point(271, 83);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(91, 31);
            this.Consultar.TabIndex = 1;
            this.Consultar.Text = "Consultar";
            this.Consultar.UseVisualStyleBackColor = true;
            this.Consultar.Click += new System.EventHandler(this.Consultar_Click);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(271, 120);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(91, 31);
            this.Atualizar.TabIndex = 2;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Excluir
            // 
            this.Excluir.Location = new System.Drawing.Point(271, 157);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(91, 31);
            this.Excluir.TabIndex = 3;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Consultar);
            this.Controls.Add(this.Cadastrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Excluir;
    }
}

