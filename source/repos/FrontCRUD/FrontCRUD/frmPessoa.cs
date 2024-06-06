using System;
using System.Windows.Forms;
using Models;
using Controller;

namespace FrontCRUD
{
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            MdlPessoa _mdlPessoa = new MdlPessoa();
            ctlPessoa _ctlPessoa = new ctlPessoa();

            try
            {
                _mdlPessoa.nome = txtNome.Text;
                _mdlPessoa.cpf = Convert.ToInt64(txtCpf.Text);
               // _mdlPessoa.endereco = txtEndereco.Text;
               // _mdlPessoa.telefone = txtTelefone.Text;

                bool retorno = _ctlPessoa.CadastrarPessoa(_mdlPessoa);

                if (retorno)
                {
                    txtNome.Text = string.Empty;
                    txtCpf.Text = string.Empty;
                    //txtEndereco.Text = string.Empty;
                    //txtTelefone.Text = string.Empty;
                    txtNome.Focus();
                    MessageBox.Show("Dados da pessoa incluido com sucesso!");
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

        private void btnEditarPessoa_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluirPessoa_Click(object sender, EventArgs e)
        {
            //Variavel do tipo MessageBoxResult
            var msgExcluirPessoa = MessageBox.Show("Deseja realmente excluir o cadasatro de endereço", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (msgExcluirPessoa != DialogResult.No)
            {
                Close();
            }
        }
    }
}
