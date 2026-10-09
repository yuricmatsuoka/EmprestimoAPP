using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;

public class EmprestimoDB
{
    private string conexao;

    public EmprestimoDB()
    {
        this.conexao = ConfigurationManager
            .ConnectionStrings["myDatabaseConnection"]
            .ConnectionString;
    }

    public void IncluirEmprestimo(Emprestimo emp)
    {
        MySqlConnection CN = new MySqlConnection(conexao);
        MySqlCommand Com = CN.CreateCommand();

        Com.CommandText = @"
            INSERT INTO Emprestimos
            (Item, Amigo, Contato, DataEmprestimo, DataDevolucao, Status)
            VALUES
            (?item, ?amigo, ?contato, ?dataEmp, ?dataDev, ?status)";

        Com.Parameters.AddWithValue("?item", emp.GetItem());
        Com.Parameters.AddWithValue("?amigo", emp.GetAmigo());
        Com.Parameters.AddWithValue("?contato", emp.GetContato());
        Com.Parameters.AddWithValue("?dataEmp", emp.GetDataEmprestimo());

        if (emp.GetDataDevolucao() == DateTime.MinValue)
        {
            Com.Parameters.AddWithValue("?dataDev", DBNull.Value);
        }
        else
        {
            Com.Parameters.AddWithValue(
                "?dataDev",
                emp.GetDataDevolucao()
            );
        }

        Com.Parameters.AddWithValue("?status", emp.GetStatus());

        try
        {
            CN.Open();
            Com.ExecuteNonQuery();
        }
        catch (MySqlException)
        {
            throw new Exception(
                "Ocorreu um erro ao conectar com o banco de dados. " +
                "Verifique a conexão e tente novamente."
            );
        }
        finally
        {
            CN.Close();
        }
    }

    public DataTable GetEmprestimos()
    {
        MySqlConnection CN = new MySqlConnection(conexao);
        MySqlCommand cmd = CN.CreateCommand();

        cmd.CommandText = @"SELECT Id, Item, Amigo, Contato, DataEmprestimo, DataDevolucao, DataRetorno, Status
                            FROM Emprestimos
                            ORDER BY Status DESC, DataDevolucao";

        try
        {
            CN.Open();

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            DataTable dtEmprestimos = new DataTable();

            da.Fill(dtEmprestimos);

            return dtEmprestimos;
        }
        catch (MySqlException)
        {
            throw new Exception(
                "Erro ao carregar a lista de empréstimos " +
                "do banco de dados."
            );
        }
        finally
        {
            CN.Close();
        }
    }

    public void MarcarComoDevolvido(int id)
    {
        MySqlConnection CN = new MySqlConnection(conexao);
        MySqlCommand Com = CN.CreateCommand();

        Com.CommandText = @"
        UPDATE Emprestimos
        SET Status = 'Devolvido',
            DataRetorno = ?dataAtual
        WHERE Id = ?id";

        Com.Parameters.AddWithValue(
            "?dataAtual",
            DateTime.Now.Date
        );

        Com.Parameters.AddWithValue("?id", id);

        try
        {
            CN.Open();
            Com.ExecuteNonQuery();
        }
        catch (MySqlException)
        {
            throw new Exception(
                "Erro ao atualizar devolução no banco de dados."
            );
        }
        finally
        {
            CN.Close();
        }
    }

    public void ExcluirEmprestimo(int id)
    {
        MySqlConnection CN = new MySqlConnection(conexao);
        MySqlCommand Com = CN.CreateCommand();

        Com.CommandText = "DELETE FROM Emprestimos WHERE Id = ?id";
        Com.Parameters.AddWithValue("?id", id);

        try
        {
            CN.Open();
            Com.ExecuteNonQuery();
        }
        catch (MySqlException)
        {
            throw new Exception(
                "Erro ao excluir o empréstimo do banco de dados."
            );
        }
        finally
        {
            CN.Close();
        }
    }
}