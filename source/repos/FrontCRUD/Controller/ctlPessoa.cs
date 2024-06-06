using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Models;
using System.Data.SqlClient;



namespace Controller
{

    public class ctlPessoa
    {
        public bool CadastrarPessoa(MdlPessoa _mdlPessoa)
        {
            string connectionsql = "DataSource = LAPTOP - 34N4CKPT / SQLEXPRESS; InitialCatalog = PIM_VIII; IntegratedSecurity = True";
            SqlConnection connectbd = new SqlConnection(connectionsql);
            //List<mdlPessoa> _lstPessoa = new List<mdlPessoa>();

            try
            {
                connectbd.Open();

                string query = "INSERT INTO dbPessoa (nome, cpf, endereco, telefone) VALUES (@Nome, @Cpf, @Endereco, @Telefone)", connectbd;
                SqlConnection cmd = new SqlConnection (query, connectbd);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlPessoa.nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtNome.Value = _mdlPessoa.cpf;
                cmd.Parameters.Add(pmtCpf);

                // var pmtEndereco = cmd.CreateParameter();
                //pmtEndereco.ParameterName = "@Endereco";
                // pmtEndereco.DbType = DbType.String;
                // pmtEndereco.Value = _mdlPessoa.endereco;
                //cmd.Parameters.Add(pmtEndereco);

                // var pmtTelefone = cmd.CreateParameter();
                // pmtTelefone.ParameterName = "@Telefone";
                // pmtTelefone.DbType = DbType.String;
                //pmtTelefone.Value = _mdlPessoa.telefone;
                //cmd.Parameters.Add(pmtTelefone);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    connectiondb.Close();
                    return true;
                }
                else
                {
                    connectiondb.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                connectiondb.Close();
                throw new Exception("Erro ao cadastrar pessoa: " + ex.Message);
            }
            finally
            {
                 connectiondb.Close();
            }
        }

        public bool AlterarPessoa(MdlPessoa _mdlPessoa)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "UPDATE dbPessoa set nome = @Nome, cpf = @Cpf, endereco = @Endereco, telefone = @Telefone";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtNome = cmd.CreateParameter();
                pmtNome.ParameterName = "@Nome";
                pmtNome.DbType = DbType.String;
                pmtNome.Value = _mdlPessoa.nome;
                cmd.Parameters.Add(pmtNome);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtNome.Value = _mdlPessoa.cpf;
                cmd.Parameters.Add(pmtCpf);

                // var pmtEndereco = cmd.CreateParameter();
                //pmtEndereco.ParameterName = "@Endereco";
                //pmtEndereco.DbType = DbType.String;
                //pmtEndereco.Value = _mdlPessoa.endereco;
                //cmd.Parameters.Add(pmtEndereco);

                //var pmtTelefone = cmd.CreateParameter();
                //pmtTelefone.ParameterName = "@Telefone";
                //pmtTelefone.DbType = DbType.String;
                //pmtTelefone.Value = _mdlPessoa.telefone;
                //cmd.Parameters.Add(pmtTelefone);

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
                throw new Exception("Erro ao cadastrar pessoa: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }

        public bool ExcluirPessoa(MdlPessoa _mdlPessoa)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "DELETE FROM dbPessoa WHERE cpf = @Cpf";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlPessoa.cpf;
                cmd.Parameters.Add(pmtCpf);

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
                throw new Exception("Erro ao excluir pessoa: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }
        public List<MdlPessoa> ConsultarPessoa(MdlPessoa _mdlPessoa)
        {
            string connectSql = @"Provider=Microsoft.jet.OLEDB.4.0;Data Source=.\SQLExpress;Initial Catalog=aspnet-Test;Integrated Security=True;Pooling=False"
            OleDbConnection connectdb = new OleDbConnection(connectSql);
            List<MdlPessoa> _lstmdlPessoa = new List<MdlPessoa>();
            try
            {
                connectdb.Open();

                string query = "SELECT * FROM dbPessoa WITH(NOLOCK) WHERE cpf = @Cpf";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtCpf = cmd.CreateParameter();
                pmtCpf.ParameterName = "@Cpf";
                pmtCpf.DbType = DbType.String;
                pmtCpf.Value = _mdlPessoa.cpf;
                cmd.Parameters.Add(pmtCpf);

                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    _mdlPessoa.nome = rd.GetString(1);
                    _mdlPessoa.cpf = Convert.ToInt32(rd.GetString(2));
                    _lstmdlPessoa.Add(_mdlPessoa);
                }
                return _lstmdlPessoa;
                
            }
            catch (Exception ex)
            {
                connectdb.Close();
                throw new Exception("Erro ao consultar pessoa: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }
    }
}

