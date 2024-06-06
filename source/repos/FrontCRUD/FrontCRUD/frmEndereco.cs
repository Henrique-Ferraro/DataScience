using System;
using System.Windows.Forms;
using Models;
using Controller;
using System.Collections.Generic;

namespace FrontCRUD
{
    public partial class frmEndereco : Form
    {
        private readonly object enderecos;

        public frmEndereco()
        {
            InitializeComponent();
        }

       
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            mdlEndereco _mdlEndereco = new mdlEndereco();
            ctlEndereco _ctlEndereco = new Controller.ctlEndereco();

            try
            {
                _mdlEndereco.logradouro = txtLogradouro.Text;
                _mdlEndereco.numero = Convert.ToInt32(txtNumero.Text);
                _mdlEndereco.cep = Convert.ToInt32(txtCep.Text);
                _mdlEndereco.bairro = txtBairro.Text;
                _mdlEndereco.cidade = txtCidade.Text;
                _mdlEndereco.estado = txtEstado.Text;

                lblMensagem.Text = txtId.Text;

                bool retorno = _ctlEndereco.CadastrarEndereco(_mdlEndereco);

                if (retorno)
                {
                    txtLogradouro.Text = string.Empty;
                    txtNumero.Text = string.Empty;
                    txtCep.Text = string.Empty;
                    txtBairro.Text = string.Empty;
                    txtCidade.Text = string.Empty;
                    txtEstado.Text = string.Empty;
                    txtLogradouro.Focus();
                    MessageBox.Show("Dados do endereço incluidos com sucesso!");
                }
                else
                {
                    MessageBox.Show("Não foi possivel realizar a inclusão");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Variavel do tipo MessageBoxResult
            var msgExcluirEndereco = MessageBox.Show("Deseja realmente excluir o cadasatro de endereço", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgExcluirEndereco != DialogResult.No)
            {
                Close();
            }
        }

        private void btnConsultar_click(object sender, EventArgs e)
        {
            List<mdlEndereco> _mdlEndereco;
            if { txtId.Equals("")}
            {
                _mdlEndereco = ctlEndereco.consulta();

            }
            else
            {
                _mdlEndereco = ctlEndereco.consulta(txtId.Text);
            }
            mdlEndereco.Items.Clear();
            foireach(mdlEndereco e in enderecos)
            {
                mdlEndereco.Items.Add(e.ToString());
            }
            
        }

        private void foireach(mdlEndereco mdlEndereco, EventArgs e, object enderecos)
        {

            throw new NotImplementedException();
        }

        private void btnAlterar_click(object sender, EventArgs e)
        {
            mdlEndereco endereco = new mdlEndereco();
            endereco.id = Convert.ToInt32(txtId.Text);
            endereco.logradouro = txtLogradouro.Text;
            endereco.numero = Convert.ToInt32(txtNumero.Text);
            endereco.cep = Convert.ToInt32(txtCep.Text);
            endereco.bairro = txtBairro.Text;
            endereco.cidade = txtCidade.Text;
            endereco.estado = txtEstado.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void frmEndereco_Load(object sender, EventArgs e)
        {

        }
    }
}
