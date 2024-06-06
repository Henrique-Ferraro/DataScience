using Android.Util;
using System.Collections.Generic;
using MySqlConnector;
using Mobile.Resources.mobileModels;
using System;
using System.Data;
using System.Data.SqlClient;
using pessoa = List<string>;

namespace Mobile.Resources.DataBaseHelper
{
    public class dbPessoa
    {
        private string _dbPessoa;

        public pessoa(string nome) =. _nome
        public class DataBase
        {
            string dest = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            public bool CriarBancoDados()
            {
                try
                {
                    using(var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbPessoa.db")))
                    {
                        connect.CreateTable<pessoa>();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("MySqlEx", ex.Message);
                    return false;
                }
            }
            public bool InsertPessoa(pessoa _pessoa)
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbPessoa.db")))
                    {
                        connect.Insert(_pessoa);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return false;
                }
            }

            public List<pessoa> GetPessoas()
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbPessoa.db")))
                    {
                        return connect.Table<pessoa>().ToList();
                    }
                }
                catch(SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return null;
                }
            }
            public bool UpdatePessoa(pessoa, _pessoa)
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbPessoa.db")))
                    {
                        connect.Query<pessoa>("UPDATE tbPessoa set Nome=?,Cpf=? WHERE Id=?", _pessoa.Nome, _pessoa.Cpf, _pessoa.Id);
                        return connect.Table<pessoa>().ToList();
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return false;
                }
            }
            public bool DeletePessoa(pessoa, _pessoa)
            {
                try
                {
                    using (var connect = new SqlConnection(System.IO.Path.Combine(dest, "tbPessoa.db")))
                    {
                        connect.Delete(_pessoa);
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    Log.Info("SqlEx", ex.Message);
                    return false;
                }
            }

            internal void UpdatePessoa(pessoa pessoa)
            {
                throw new NotImplementedException();
            }

            internal void DeletePessoa(pessoa pessoa)
            {
                throw new NotImplementedException();
            }
        }
    }
}