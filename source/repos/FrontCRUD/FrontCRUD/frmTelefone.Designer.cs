
namespace FrontCRUD
{
    partial class Telefone
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
            this.btnConsultarTelefone = new System.Windows.Forms.Button();
            this.btnExcluirTelefone = new System.Windows.Forms.Button();
            this.btnEditarTelefone = new System.Windows.Forms.Button();
            this.btnSalvarTelefone = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDdd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.listConsulta = new System.Windows.Forms.ListBox();
            this.btnFixId = new System.Windows.Forms.Button();
            this.btnFixDdd = new System.Windows.Forms.Button();
            this.btnFixNumero = new System.Windows.Forms.Button();
            this.btnFixTipo = new System.Windows.Forms.Button();
            this.lblMensagemSalvarTelefone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsultarTelefone
            // 
            this.btnConsultarTelefone.Location = new System.Drawing.Point(173, 275);
            this.btnConsultarTelefone.Name = "btnConsultarTelefone";
            this.btnConsultarTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarTelefone.TabIndex = 27;
            this.btnConsultarTelefone.Text = "Consultar";
            this.btnConsultarTelefone.UseVisualStyleBackColor = true;
            this.btnConsultarTelefone.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnExcluirTelefone
            // 
            this.btnExcluirTelefone.Location = new System.Drawing.Point(416, 275);
            this.btnExcluirTelefone.Name = "btnExcluirTelefone";
            this.btnExcluirTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirTelefone.TabIndex = 24;
            this.btnExcluirTelefone.Text = "Excluir";
            this.btnExcluirTelefone.UseVisualStyleBackColor = true;
            this.btnExcluirTelefone.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditarTelefone
            // 
            this.btnEditarTelefone.Location = new System.Drawing.Point(335, 275);
            this.btnEditarTelefone.Name = "btnEditarTelefone";
            this.btnEditarTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTelefone.TabIndex = 23;
            this.btnEditarTelefone.Text = "Editar";
            this.btnEditarTelefone.UseVisualStyleBackColor = true;
            this.btnEditarTelefone.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvarTelefone
            // 
            this.btnSalvarTelefone.Location = new System.Drawing.Point(254, 275);
            this.btnSalvarTelefone.Name = "btnSalvarTelefone";
            this.btnSalvarTelefone.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarTelefone.TabIndex = 22;
            this.btnSalvarTelefone.Text = "Salvar";
            this.btnSalvarTelefone.UseVisualStyleBackColor = true;
            this.btnSalvarTelefone.Click += new System.EventHandler(this.btnSalvarTelefone_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(399, 47);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(91, 20);
            this.txtTipo.TabIndex = 21;
            this.txtTipo.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(196, 47);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(147, 20);
            this.txtNumero.TabIndex = 20;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // txtDdd
            // 
            this.txtDdd.Location = new System.Drawing.Point(68, 47);
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(58, 20);
            this.txtDdd.TabIndex = 19;
            this.txtDdd.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(42, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(58, 20);
            this.txtId.TabIndex = 18;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(358, 54);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo";
            this.lblTipo.Click += new System.EventHandler(this.lblEndereco_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(140, 54);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 16;
            this.lblNumero.Text = "Numero";
            this.lblNumero.Click += new System.EventHandler(this.lblCpf_Click);
            // 
            // lblDdd
            // 
            this.lblDdd.AutoSize = true;
            this.lblDdd.Location = new System.Drawing.Point(16, 54);
            this.lblDdd.Name = "lblDdd";
            this.lblDdd.Size = new System.Drawing.Size(31, 13);
            this.lblDdd.TabIndex = 15;
            this.lblDdd.Text = "DDD";
            this.lblDdd.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "ID";
            this.lblId.Click += new System.EventHandler(this.lblId_Click);
            // 
            // listConsulta
            // 
            this.listConsulta.FormattingEnabled = true;
            this.listConsulta.Location = new System.Drawing.Point(19, 106);
            this.listConsulta.Name = "listConsulta";
            this.listConsulta.Size = new System.Drawing.Size(472, 121);
            this.listConsulta.TabIndex = 28;
            // 
            // btnFixId
            // 
            this.btnFixId.Location = new System.Drawing.Point(19, 106);
            this.btnFixId.Name = "btnFixId";
            this.btnFixId.Size = new System.Drawing.Size(58, 23);
            this.btnFixId.TabIndex = 29;
            this.btnFixId.Text = "ID";
            this.btnFixId.UseVisualStyleBackColor = true;
            // 
            // btnFixDdd
            // 
            this.btnFixDdd.Location = new System.Drawing.Point(76, 106);
            this.btnFixDdd.Name = "btnFixDdd";
            this.btnFixDdd.Size = new System.Drawing.Size(64, 23);
            this.btnFixDdd.TabIndex = 30;
            this.btnFixDdd.Text = "DDD";
            this.btnFixDdd.UseVisualStyleBackColor = true;
            this.btnFixDdd.Click += new System.EventHandler(this.btnFixNome_Click);
            // 
            // btnFixNumero
            // 
            this.btnFixNumero.Location = new System.Drawing.Point(138, 106);
            this.btnFixNumero.Name = "btnFixNumero";
            this.btnFixNumero.Size = new System.Drawing.Size(248, 23);
            this.btnFixNumero.TabIndex = 31;
            this.btnFixNumero.Text = "Numero";
            this.btnFixNumero.UseVisualStyleBackColor = true;
            // 
            // btnFixTipo
            // 
            this.btnFixTipo.Location = new System.Drawing.Point(378, 106);
            this.btnFixTipo.Name = "btnFixTipo";
            this.btnFixTipo.Size = new System.Drawing.Size(112, 23);
            this.btnFixTipo.TabIndex = 32;
            this.btnFixTipo.Text = "Tipo";
            this.btnFixTipo.UseVisualStyleBackColor = true;
            // 
            // lblMensagemSalvarTelefone
            // 
            this.lblMensagemSalvarTelefone.AutoSize = true;
            this.lblMensagemSalvarTelefone.Location = new System.Drawing.Point(27, 251);
            this.lblMensagemSalvarTelefone.Name = "lblMensagemSalvarTelefone";
            this.lblMensagemSalvarTelefone.Size = new System.Drawing.Size(147, 13);
            this.lblMensagemSalvarTelefone.TabIndex = 33;
            this.lblMensagemSalvarTelefone.Text = "Telefone salvo com Sucesso!";
            this.lblMensagemSalvarTelefone.Click += new System.EventHandler(this.label1_Click);
            // 
            // Telefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 322);
            this.Controls.Add(this.lblMensagemSalvarTelefone);
            this.Controls.Add(this.btnFixTipo);
            this.Controls.Add(this.btnFixNumero);
            this.Controls.Add(this.btnFixDdd);
            this.Controls.Add(this.btnFixId);
            this.Controls.Add(this.listConsulta);
            this.Controls.Add(this.btnConsultarTelefone);
            this.Controls.Add(this.btnExcluirTelefone);
            this.Controls.Add(this.btnEditarTelefone);
            this.Controls.Add(this.btnSalvarTelefone);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblDdd);
            this.Controls.Add(this.lblId);
            this.Name = "Telefone";
            this.Text = "TelefoneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarTelefone;
        private System.Windows.Forms.Button btnExcluirTelefone;
        private System.Windows.Forms.Button btnEditarTelefone;
        private System.Windows.Forms.Button btnSalvarTelefone;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDdd;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDdd;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ListBox listConsulta;
        private System.Windows.Forms.Button btnFixId;
        private System.Windows.Forms.Button btnFixDdd;
        private System.Windows.Forms.Button btnFixNumero;
        private System.Windows.Forms.Button btnFixTipo;
        private System.Windows.Forms.Label lblMensagemSalvarTelefone;
    }
}