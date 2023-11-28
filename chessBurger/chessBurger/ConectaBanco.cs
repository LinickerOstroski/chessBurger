using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;


namespace chessBurger
{
    internal class ConectaBanco
    {
        MySqlConnection conexao = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10665628;password=h5ZXxAuI5g;database=sql10665628");
        public string mensagem;

           //Comunicação com as stored procedures ***
        public bool inserePedido(Pedido novoPedido)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_inserePedido", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomeCliente", novoPedido.NomeCliente);
                cmd.Parameters.AddWithValue("idLanche", novoPedido.LancheEscolhido);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }//fim insere pedido

        public bool insereLanche(Lanche novoLanche)
        {
            try
            {
                conexao.Open();
                MySqlCommand cmd =
                    new MySqlCommand("sp_insereLanche", conexao);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("nomeLanche", novoLanche.NomeLanche); //Entre aspas = parametros da stored procedure
                cmd.Parameters.AddWithValue("ingredientes", novoLanche.Ingredientes);
                cmd.Parameters.AddWithValue("precoLanche", novoLanche.Preco);
                cmd.ExecuteNonQuery();//executar no banco
                return true;
            }
            catch (MySqlException erro)
            {
                mensagem = erro.Message;
                return false;
            }
        }// fim insere lanche
        public DataTable listaLanches()
        {
            // comentario
            MySqlCommand cmd = new MySqlCommand("sp_listaLanches", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista lanches

        public DataTable listaPedidos()
        {
            MySqlCommand cmd = new MySqlCommand("sp_listaPedidos", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexao.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable tabela = new DataTable();
                da.Fill(tabela);
                return tabela;
            }// fim try
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return null;
            }
            finally
            {
                conexao.Close();
            }

        }// fim lista pedidos

        public bool deletaPedidos(int idRemovePedido)
        {
            MySqlCommand cmd = new MySqlCommand("sp_removePedido", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idPedidos", idRemovePedido);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deleta pedidos

        public bool deletaLanches(int idRemoveLanche)
        { 
            MySqlCommand cmd = new MySqlCommand("sp_removeLanche", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idLanches", idRemoveLanche);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim deleta lanche

        public bool alteraLanche(Lanche l, int idlanche)
        {
            MySqlCommand cmd = new MySqlCommand("sp_alteraLanche", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("idLanches", idlanche);
            cmd.Parameters.AddWithValue("nomeLanche", l.NomeLanche);
            cmd.Parameters.AddWithValue("ingredientes", l.Ingredientes);
            cmd.Parameters.AddWithValue("precoLanche", l.Preco);
     ////
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery(); // executa o comando
                return true;
            }
            catch (MySqlException e)
            {
                mensagem = "Erro:" + e.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }// fim update_lanche

        public bool verifica(string user, string pass)
        {
            string senhaHash = Biblioteca.makeHash(pass);
            MySqlCommand cmd = new MySqlCommand("consultaLogin", conexao);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("usuario", user);
            cmd.Parameters.AddWithValue("senha", senhaHash);
            try
            {
                conexao.Open();//abrindo a conexão;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();// tabela virtual
                da.Fill(ds); //passando os valores consultados para o DataSet
                if (ds.Tables[0].Rows.Count > 0) // verifica se houve retorno
                    return true;
                else
                    return false;

            }
            catch (MySqlException er)
            {
                mensagem = "Erro" + er.Message;
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }



    }// fim classe
}
