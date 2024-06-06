using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Models;

namespace Template

{
    public class ctlEndereco
    {
        public bool CadastrarEndereco(mdlEndereco _mdlEndereco)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "INSERT INTO tbEndereco (logradouro, numero, cep, bairro, cidade, estado) VALUES (@Logradouro, @Numero, @Cep, @Bairro, @Cidade, @Estado)";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtLogradouro = cmd.CreateParameter();
                pmtLogradouro.ParameterName = "@Logradouro";
                pmtLogradouro.DbType = DbType.String;
                pmtLogradouro.Value = _mdlEndereco.logradouro;
                cmd.Parameters.Add(pmtLogradouro);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@Numero";
                pmtNumero.DbType = DbType.String;
                pmtNumero.Value = _mdlEndereco.numero;
                cmd.Parameters.Add(pmtNumero);

                var pmtCep = cmd.CreateParameter();
                pmtCep.ParameterName = "@Cep";
                pmtCep.DbType = DbType.String;
                pmtCep.Value = _mdlEndereco.cep;
                cmd.Parameters.Add(pmtCep);

                var pmtBairro = cmd.CreateParameter();
                pmtBairro.ParameterName = "@Bairro";
                pmtBairro.DbType = DbType.String;
                pmtBairro.Value = _mdlEndereco.bairro;
                cmd.Parameters.Add(pmtBairro);

                var pmtCidade = cmd.CreateParameter();
                pmtCidade.ParameterName = "@Cidade";
                pmtCidade.DbType = DbType.String;
                pmtCidade.Value = _mdlEndereco.cidade;
                cmd.Parameters.Add(pmtCidade);

                var pmtEstado = cmd.CreateParameter();
                pmtEstado.ParameterName = "@Estado";
                pmtEstado.DbType = DbType.String;
                pmtEstado.Value = _mdlEndereco.estado;
                cmd.Parameters.Add(pmtEstado);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    connectdb.Close();
                    return true;
                }
                else
                {
                    connectdb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                connectdb.Close();
                throw new Exception("Erro ao cadastrar endereco: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }

        public static List<mdlEndereco> consulta()
        {
            throw new NotImplementedException();
        }

        public static List<mdlEndereco> consulta(string text)
        {
            throw new NotImplementedException();
        }

        public bool AlterarEndereco(mdlEndereco _mdlEndereco)
        {
            string connectSql = @""
                OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "UPDATE dbEndereco logradouro = @Logradouro, numero = @Numero, cep = @Cep, bairro = @Bairro, cidade = @Cidade, estado = @Estado";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtLogradouro = cmd.CreateParameter();
                pmtLogradouro.ParameterName = "@Logradouro";
                pmtLogradouro.DbType = DbType.String;
                pmtLogradouro.Value = _mdlEndereco.logradouro;
                cmd.Parameters.Add(pmtLogradouro);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@Numero";
                pmtNumero.DbType = DbType.String;
                pmtNumero.Value = _mdlEndereco.numero;
                cmd.Parameters.Add(pmtNumero);

                var pmtCep = cmd.CreateParameter();
                pmtCep.ParameterName = "@Cep";
                pmtCep.DbType = DbType.String;
                pmtCep.Value = _mdlEndereco.cep;
                cmd.Parameters.Add(pmtCep);

                var pmtBairro = cmd.CreateParameter();
                pmtBairro.ParameterName = "@Bairro";
                pmtBairro.DbType = DbType.String;
                pmtBairro.Value = _mdlEndereco.bairro;
                cmd.Parameters.Add(pmtBairro);

                var pmtCidade = cmd.CreateParameter();
                pmtCidade.ParameterName = "@Cidade";
                pmtCidade.DbType = DbType.String;
                pmtCidade.Value = _mdlEndereco.cidade;
                cmd.Parameters.Add(pmtCidade);

                var pmtEstado = cmd.CreateParameter();
                pmtEstado.ParameterName = "@Estado";
                pmtEstado.DbType = DbType.String;
                pmtEstado.Value = _mdlEndereco.estado;
                cmd.Parameters.Add(pmtEstado);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    connectdb.Close();
                    return true;
                }
                else
                {
                    connectdb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                connectdb.Close();
                throw new Exception("Erro ao alterar endereco: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }
        public bool ExcluirEndereco(mdlEndereco _mdlEndereco)
        {
            string connectSql = @""
                OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "DELETE FROM dbEndereco WHERE logradouro = @Logradouro";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtLogradouro = cmd.CreateParameter();
                pmtLogradouro.ParameterName = "@Logradouro";
                pmtLogradouro.DbType = DbType.String;
                pmtLogradouro.Value = _mdlEndereco.logradouro;
                cmd.Parameters.Add(pmtLogradouro);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    connectdb.Close();
                    return true;
                }
                else
                {
                    connectdb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                connectdb.Close();
                throw new Exception("Erro ao excluir endereco: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }
        public List<mdlEndereco> ConsultarEndereco(mdlEndereco _mdlEndereco)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);
            List<mdlEndereco> _lstmdlEndereco = new List<mdlEndereco>();
            try
            {
                connectdb.Open();

                string query = "SELECT * FROM dbEndereco WITH(NOLOCK) WHERE logradouro = @Logradouro";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtLogradouro = cmd.CreateParameter();
                pmtLogradouro.ParameterName = "@Logradouro";
                pmtLogradouro.DbType = DbType.String;
                pmtLogradouro.Value = _mdlEndereco.logradouro;
                cmd.Parameters.Add(pmtLogradouro);

                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    _mdlEndereco.logradouro = rd.GetString(1);
                    _mdlEndereco.numero = Convert.ToInt32(rd.GetString(2));
                    _mdlEndereco.cep = Convert.ToInt32(rd.GetString(3));
                    _mdlEndereco.bairro = rd.GetString(4);
                    _mdlEndereco.cidade = rd.GetString(5);
                    _mdlEndereco.estado = rd.GetString(6);
                    _lstmdlEndereco.Add(_mdlEndereco);
                }
                return _lstmdlEndereco;

            }
            catch (Exception ex)
            {
                connectdb.Close();
                throw new Exception("Erro ao consultar Endereco: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }
    }
}

