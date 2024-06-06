using System;
using System.Windows.Forms;
using Models;
using Controller;

namespace FrontCRUD
{
    public partial class Telefone : Form
    {
        public Telefone()
        {
            InitializeComponent();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Variavel do tipo MessageBoxResult
            var msgExcluirPessoa = MessageBox.Show("Deseja realmente excluir o cadasatro de endereço", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgExcluirPessoa != DialogResult.No)
            {
                Close();
            }
        }

        private void btnSalvarTelefone_Click(object sender, EventArgs e)
        {
            mdlTelefone _mdlTelefone = new mdlTelefone();
            ctlTelefone _ctlTelefone = new Controller.ctlTelefone();

            try
            {
                _mdlTelefone.numero = (int)Convert.ToInt64(txtNumero.Text);
                _mdlTelefone.ddd = (int)Convert.ToInt64(txtDdd.Text);
                _mdlTelefone.tipo = txtTipo.Text;

                lblMensagemSalvarTelefone.Text = txtId.Text;

                bool retorno = _ctlTelefone.CadastrarTelefone(_mdlTelefone);

                if (retorno)
                {
                    txtNumero.Text = string.Empty;
                    txtDdd.Text = string.Empty;
                    txtTipo.Text = string.Empty;
                    txtNumero.Focus();
                    MessageBox.Show("Dados do telefone incluidos com sucesso!");
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
        private void LblNome_Click(object sender, EventArgs e)
        {

        }
        private void TxtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblNome_Click(object sender, EventArgs e)
        {
        }
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }
        private void lblCpf_Click(object sender, EventArgs e)
        {

        }
        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
        private void lblId_Click(object sender, EventArgs e)
        {

        }
        private void btnFixNome_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        private void lblTelefone_Click(object sender, EventArgs e)
        {

        }
    }
}
