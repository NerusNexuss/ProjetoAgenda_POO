using System;

public class Cliente
{
    string Nome;
    float Rg;
    float Cpf;
    string Descricao;
    string Endereco;
    float Telefone;
    float Celular;
    string Ativo;
    public Cliente(string nome, float rg, float cpf, string descricao, string endereco, float telefone, float celular, string ativo)
    {
        Nome = nome;
        Rg = rg;
        Cpf = cpf;
        Descricao = descricao;
        Endereco = endereco;
        Telefone = telefone;
        Celular = celular;
        Ativo = ativo;
    }
}