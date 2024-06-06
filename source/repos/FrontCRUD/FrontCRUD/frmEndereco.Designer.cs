
namespace FrontCRUD
{
    partial class frmEndereco
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
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnConsultarEndereco = new System.Windows.Forms.Button();
            this.btnExcluirEndereco = new System.Windows.Forms.Button();
            this.btnEditarEndereco = new System.Windows.Forms.Button();
            this.btnSalvarEndereco = new System.Windows.Forms.Button();
            this.btnFixEstado = new System.Windows.Forms.Button();
            this.btnFixBairro = new System.Windows.Forms.Button();
            this.btnFixNumero = new System.Windows.Forms.Button();
            this.btnFixLogradouro = new System.Windows.Forms.Button();
            this.btnFixId = new System.Windows.Forms.Button();
            this.listConsulta = new System.Windows.Forms.ListBox();
            this.btnFixCep = new System.Windows.Forms.Button();
            this.btnFixCidade = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(69, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(26, 94);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(61, 13);
            this.lblLogradouro.TabIndex = 1;
            this.lblLogradouro.Text = "Logradouro";
            this.lblLogradouro.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(93, 90);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(329, 20);
            this.txtLogradouro.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 48);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(428, 90);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número";
            this.lblNumero.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(478, 87);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(71, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(621, 87);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(114, 20);
            this.txtCep.TabIndex = 7;
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(587, 90);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(28, 13);
            this.lblCep.TabIndex = 6;
            this.lblCep.Text = "CEP";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(53, 133);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(34, 13);
            this.lblBairro.TabIndex = 8;
            this.lblBairro.Text = "Bairro";
            this.lblBairro.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(93, 126);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(161, 20);
            this.txtBairro.TabIndex = 9;
            this.txtBairro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(269, 133);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(40, 13);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(315, 126);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(234, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(575, 133);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(621, 126);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(114, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // btnConsultarEndereco
            // 
            this.btnConsultarEndereco.Location = new System.Drawing.Point(429, 328);
            this.btnConsultarEndereco.Name = "btnConsultarEndereco";
            this.btnConsultarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarEndereco.TabIndex = 17;
            this.btnConsultarEndereco.Text = "Consultar";
            this.btnConsultarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnExcluirEndereco
            // 
            this.btnExcluirEndereco.Location = new System.Drawing.Point(672, 328);
            this.btnExcluirEndereco.Name = "btnExcluirEndereco";
            this.btnExcluirEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirEndereco.TabIndex = 16;
            this.btnExcluirEndereco.Text = "Excluir";
            this.btnExcluirEndereco.UseVisualStyleBackColor = true;
            this.btnExcluirEndereco.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditarEndereco
            // 
            this.btnEditarEndereco.Location = new System.Drawing.Point(591, 328);
            this.btnEditarEndereco.Name = "btnEditarEndereco";
            this.btnEditarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnEditarEndereco.TabIndex = 15;
            this.btnEditarEndereco.Text = "Editar";
            this.btnEditarEndereco.UseVisualStyleBackColor = true;
            // 
            // btnSalvarEndereco
            // 
            this.btnSalvarEndereco.Location = new System.Drawing.Point(510, 328);
            this.btnSalvarEndereco.Name = "btnSalvarEndereco";
            this.btnSalvarEndereco.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarEndereco.TabIndex = 14;
            this.btnSalvarEndereco.Text = "Salvar";
            this.btnSalvarEndereco.UseVisualStyleBackColor = true;
            this.btnSalvarEndereco.Click += new System.EventHandler(this.btnSalvarEndereco_Click);
            // 
            // btnFixEstado
            // 
            this.btnFixEstado.Location = new System.Drawing.Point(635, 172);
            this.btnFixEstado.Name = "btnFixEstado";
            this.btnFixEstado.Size = new System.Drawing.Size(112, 23);
            this.btnFixEstado.TabIndex = 25;
            this.btnFixEstado.Text = "Estado";
            this.btnFixEstado.UseVisualStyleBackColor = true;
            // 
            // btnFixBairro
            // 
            this.btnFixBairro.Location = new System.Drawing.Point(439, 172);
            this.btnFixBairro.Name = "btnFixBairro";
            this.btnFixBairro.Size = new System.Drawing.Size(96, 23);
            this.btnFixBairro.TabIndex = 24;
            this.btnFixBairro.Text = "Bairro";
            this.btnFixBairro.UseVisualStyleBackColor = true;
            // 
            // btnFixNumero
            // 
            this.btnFixNumero.Location = new System.Drawing.Point(313, 172);
            this.btnFixNumero.Name = "btnFixNumero";
            this.btnFixNumero.Size = new System.Drawing.Size(68, 23);
            this.btnFixNumero.TabIndex = 23;
            this.btnFixNumero.Text = "Numero";
            this.btnFixNumero.UseVisualStyleBackColor = true;
            // 
            // btnFixLogradouro
            // 
            this.btnFixLogradouro.Location = new System.Drawing.Point(87, 172);
            this.btnFixLogradouro.Name = "btnFixLogradouro";
            this.btnFixLogradouro.Size = new System.Drawing.Size(231, 23);
            this.btnFixLogradouro.TabIndex = 22;
            this.btnFixLogradouro.Text = "Logradouro";
            this.btnFixLogradouro.UseVisualStyleBackColor = true;
            // 
            // btnFixId
            // 
            this.btnFixId.Location = new System.Drawing.Point(29, 172);
            this.btnFixId.Name = "btnFixId";
            this.btnFixId.Size = new System.Drawing.Size(58, 23);
            this.btnFixId.TabIndex = 21;
            this.btnFixId.Text = "ID";
            this.btnFixId.UseVisualStyleBackColor = true;
            // 
            // listConsulta
            // 
            this.listConsulta.FormattingEnabled = true;
            this.listConsulta.Location = new System.Drawing.Point(29, 172);
            this.listConsulta.Name = "listConsulta";
            this.listConsulta.Size = new System.Drawing.Size(718, 121);
            this.listConsulta.TabIndex = 20;
            // 
            // btnFixCep
            // 
            this.btnFixCep.Location = new System.Drawing.Point(377, 172);
            this.btnFixCep.Name = "btnFixCep";
            this.btnFixCep.Size = new System.Drawing.Size(64, 23);
            this.btnFixCep.TabIndex = 26;
            this.btnFixCep.Text = "CEP";
            this.btnFixCep.UseVisualStyleBackColor = true;
            // 
            // btnFixCidade
            // 
            this.btnFixCidade.Location = new System.Drawing.Point(533, 172);
            this.btnFixCidade.Name = "btnFixCidade";
            this.btnFixCidade.Size = new System.Drawing.Size(105, 23);
            this.btnFixCidade.TabIndex = 27;
            this.btnFixCidade.Text = "Cidade";
            this.btnFixCidade.UseVisualStyleBackColor = true;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(127, 328);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(149, 13);
            this.lblMensagem.TabIndex = 28;
            this.lblMensagem.Text = "Endereço salvo com sucesso!";
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // frmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnFixCidade);
            this.Controls.Add(this.btnFixCep);
            this.Controls.Add(this.btnFixEstado);
            this.Controls.Add(this.btnFixBairro);
            this.Controls.Add(this.btnFixNumero);
            this.Controls.Add(this.btnFixLogradouro);
            this.Controls.Add(this.btnFixId);
            this.Controls.Add(this.listConsulta);
            this.Controls.Add(this.btnConsultarEndereco);
            this.Controls.Add(this.btnExcluirEndereco);
            this.Controls.Add(this.btnEditarEndereco);
            this.Controls.Add(this.btnSalvarEndereco);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.lblLogradouro);
            this.Controls.Add(this.lblId);
            this.Name = "frmEndereco";
            this.Text = "Endereco";
            this.Load += new System.EventHandler(this.frmEndereco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnConsultarEndereco;
        private System.Windows.Forms.Button btnExcluirEndereco;
        private System.Windows.Forms.Button btnEditarEndereco;
        private System.Windows.Forms.Button btnSalvarEndereco;
        private System.Windows.Forms.Button btnFixEstado;
        private System.Windows.Forms.Button btnFixBairro;
        private System.Windows.Forms.Button btnFixNumero;
        private System.Windows.Forms.Button btnFixLogradouro;
        private System.Windows.Forms.Button btnFixId;
        private System.Windows.Forms.ListBox listConsulta;
        private System.Windows.Forms.Button btnFixCep;
        private System.Windows.Forms.Button btnFixCidade;
        private System.Windows.Forms.Label lblMensagem;
    }
}

