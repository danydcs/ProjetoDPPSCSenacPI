using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Etapa_3.Models
{
    public class FaleConoscoRepository
    {
        
        private const string DadosConexao = "Database=dppsc; Data Source=LOCALHOST; User Id=root;";

        
        public void Cadastrar(FaleConosco msg)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);

            conexao.Open();
            
            string query = "INSERT INTO faleconosco (nome, email, telefone, mensagem, idfaleconosco) VALUES (@nome, @email, @telefone, @mensagem, @idfaleconosco)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

        	comando.Parameters.AddWithValue("@nome", msg.nome);
	        comando.Parameters.AddWithValue("@email",msg.email);
            comando.Parameters.AddWithValue("@telefone", msg.telefone);
			comando.Parameters.AddWithValue("@mensagem", msg.mensagem);
			comando.Parameters.AddWithValue("@idfaleconosco", msg.idfaleconosco);
            
	        comando.ExecuteNonQuery();

            conexao.Close();

        }

        public List<FaleConosco> Listar()
        {
	        MySqlConnection conexao = new MySqlConnection(DadosConexao); 

	        conexao.Open(); 

	        string query = "SELECT * FROM faleconosco"; 

	        MySqlCommand comando = new MySqlCommand(query, conexao); 	

	        MySqlDataReader reader = comando.ExecuteReader();

	        List<FaleConosco> listaContatos = new List<FaleConosco>();

	        while(reader.Read()) 
	        {
		        FaleConosco msg = new FaleConosco();

		        msg.idfaleconosco = reader.GetInt32("idfaleconosco");

		        if(!reader.IsDBNull(reader.GetOrdinal("nome"))) 
		        msg.nome = reader.GetString("nome");

		        if(!reader.IsDBNull(reader.GetOrdinal("email"))) 
		        msg.email = reader.GetString("email");

		        if(!reader.IsDBNull(reader.GetOrdinal("telefone"))) 
		        msg.telefone = reader.GetString("telefone");

				if(!reader.IsDBNull(reader.GetOrdinal("mensagem"))) 
		        msg.mensagem = reader.GetString("mensagem");


		        listaContatos.Add(msg);

            }
	    
	        conexao.Close(); 

	        return listaContatos;

        }

        
	}
}

