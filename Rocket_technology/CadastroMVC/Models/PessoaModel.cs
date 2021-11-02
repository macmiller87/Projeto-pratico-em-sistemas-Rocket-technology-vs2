using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro_MVC.Models
{
    public class PessoaModel
    {
        // Campos (Banco de dados) ou atributos desta classe //
        [DisplayName("ID")] // É semelhante a uma etiqueta ou Label/Tag (Apelido) //
        public int PessoaID { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório")] // Validação do Nome, Requerido ou obrigatório //
        [StringLength(50, MinimumLength = 5, ErrorMessage = "O tamanho do campo deve ser maior que 4 caracteres")] // Validação do Nome com formato definido //
        public string PessoaNome { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "O campo Email é obrigatório")] // Validação do Email, Requerido ou obrigatório //
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um Email válido")] // Validação do email com formato definido //
        public string PessoaEmail { get; set; }

        [DisplayName("telefone")]
        [Required(ErrorMessage = "O campo Telefone é obrigatório")] // Validação do Telefone, Requerido ou obrigatório //
        public string PessoaTelefone { get; set; }

        // Criar uma CONSTANTE para conectar com o Banco de dados //
        readonly string connectionString = @"Data Source=NOTEBOOK-DO-MAC\SQLEXPRESS;Initial Catalog=cadastro_mvc;Integrated Security=True";

        public DataTable Listar()
        {
            // Cria uma varíavel para receber os dados da tabela no Banco de Dados (referência) \\
            DataTable tblPessoa = new DataTable();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                // Abrir a conexão com o Banco de Dados //
                sqlCon.Open();

                // Cria uma instrução Sql para ser executada no Servidor Sql Server //
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM tb_pessoa ORDER BY PessoaNome ASC", sqlCon);


                /* Outra opção de => Cria uma instrução Sql para ser executada no Servidor Sql Server.
             
                 String sql = "SELECT * FROM tb_pessoa"; 
                 SqlDataAdapter sqlDa = new SqlDataAdapter(sql, sqlCon);

                */

                // Recuperação dos dados após a execução da instrução //
                sqlDa.Fill(tblPessoa);
            }

            // Retornar os dados obtidos para serem mostrados na View (Index) //
            return tblPessoa;
        }

        // Este método salva os dados que vieram do formulário no banco de dados //
        public void Salvar()
        {
            // Cria uma conexão com o banco de dados //
            using (SqlConnection sqlCon = new SqlConnection(connectionString)) {

                // Realiza a abertura de uma conexão com o banco de dados //
                sqlCon.Open();

                // Cria uma instrução SQL para ser executada no SQL Server //
                SqlCommand SqlCmd = new SqlCommand("INSERT INTO TB_pessoa VALUES (@PessoaNome, @PessoaEmail, @PessoaTelefone)", sqlCon);

                SqlCmd.Parameters.AddWithValue("@PessoaNome", PessoaNome);
                SqlCmd.Parameters.AddWithValue("@PessoaEmail", PessoaEmail);
                SqlCmd.Parameters.AddWithValue("@PessoaTelefone", PessoaTelefone);

                // Executar o comando no SQL Server (tecla F5 do SQL Server) //
                SqlCmd.ExecuteNonQuery();
            }
        }

        // Método solicitar para selecionar um registro desejado no Banco de Dados //
        // O parametro ID é o identificador do registro //
        public void Editar(int idPessoa)
        {
            DataTable tblPessoa = new DataTable();
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                SqlCon.Open();

                SqlDataAdapter SqlDa = new SqlDataAdapter(
                    
                    "SELECT * FROM tb_Pessoa WHERE PessoaID = @PessoaID", SqlCon);

                SqlDa.SelectCommand.Parameters.AddWithValue("@PessoaID", idPessoa);

                // recuperar o registro //
                SqlDa.Fill(tblPessoa);

                // Atribuir os dados recuperados do Banco de Dados para as variáveis do Model //
                PessoaID = Convert.ToInt32(tblPessoa.Rows[0][0].ToString());
                PessoaNome = tblPessoa.Rows[0][1].ToString();
                PessoaEmail = tblPessoa.Rows[0][2].ToString();
                PessoaTelefone = tblPessoa.Rows[0][3].ToString();
            }
        }

        public void Atualizar()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // Criação da instrução SQL para ser executado no Banco de Dados //
                SqlCommand sqlCmd = new SqlCommand(
                    
                    "UPDATE tb_Pessoa SET " +
                    "PessoaNome = @PessoaNome, " + 
                    "PessoaEmail = @PessoaEmail, " +
                    "PessoaTelefone = @PessoaTelefone " + 
                    "WHERE PessoaID = @PessoaID", sqlCon // Condição para a atualização do registro //
                    );

                /* Na atualização de um registro, se não for informado o que deve ser atualizado, todos os registros serão atualizados com os mesmos dados */
                sqlCmd.Parameters.AddWithValue("@PessoaID", PessoaID); // Somente para o WHERE //

                sqlCmd.Parameters.AddWithValue("@PessoaNome", PessoaNome);
                sqlCmd.Parameters.AddWithValue("@PessoaEmail", PessoaEmail);
                sqlCmd.Parameters.AddWithValue("@PessoaTelefone", PessoaTelefone);

                // Executar o comando UPDATE no Banco de Dados //
                sqlCmd.ExecuteNonQuery();
            }
        }

        // Remove da tabela o registro indicado em IDPessoa //
        public void Excluir(int idPessoa)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                // Cria a instrução SQL DELETE para remover o registro indicado com ID //
                SqlCommand sqlCmd = new SqlCommand(

                    "DELETE tb_pessoa WHERE PessoaID = @PessoaID", sqlCon);
                sqlCmd.Parameters.AddWithValue("@PessoaID", idPessoa);
                sqlCmd.ExecuteNonQuery();
            }
        }
    }
}
