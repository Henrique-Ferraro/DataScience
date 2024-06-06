using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySqlConnector;
using ServiceStack.DataAnnotations;

namespace Mobile.Resources.mobileModels
{
    public class pessoa
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string nome { get; set; }
        public long cpf { get; set; }
        public string endereco { get; set; }
        public int telefone { get; set; }

    }
}