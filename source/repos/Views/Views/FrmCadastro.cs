using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class Frm_Cadastro : Form
    {
        int CadastroPessoa = 0;
        int CadastroEndereco = 0;
        int CadastroTelefone = 0;

        public object Tbc_Aplicacoes { get; private set; }

        public Frm_Cadastro()
        {
            InitializeComponent();
            txt_Nome.Text = "Nome";
            txt_Cpf.Text = "CPF";
            txt_Logradouro.Text = "Logradouro";
            txt_Numero.Text = "Numero";
            txt_Cep.Text = "CEP";
            txt_Bairro.Text = "Bairro";
            txt_Cidade.Text = "Cidade";
            txt_Estado.Text = "Estado";
            txt_Ddd.Text = "DDD";
            txt_Telefone.Text = "Telefone";
            txt_Tipo.Text = "Tipo";

        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Nome_Click(object sender, EventArgs e)
        {

        }

        private void txt_Cpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Cpf_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            CadastroPessoa += 1;
            FrmCadastro cad = new FrmCadastro();
            cad.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Cadastro Pessoa " + CadastroPessoa;
            TB.Text = "Cadastro Pessoa " + CadastroPessoa;
            TB.Controls.Add(cad);

        }
    }
}
