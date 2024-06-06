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
using System.Data;
using System.Data.SqlClient;
using Mobile.Resources.mobileModels;
using Android.Util;

namespace Mobile.Resources.DataBaseHelper
{
    public class dbEndereco
    {
        public class DataBase
        {
            string dest = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            public bool CriarBancoDados()
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbEndereco.db")))
                    {
                        connect.CreateTable<endereco>();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("MySqlEx", ex.Message);
                    return false;
                }
            }
            public bool InsertEndereco(endereco _endereco)
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbEndereco.db")))
                    {
                        connect.Insert(_endereco);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return false;
                }
            }

            public List<endereco> GetEndereco()
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbEndereco.db")))
                    {
                        return connect.Table<endereco>().ToList();
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return null;
                }
            }
            public bool UpdateEndereco(endereco, _endereco)
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbEndereco.db")))
                    {
                        connect.Query<endereco>("UPDATE tbEndereco set Logradouro=?,Numero=?,Cep=?,Bairro=?,Cidade=?,Estado=? WHERE Id=?", _endereco.Id, _endereco.Logradouro, _endereco.Numero, _endereco.Cep, _endereco.Bairro, _endereco.Cidade, _endereco.Etsado);
                        return connect.Table<endereco>().ToList();
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return false;
                }
            }
            public bool DeleteEndereco(endereco, _endereco)
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbPessoa.db")))
                    {
                        connect.Delete(_endereco);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return false;
                }
            }
        }
    }
}