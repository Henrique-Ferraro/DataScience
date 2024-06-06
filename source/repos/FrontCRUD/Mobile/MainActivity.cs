using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using Android.Widget;
using static Mobile.Resources.DataBaseHelper.dbPessoa;
using System.Collections.Generic;
using Mobile.Resources.mobileModels;
using Mobile.Resources.ListAdapter;

namespace Mobile
{
    [Activity(Label = "Cadastro Pessoa", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        ListView lvDados;
        List<pessoa> listaPessoas = new List<pessoa>();
        DataBase dbPessoa;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Essentials.Platform.Init(this, bundle);
            SetContentView(Resource.Layout.activity_main);

            //Criar Banco de Dados
            CriarBancoDados();
            lvDados = FindViewById<ListView>(Resource.Id.lvDados);
            var txtNome = FindViewById<EditText>(Resource.Id.txtNome);
            var txtCpf = FindViewById<EditText>(Resource.Id.txtCpf);
            var txtEndereco = FindViewById<EditText>(Resource.Id.txtEndereco);
            var txtTelefone = FindViewById<EditText>(Resource.Id.txtTelefone);
            var btnInserir = FindViewById<EditText>(Resource.Id.btnInserir);
            var btnEditar = FindViewById<Button>(Resource.Id.btnEditar);
            var btnDeletar = FindViewById<Button>(Resource.Id.btnDeletar);
            var btnConsultar = FindViewById<Button>(Resource.Id.btnConsultar);

            //Carregar Dados
            CarregarDados();

            //Botao Incluir
            btnInserir.Click += delegate
            {
                pessoa _pessoa = new pessoa()
                {
                    nome = txtNome.Text,
                    cpf = txtCpf.Number,
                    endereco = txtEndereco.Text,
                    telefone = txtTelefone.Number
                };
                dbPessoa.InsertPessoa(_pessoa);
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                CarregarDados();
            };
            //botao Editar
            btnEditar.Click += delegate
            {
                pessoa _pessoa = new pessoa()
                {
                    id = int.Parse(txtNome.Tag.ToString()),
                    nome = txtNome.Text,
                    cpf = txtCpf.Number,
                    endereco = txtEndereco.Text,
                    telefone = txtTelefone.Number
                };
                dbPessoa.UpdatePessoa(_pessoa);
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                CarregarDados();
            };

            //Botao Deletar
            btnDeletar.Click += delegate
            {
                pessoa _pessoa = new pessoa()
                {
                    id = int.Parse(txtNome.Tag.ToString()),
                    nome = txtNome.Text,
                    cpf = txtCpf.Number,
                    endereco = txtEndereco.Text,
                    telefone = txtTelefone.Number
                };
                dbPessoa.DeletePessoa(_pessoa);
                txtNome.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                CarregarDados();
            };

            //evento ItemClick do ListView
            lvDados.ItemClick += (s, e) =>
            {
                for (int i = 0; i < lvDados.Count; i++)
                {
                    if (e.Position == i)
                        lvDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Chocolate);
                    else
                        lvDados.GetChildAt(i).SetBackgroundColor(Android.Graphics.Color.Transparent);
                }

                //Vinculando dados do listView
                var lvtxtNome = e.View.FindViewById<TextView>(Resource.Id.txtvNome);
                var lvtxtCpf = e.View.FindViewById<TextView>(Resource.Id.txtvCpf);
                var lvtxtEndereco = e.View.FindViewById<TextView>(Resource.Id.txtvEndereco);
                var lvtxtTelefone = e.View.FindViewById<TextView>(Resource.Id.txtvTelefone);

                txtNome.Text = lvtxtNome.Text;
                txtNome.Tag = e.Id;
                txtNome.Text = lvtxtNome.Text;
                txtNome.Text = lvtxtNome.Text;
            };
        }

        // Rotina para Criar Banco de Dados
        private void CriarBancoDados()
        {
            dbPessoa = new DataBase();
            dbPessoa.CriarBancoDados();
        }

        private void CarregarDados()
        {
            listaPessoas = dbPessoa.GetPessoas();
            var adapter = new listViewAdapter(this, listaPessoas);
            lvDados.Adapter = adapter;
        }
    }

}
