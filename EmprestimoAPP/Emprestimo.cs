using System;

public class Emprestimo
{
    private int Id;
    private string Item;
    private string Amigo;
    private string Contato;
    private DateTime DataEmprestimo;
    private DateTime DataDevolucao;
    private string Status;

    public Emprestimo(
        string item,
        string amigo,
        string contato,
        DateTime dataEmprestimo,
        DateTime dataDevolucao,
        string status)
    {
        this.Item = item;
        this.Amigo = amigo;
        this.Contato = contato;
        this.DataEmprestimo = dataEmprestimo;
        this.DataDevolucao = dataDevolucao;
        this.Status = status;
    }

    public string GetItem()
    {
        return Item;
    }

    public string GetAmigo()
    {
        return Amigo;
    }

    public string GetContato()
    {
        return Contato;
    }

    public DateTime GetDataEmprestimo()
    {
        return DataEmprestimo;
    }

    public DateTime GetDataDevolucao()
    {
        return DataDevolucao;
    }

    public string GetStatus()
    {
        return Status;
    }
}