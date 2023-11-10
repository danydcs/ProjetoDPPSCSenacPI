using System;
using System.Collections.Generic;
using MySqlConnector;

namespace Etapa_3.Models
{
    public class CadastroRepository
    {
        private const string DadosConexao = "Database=dppsc; Data Source=LOCALHOST; User Id=root;";

        public void Cadastrar(Cadastro c)
        {
            MySqlConnection conexao = new MySqlConnection(DadosConexao);

            conexao.Open();
            
            string query = "INSERT INTO Cadastro (nome, curso, telefone, email, senha, datanascimento) VALUES (@nome, @curso, @telefone, @email, @senha, @datanascimento)";

            MySqlCommand comando = new MySqlCommand(query, conexao);

        	comando.Parameters.AddWithValue("@nome", c.nome);
	        comando.Parameters.AddWithValue("@curso", c.curso);
            comando.Parameters.AddWithValue("@telefone", c.telefone);
	        comando.Parameters.AddWithValue("@email", c.email);
			comando.Parameters.AddWithValue("@senha", c.senha);
            comando.Parameters.AddWithValue("@datanascimento", c.datanascimento.ToString("yyyy-MM-dd"));
            
	        comando.ExecuteNonQuery();

            conexao.Close();

        }

		public List<Cadastro> Listar()
        {
	        MySqlConnection conexao = new MySqlConnection(DadosConexao); 

	        conexao.Open(); 

	        string query = "SELECT * FROM Cadastro"; 

	        MySqlCommand comando = new MySqlCommand(query, conexao); 	

	        MySqlDataReader reader = comando.ExecuteReader();

	        List<Cadastro> listaMembros = new List<Cadastro>();

	        while(reader.Read()) 
	        {
		        Cadastro c = new Cadastro();

		        c.idcadastro = reader.GetInt32("idCadastro");

		        if(!reader.IsDBNull(reader.GetOrdinal("nome"))) 
		        c.nome = reader.GetString("nome");

				if(!reader.IsDBNull(reader.GetOrdinal("curso"))) 
		        c.curso = reader.GetString("curso");

		        if(!reader.IsDBNull(reader.GetOrdinal("telefone"))) 
		        c.telefone = reader.GetString("telefone");

		        if(!reader.IsDBNull(reader.GetOrdinal("email"))) 
		        c.email = reader.GetString("email");

				if(!reader.IsDBNull(reader.GetOrdinal("senha"))) 
		        c.senha = reader.GetString("senha");

		        c.datanascimento = reader.GetDateTime("datanascimento");

		        listaMembros.Add(c);

            }
	    
	        conexao.Close(); 

	        return listaMembros;

        }

		public void Editar(Cadastro c)
    	{
	        MySqlConnection conexao = new MySqlConnection(DadosConexao);

	        conexao.Open();

	        string query = "UPDATE Cadastro SET nome=@nome, curso=@curso, telefone=@telefone, email=@email, senha=@senha, datanascimento=@datanascimento WHERE idcadastro=@idcadastro";

	        MySqlCommand comando = new MySqlCommand(query, conexao);

	        comando.Parameters.AddWithValue("@nome", c.nome);
	        comando.Parameters.AddWithValue("@curso", c.curso);
            comando.Parameters.AddWithValue("@telefone", c.telefone);
	        comando.Parameters.AddWithValue("@email", c.email);
			comando.Parameters.AddWithValue("@senha", c.senha);
            comando.Parameters.AddWithValue("@datanascimento", c.datanascimento.ToString("yyyy-MM-dd"));
			comando.Parameters.AddWithValue("@idcadastro", c.idcadastro);

	        comando.ExecuteNonQuery();

	        conexao.Close();
	    }

		public Cadastro BuscaPorId(int idcadastro)
		{
			MySqlConnection conexao = new MySqlConnection(DadosConexao);
			
			conexao.Open();
			
			string query = "SELECT * FROM Cadastro WHERE idcadastro = @idcadastro";
			
			MySqlCommand comando = new MySqlCommand(query, conexao);

			comando.Parameters.AddWithValue("@idcadastro", idcadastro);

			MySqlDataReader reader = comando.ExecuteReader();

			Cadastro c = new Cadastro();

			if(reader.Read())
			{
				c.idcadastro = reader.GetInt32("idcadastro");

				if(!reader.IsDBNull(reader.GetOrdinal("nome")))
				{ 
		        c.nome = reader.GetString("nome");
				}

				if(!reader.IsDBNull(reader.GetOrdinal("curso"))) 
				{	
				c.curso = reader.GetString("curso");
				}

		        if(!reader.IsDBNull(reader.GetOrdinal("telefone"))) 
		        {
				c.telefone = reader.GetString("telefone");
				}

		        if(!reader.IsDBNull(reader.GetOrdinal("email"))) 
		        {
				c.email = reader.GetString("email");
				}

				if(!reader.IsDBNull(reader.GetOrdinal("senha")))
				{ 
		        c.senha = reader.GetString("senha");
				}

				if(!reader.IsDBNull(reader.GetOrdinal("datanascimento")))
				{ 
		        c.datanascimento = reader.GetDateTime("datanascimento");
				}


			}

			conexao.Close();

			return c;
		}

		public void Deletar(int idcadastro)
		{
			MySqlConnection conexao = new MySqlConnection(DadosConexao);
			conexao.Open();

			string query = "DELETE FROM Cadastro WHERE idcadastro = @idcadastro";

			MySqlCommand comando = new MySqlCommand(query, conexao);

			comando.Parameters.AddWithValue("@idcadastro", idcadastro);

			comando.ExecuteNonQuery();

			conexao.Close();
		}
		
		public Cadastro VerificaLogin(Cadastro c)
		{
			MySqlConnection conexao = new MySqlConnection(DadosConexao);
			
			conexao.Open();
			
			string query = "SELECT * FROM Cadastro WHERE email = @email AND senha = @senha";
			
			MySqlCommand comando = new MySqlCommand(query, conexao);

			comando.Parameters.AddWithValue("@email", c.email);
			comando.Parameters.AddWithValue("@senha", c.senha);

			MySqlDataReader reader = comando.ExecuteReader();

			Cadastro cadastroEncontrado = new Cadastro();
			
			if(reader.Read())
			{
				cadastroEncontrado.idcadastro = reader.GetInt32("idcadastro");

				if(!reader.IsDBNull(reader.GetOrdinal("nome")))
				{
					cadastroEncontrado.nome = reader.GetString("nome");
				}

				if(!reader.IsDBNull(reader.GetOrdinal("curso")))
				{
					cadastroEncontrado.curso = reader.GetString("curso");
				}

				if(!reader.IsDBNull(reader.GetOrdinal("email")))
				{
					cadastroEncontrado.email = reader.GetString("email");
				}

				if(!reader.IsDBNull(reader.GetOrdinal("senha")))
				{
					cadastroEncontrado.senha = reader.GetString("senha");
				}

				if(!reader.IsDBNull(reader.GetOrdinal("dataNascimento")))
				{
					cadastroEncontrado.datanascimento = reader.GetDateTime("dataNascimento");
				}
			}

			conexao.Close();

			return cadastroEncontrado;
		
    	}
			
		public void TestarConexao()
		{
			MySqlConnection Conexao = new MySqlConnection(DadosConexao);
			Conexao.Open();
			Console.WriteLine("Banco de dados funcionando");
			Conexao.Close();

		}
}
}