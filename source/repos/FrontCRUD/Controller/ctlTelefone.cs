using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Models;


namespace Controller
{
    public class ctlTelefone
    {
        public bool CadastrarTelefone(mdlTelefone _mdlTelefone)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "INSERT INTO dbTelefone (numero, ddd, tipo) VALUES (@Numero, @Ddd, @Tipo)";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@Numero";
                pmtNumero.DbType = DbType.String;
                pmtNumero.Value = _mdlTelefone.numero;
                cmd.Parameters.Add(pmtNumero);

                var pmtDdd = cmd.CreateParameter();
                pmtDdd.ParameterName = "@Ddd";
                pmtDdd.DbType = DbType.String;
                pmtDdd.Value = _mdlTelefone.ddd;
                cmd.Parameters.Add(pmtDdd);

                var pmtTipo = cmd.CreateParameter();
                pmtTipo.ParameterName = "@Tipo";
                pmtTipo.DbType = DbType.String;
                pmtTipo.Value = _mdlTelefone.tipo;
                cmd.Parameters.Add(pmtTipo);

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
                throw new Exception("Erro ao cadastrar telefone: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }

        public bool AlterarTelefone(mdlTelefone _mdlTelefone)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "UPDATE dbTelefone numero = @Numero, ddd = @Ddd, tipo = @Tipo";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@Numero";
                pmtNumero.DbType = DbType.String;
                pmtNumero.Value = _mdlTelefone.numero;
                cmd.Parameters.Add(pmtNumero);

                var pmtDdd = cmd.CreateParameter();
                pmtDdd.ParameterName = "@Ddd";
                pmtDdd.DbType = DbType.String;
                pmtDdd.Value = _mdlTelefone.ddd;
                cmd.Parameters.Add(pmtDdd);

                var pmtTipo = cmd.CreateParameter();
                pmtTipo.ParameterName = "@Tipo";
                pmtTipo.DbType = DbType.String;
                pmtTipo.Value = _mdlTelefone.tipo;
                cmd.Parameters.Add(pmtTipo);

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
                throw new Exception("Erro ao alterar telefone: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }
        public bool ExcluirTelefone(mdlTelefone _mdlTelefone)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);

            try
            {
                connectdb.Open();

                string query = "DELETE FROM dbTelefone WHERE numero = @Numero";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@Numero";
                pmtNumero.DbType = DbType.String;
                pmtNumero.Value = _mdlTelefone.numero;
                cmd.Parameters.Add(pmtNumero);

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
                throw new Exception("Erro ao alterar telefone: " + ex.Message);
            }
            finally
            {
                connectdb.Close();
            }
        }
        public List<mdlTelefone> ConsultarTelefone(mdlTelefone _mdlTelefone)
        {
            string connectSql = @""
            OleDbConnection connectdb = new OleDbConnection(connectSql);
            List<mdlTelefone> _lstmdlTelefone = new List<mdlTelefone>();
            try
            {
                connectdb.Open();

                string query = "SELECT * FROM dbTelefone WITH(NOLOCK) WHERE numero = @Numero";
                OleDbCommand cmd = new OleDbCommand(query, connectdb);

                var pmtNumero = cmd.CreateParameter();
                pmtNumero.ParameterName = "@Numero";
                pmtNumero.DbType = DbType.String;
                pmtNumero.Value = _mdlTelefone.numero;
                cmd.Parameters.Add(pmtNumero);

                OleDbDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    _mdlTelefone.numero = Convert.ToInt32(rd.GetString(1));
                    _mdlTelefone.ddd = Convert.ToInt32(rd.GetString(2));
                    _mdlTelefone.tipo = rd.GetString(3);
                    _lstmdlTelefone.Add(_mdlTelefone);
                }
                return _lstmdlTelefone;

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
