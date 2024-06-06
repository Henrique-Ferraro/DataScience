
using System;

namespace Views
{
    partial class Frm_Cadastro
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.lbl_Cpf = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Cpf = new System.Windows.Forms.TextBox();
            this.grp_Pessoal = new System.Windows.Forms.GroupBox();
            this.grp_Endereco = new System.Windows.Forms.GroupBox();
            this.txt_Estado = new System.Windows.Forms.TextBox();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.txt_Cidade = new System.Windows.Forms.TextBox();
            this.lbl_Cidade = new System.Windows.Forms.Label();
            this.txt_Bairro = new System.Windows.Forms.TextBox();
            this.lbl_Bairro = new System.Windows.Forms.Label();
            this.txt_Cep = new System.Windows.Forms.TextBox();
            this.lbl_Cep = new System.Windows.Forms.Label();
            this.txt_Logradouro = new System.Windows.Forms.TextBox();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.lbl_Logradouro = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.grp_Telefone = new System.Windows.Forms.GroupBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.txt_Ddd = new System.Windows.Forms.TextBox();
            this.txt_Tipo = new System.Windows.Forms.TextBox();
            this.lbl_Ddd = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lst_Consultas = new System.Windows.Forms.ListView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Nome = new System.Windows.Forms.Button();
            this.btn_Cpf = new System.Windows.Forms.Button();
            this.btn_Endereco = new System.Windows.Forms.Button();
            this.btn_Telefone = new System.Windows.Forms.Button();
            this.grp_Pessoal.SuspendLayout();
            this.grp_Endereco.SuspendLayout();
            this.grp_Telefone.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(8, 34);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 1;
            this.lbl_Nome.Text = "Nome";
            this.lbl_Nome.Click += new System.EventHandler(this.lbl_Nome_Click);
            // 
            // lbl_Cpf
            // 
            this.lbl_Cpf.AutoSize = true;
            this.lbl_Cpf.Location = new System.Drawing.Point(350, 34);
            this.lbl_Cpf.Name = "lbl_Cpf";
            this.lbl_Cpf.Size = new System.Drawing.Size(27, 13);
            this.lbl_Cpf.TabIndex = 2;
            this.lbl_Cpf.Text = "CPF";
            this.lbl_Cpf.Click += new System.EventHandler(this.lbl_Cpf_Click);
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(49, 27);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(272, 20);
            this.txt_Nome.TabIndex = 3;
            this.txt_Nome.TextChanged += new System.EventHandler(this.txt_Nome_TextChanged);
            // 
            // txt_Cpf
            // 
            this.txt_Cpf.Location = new System.Drawing.Point(383, 27);
            this.txt_Cpf.Name = "txt_Cpf";
            this.txt_Cpf.Size = new System.Drawing.Size(135, 20);
            this.txt_Cpf.TabIndex = 4;
            this.txt_Cpf.TextChanged += new System.EventHandler(this.txt_Cpf_TextChanged);
            // 
            // grp_Pessoal
            // 
            this.grp_Pessoal.Controls.Add(this.txt_Nome);
            this.grp_Pessoal.Controls.Add(this.txt_Cpf);
            this.grp_Pessoal.Controls.Add(this.lbl_Nome);
            this.grp_Pessoal.Controls.Add(this.lbl_Cpf);
            this.grp_Pessoal.Location = new System.Drawing.Point(12, 12);
            this.grp_Pessoal.Name = "grp_Pessoal";
            this.grp_Pessoal.Size = new System.Drawing.Size(605, 64);
            this.grp_Pessoal.TabIndex = 5;
            this.grp_Pessoal.TabStop = false;
            this.grp_Pessoal.Text = "Pessoal";
            this.grp_Pessoal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grp_Endereco
            // 
            this.grp_Endereco.Controls.Add(this.txt_Estado);
            this.grp_Endereco.Controls.Add(this.lbl_Estado);
            this.grp_Endereco.Controls.Add(this.txt_Cidade);
            this.grp_Endereco.Controls.Add(this.lbl_Cidade);
            this.grp_Endereco.Controls.Add(this.txt_Bairro);
            this.grp_Endereco.Controls.Add(this.lbl_Bairro);
            this.grp_Endereco.Controls.Add(this.txt_Cep);
            this.grp_Endereco.Controls.Add(this.lbl_Cep);
            this.grp_Endereco.Controls.Add(this.txt_Logradouro);
            this.grp_Endereco.Controls.Add(this.txt_Numero);
            this.grp_Endereco.Controls.Add(this.lbl_Logradouro);
            this.grp_Endereco.Controls.Add(this.lbl_Numero);
            this.grp_Endereco.Location = new System.Drawing.Point(12, 82);
            this.grp_Endereco.Name = "grp_Endereco";
            this.grp_Endereco.Size = new System.Drawing.Size(605, 122);
            this.grp_Endereco.TabIndex = 6;
            this.grp_Endereco.TabStop = false;
            this.grp_Endereco.Text = "Endereço";
            // 
            // txt_Estado
            // 
            this.txt_Estado.Location = new System.Drawing.Point(521, 75);
            this.txt_Estado.Name = "txt_Estado";
            this.txt_Estado.Size = new System.Drawing.Size(65, 20);
            this.txt_Estado.TabIndex = 12;
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.AutoSize = true;
            this.lbl_Estado.Location = new System.Drawing.Point(478, 82);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(40, 13);
            this.lbl_Estado.TabIndex = 11;
            this.lbl_Estado.Text = "Estado";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.Location = new System.Drawing.Point(259, 75);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(195, 20);
            this.txt_Cidade.TabIndex = 10;
            this.txt_Cidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lbl_Cidade
            // 
            this.lbl_Cidade.AutoSize = true;
            this.lbl_Cidade.Location = new System.Drawing.Point(216, 82);
            this.lbl_Cidade.Name = "lbl_Cidade";
            this.lbl_Cidade.Size = new System.Drawing.Size(40, 13);
            this.lbl_Cidade.TabIndex = 9;
            this.lbl_Cidade.Text = "Cidade";
            this.lbl_Cidade.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_Bairro
            // 
            this.txt_Bairro.Location = new System.Drawing.Point(48, 75);
            this.txt_Bairro.Name = "txt_Bairro";
            this.txt_Bairro.Size = new System.Drawing.Size(142, 20);
            this.txt_Bairro.TabIndex = 8;
            // 
            // lbl_Bairro
            // 
            this.lbl_Bairro.AutoSize = true;
            this.lbl_Bairro.Location = new System.Drawing.Point(8, 82);
            this.lbl_Bairro.Name = "lbl_Bairro";
            this.lbl_Bairro.Size = new System.Drawing.Size(34, 13);
            this.lbl_Bairro.TabIndex = 7;
            this.lbl_Bairro.Text = "Bairro";
            // 
            // txt_Cep
            // 
            this.txt_Cep.Location = new System.Drawing.Point(503, 30);
            this.txt_Cep.Name = "txt_Cep";
            this.txt_Cep.Size = new System.Drawing.Size(83, 20);
            this.txt_Cep.TabIndex = 6;
            this.txt_Cep.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_Cep
            // 
            this.lbl_Cep.AutoSize = true;
            this.lbl_Cep.Location = new System.Drawing.Point(474, 37);
            this.lbl_Cep.Name = "lbl_Cep";
            this.lbl_Cep.Size = new System.Drawing.Size(28, 13);
            this.lbl_Cep.TabIndex = 5;
            this.lbl_Cep.Text = "CEP";
            this.lbl_Cep.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Logradouro
            // 
            this.txt_Logradouro.Location = new System.Drawing.Point(70, 30);
            this.txt_Logradouro.Name = "txt_Logradouro";
            this.txt_Logradouro.Size = new System.Drawing.Size(272, 20);
            this.txt_Logradouro.TabIndex = 3;
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(404, 29);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(50, 20);
            this.txt_Numero.TabIndex = 4;
            // 
            // lbl_Logradouro
            // 
            this.lbl_Logradouro.AutoSize = true;
            this.lbl_Logradouro.Location = new System.Drawing.Point(8, 36);
            this.lbl_Logradouro.Name = "lbl_Logradouro";
            this.lbl_Logradouro.Size = new System.Drawing.Size(61, 13);
            this.lbl_Logradouro.TabIndex = 1;
            this.lbl_Logradouro.Text = "Logradouro";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(359, 36);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(44, 13);
            this.lbl_Numero.TabIndex = 2;
            this.lbl_Numero.Text = "Numero";
            // 
            // grp_Telefone
            // 
            this.grp_Telefone.Controls.Add(this.txt_Telefone);
            this.grp_Telefone.Controls.Add(this.lbl_Telefone);
            this.grp_Telefone.Controls.Add(this.txt_Ddd);
            this.grp_Telefone.Controls.Add(this.txt_Tipo);
            this.grp_Telefone.Controls.Add(this.lbl_Ddd);
            this.grp_Telefone.Controls.Add(this.lbl_Tipo);
            this.grp_Telefone.Location = new System.Drawing.Point(12, 210);
            this.grp_Telefone.Name = "grp_Telefone";
            this.grp_Telefone.Size = new System.Drawing.Size(605, 64);
            this.grp_Telefone.TabIndex = 6;
            this.grp_Telefone.TabStop = false;
            this.grp_Telefone.Text = "Telefone";
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(160, 27);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(114, 20);
            this.txt_Telefone.TabIndex = 6;
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(109, 34);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefone.TabIndex = 5;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // txt_Ddd
            // 
            this.txt_Ddd.Location = new System.Drawing.Point(49, 27);
            this.txt_Ddd.Name = "txt_Ddd";
            this.txt_Ddd.Size = new System.Drawing.Size(38, 20);
            this.txt_Ddd.TabIndex = 3;
            // 
            // txt_Tipo
            // 
            this.txt_Tipo.Location = new System.Drawing.Point(323, 27);
            this.txt_Tipo.Name = "txt_Tipo";
            this.txt_Tipo.Size = new System.Drawing.Size(131, 20);
            this.txt_Tipo.TabIndex = 4;
            // 
            // lbl_Ddd
            // 
            this.lbl_Ddd.AutoSize = true;
            this.lbl_Ddd.Location = new System.Drawing.Point(8, 34);
            this.lbl_Ddd.Name = "lbl_Ddd";
            this.lbl_Ddd.Size = new System.Drawing.Size(31, 13);
            this.lbl_Ddd.TabIndex = 1;
            this.lbl_Ddd.Text = "DDD";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Location = new System.Drawing.Point(290, 34);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(28, 13);
            this.lbl_Tipo.TabIndex = 2;
            this.lbl_Tipo.Text = "Tipo";
            // 
            // lst_Consultas
            // 
            this.lst_Consultas.HideSelection = false;
            this.lst_Consultas.Location = new System.Drawing.Point(15, 316);
            this.lst_Consultas.Name = "lst_Consultas";
            this.lst_Consultas.Size = new System.Drawing.Size(602, 243);
            this.lst_Consultas.TabIndex = 7;
            this.lst_Consultas.UseCompatibleStateImageBehavior = false;
            this.lst_Consultas.Click += new System.EventHandler(this.lst_Consultas_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Location = new System.Drawing.Point(533, 589);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 8;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(439, 589);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(75, 23);
            this.btn_Editar.TabIndex = 9;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Location = new System.Drawing.Point(340, 589);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 10;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Nome
            // 
            this.btn_Nome.Location = new System.Drawing.Point(15, 295);
            this.btn_Nome.Name = "btn_Nome";
            this.btn_Nome.Size = new System.Drawing.Size(117, 21);
            this.btn_Nome.TabIndex = 11;
            this.btn_Nome.Text = "Nome";
            this.btn_Nome.UseVisualStyleBackColor = true;
            // 
            // btn_Cpf
            // 
            this.btn_Cpf.Location = new System.Drawing.Point(130, 295);
            this.btn_Cpf.Name = "btn_Cpf";
            this.btn_Cpf.Size = new System.Drawing.Size(107, 21);
            this.btn_Cpf.TabIndex = 12;
            this.btn_Cpf.Text = "CPF";
            this.btn_Cpf.UseVisualStyleBackColor = true;
            // 
            // btn_Endereco
            // 
            this.btn_Endereco.Location = new System.Drawing.Point(231, 295);
            this.btn_Endereco.Name = "btn_Endereco";
            this.btn_Endereco.Size = new System.Drawing.Size(245, 21);
            this.btn_Endereco.TabIndex = 13;
            this.btn_Endereco.Text = "Endereco";
            this.btn_Endereco.UseVisualStyleBackColor = true;
            // 
            // btn_Telefone
            // 
            this.btn_Telefone.Location = new System.Drawing.Point(473, 295);
            this.btn_Telefone.Name = "btn_Telefone";
            this.btn_Telefone.Size = new System.Drawing.Size(145, 21);
            this.btn_Telefone.TabIndex = 14;
            this.btn_Telefone.Text = "Telefone";
            this.btn_Telefone.UseVisualStyleBackColor = true;
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 636);
            this.Controls.Add(this.btn_Telefone);
            this.Controls.Add(this.btn_Endereco);
            this.Controls.Add(this.btn_Cpf);
            this.Controls.Add(this.btn_Nome);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.lst_Consultas);
            this.Controls.Add(this.grp_Telefone);
            this.Controls.Add(this.grp_Endereco);
            this.Controls.Add(this.grp_Pessoal);
            this.Name = "Frm_Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Frm_Cadastro_Load);
            this.grp_Pessoal.ResumeLayout(false);
            this.grp_Pessoal.PerformLayout();
            this.grp_Endereco.ResumeLayout(false);
            this.grp_Endereco.PerformLayout();
            this.grp_Telefone.ResumeLayout(false);
            this.grp_Telefone.PerformLayout();
            this.ResumeLayout(false);

        }

        private void lst_Consultas_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.Label lbl_Cpf;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Cpf;
        private System.Windows.Forms.GroupBox grp_Pessoal;
        private System.Windows.Forms.GroupBox grp_Endereco;
        private System.Windows.Forms.TextBox txt_Cep;
        private System.Windows.Forms.Label lbl_Cep;
        private System.Windows.Forms.TextBox txt_Logradouro;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Label lbl_Logradouro;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_Cidade;
        private System.Windows.Forms.Label lbl_Cidade;
        private System.Windows.Forms.TextBox txt_Bairro;
        private System.Windows.Forms.Label lbl_Bairro;
        private System.Windows.Forms.TextBox txt_Estado;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.GroupBox grp_Telefone;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.TextBox txt_Ddd;
        private System.Windows.Forms.TextBox txt_Tipo;
        private System.Windows.Forms.Label lbl_Ddd;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.ListView lst_Consultas;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Nome;
        private System.Windows.Forms.Button btn_Cpf;
        private System.Windows.Forms.Button btn_Endereco;
        private System.Windows.Forms.Button btn_Telefone;
    }
}

