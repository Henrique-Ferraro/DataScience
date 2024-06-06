using Android.App;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mobile.Resources.ListAdapter;
using Mobile.Resources.mobileModels;

namespace Mobile.Resources.ListAdapter
{
    class listViewAdapter : BaseAdapter
    {
        private readonly Activity context;
        private readonly List<pessoa> pessoas;

        public listViewAdapter(Activity _contest, List<pessoa> _pessoas)
        {
            this.context = _context;
            this.alunos = _alunos;
        }

        public listViewAdapter(MainActivity mainActivity, List<pessoa> listaPessoas)
        {
        }

        public override int Count
        {
            get
            {
                return alunos.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return pessoas[position].Id;
        }

        public override View GetItem(int position, View convertView,  ViewGroup parent)
        {
            var view = convertView ?? context.LayoutInflater.Inflate(Resource.Layout.LitViewlayoutPim, parent, false);

            var lvtxtNome = view.FindViewById<TextView>(Resource.Id.txtvNome);
            var lvtxtCpf = view.FindViewById<TextView>(Resource.Id.txtvCpf);
            var lvtxtEndereco = view.FindViewById<TextView>(Resource.Id.txtvEndereco);
            var lvtxtTelefone = view.FindViewById<TextView>(Resource.Id.txtvTelefone);

            lvtxtNome.Text = pessoas[position].Nome;
            lvtxtNome.Text = pessoas[position].Cpf;
            lvtxtNome.Text = pessoas[position].Endereco;
            lvtxtNome.Text = pessoas[position].Telefone;

            return view;
        }

        public override java.Lang.Object GetItem(int position)
        {
            return null;
        }

    }
}