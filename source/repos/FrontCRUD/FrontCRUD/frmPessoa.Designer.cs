using System.Windows.Forms;
using Models;
using Controller;


namespace FrontCRUD
{
    public partial class frmPessoa : Form
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.btnSalvarPessoa = new System.Windows.Forms.Button();
            this.btnEditarPessoa = new System.Windows.Forms.Button();
            this.btnExcluirPessoa = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.btnConsultarPessoa = new System.Windows.Forms.Button();
            this.listConsulta = new System.Windows.Forms.ListBox();
            this.btnFixId = new System.Windows.Forms.Button();
            this.btnFixNome = new System.Windows.Forms.Button();
            this.btnFixCpf = new System.Windows.Forms.Button();
            this.btnFixEndereco = new System.Windows.Forms.Button();
            this.btnFixTelefone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(81, 21);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(64, 56);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(434, 56);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(46, 99);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(105, 14);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(105, 49);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 20);
            this.txtNome.TabIndex = 5;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(472, 49);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(209, 20);
            this.txtCpf.TabIndex = 6;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(105, 92);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(288, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Location = new System.Drawing.Point(444, 294);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPessoa.TabIndex = 8;
            this.btnSalvarPessoa.Text = "Salvar";
            this.btnSalvarPessoa.UseVisualStyleBackColor = true;
            this.btnSalvarPessoa.Click += new System.EventHandler(this.btnSalvarPessoa_Click);
            // 
            // btnEditarPessoa
            // 
            this.btnEditarPessoa.Location = new System.Drawing.Point(525, 294);
            this.btnEditarPessoa.Name = "btnEditarPessoa";
            this.btnEditarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPessoa.TabIndex = 9;
            this.btnEditarPessoa.Text = "Editar";
            this.btnEditarPessoa.UseVisualStyleBackColor = true;
            this.btnEditarPessoa.Click += new System.EventHandler(this.btnEditarPessoa_Click);
            // 
            // btnExcluirPessoa
            // 
            this.btnExcluirPessoa.Location = new System.Drawing.Point(606, 294);
            this.btnExcluirPessoa.Name = "btnExcluirPessoa";
            this.btnExcluirPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPessoa.TabIndex = 10;
            this.btnExcluirPessoa.Text = "Excluir";
            this.btnExcluirPessoa.UseVisualStyleBackColor = true;
            this.btnExcluirPessoa.Click += new System.EventHandler(this.btnExcluirPessoa_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(472, 92);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(209, 20);
            this.txtTelefone.TabIndex = 12;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(412, 99);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone";
            // 
            // btnConsultarPessoa
            // 
            this.btnConsultarPessoa.Location = new System.Drawing.Point(363, 294);
            this.btnConsultarPessoa.Name = "btnConsultarPessoa";
            this.btnConsultarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarPessoa.TabIndex = 13;
            this.btnConsultarPessoa.Text = "Consultar";
            this.btnConsultarPessoa.UseVisualStyleBackColor = true;
            // 
            // listConsulta
            // 
            this.listConsulta.FormattingEnabled = true;
            this.listConsulta.Location = new System.Drawing.Point(48, 153);
            this.listConsulta.Name = "listConsulta";
            this.listConsulta.Size = new System.Drawing.Size(633, 121);
            this.listConsulta.TabIndex = 14;
            // 
            // btnFixId
            // 
            this.btnFixId.Location = new System.Drawing.Point(48, 153);
            this.btnFixId.Name = "btnFixId";
            this.btnFixId.Size = new System.Drawing.Size(58, 23);
            this.btnFixId.TabIndex = 15;
            this.btnFixId.Text = "ID";
            this.btnFixId.UseVisualStyleBackColor = true;
            // 
            // btnFixNome
            // 
            this.btnFixNome.Location = new System.Drawing.Point(105, 153);
            this.btnFixNome.Name = "btnFixNome";
            this.btnFixNome.Size = new System.Drawing.Size(194, 23);
            this.btnFixNome.TabIndex = 16;
            this.btnFixNome.Text = "Nome";
            this.btnFixNome.UseVisualStyleBackColor = true;
            // 
            // btnFixCpf
            // 
            this.btnFixCpf.Location = new System.Drawing.Point(297, 153);
            this.btnFixCpf.Name = "btnFixCpf";
            this.btnFixCpf.Size = new System.Drawing.Size(104, 23);
            this.btnFixCpf.TabIndex = 17;
            this.btnFixCpf.Text = "CPF";
            this.btnFixCpf.UseVisualStyleBackColor = true;
            // 
            // btnFixEndereco
            // 
            this.btnFixEndereco.Location = new System.Drawing.Point(399, 153);
            this.btnFixEndereco.Name = "btnFixEndereco";
            this.btnFixEndereco.Size = new System.Drawing.Size(197, 23);
            this.btnFixEndereco.TabIndex = 18;
            this.btnFixEndereco.Text = "Endereço";
            this.btnFixEndereco.UseVisualStyleBackColor = true;
            // 
            // btnFixTelefone
            // 
            this.btnFixTelefone.Location = new System.Drawing.Point(595, 153);
            this.btnFixTelefone.Name = "btnFixTelefone";
            this.btnFixTelefone.Size = new System.Drawing.Size(86, 23);
            this.btnFixTelefone.TabIndex = 19;
            this.btnFixTelefone.Text = "Telefone";
            this.btnFixTelefone.UseVisualStyleBackColor = true;
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 338);
            this.Controls.Add(this.btnFixTelefone);
            this.Controls.Add(this.btnFixEndereco);
            this.Controls.Add(this.btnFixCpf);
            this.Controls.Add(this.btnFixNome);
            this.Controls.Add(this.btnFixId);
            this.Controls.Add(this.listConsulta);
            this.Controls.Add(this.btnConsultarPessoa);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.btnExcluirPessoa);
            this.Controls.Add(this.btnEditarPessoa);
            this.Controls.Add(this.btnSalvarPessoa);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblId);
            this.Name = "frmPessoa";
            this.Text = "PessoaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Button btnSalvarPessoa;
        private System.Windows.Forms.Button btnEditarPessoa;
        private System.Windows.Forms.Button btnExcluirPessoa;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnConsultarPessoa;
        private System.Windows.Forms.ListBox listConsulta;
        private System.Windows.Forms.Button btnFixId;
        private System.Windows.Forms.Button btnFixNome;
        private System.Windows.Forms.Button btnFixCpf;
        private System.Windows.Forms.Button btnFixEndereco;
        private System.Windows.Forms.Button btnFixTelefone;
    }
}