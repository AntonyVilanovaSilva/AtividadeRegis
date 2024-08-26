using Atividade_de_Reginaldo.Enum;
using Atividade_de_Reginaldo.Models;
using System;
using System.Collections.Generic;


// Uso do sistema de monitoramento de vencimento sem Observer
class Program
{
    static void Main(string[] args)
    {
        // Criando produtos
        Produto leite = new Produto(1, "Leite", new DateTime(2024, 8, 20));
        Produto iogurte = new Produto(2, "Iogurte", new DateTime(2024, 8, 22));
        Produto queijo = new Produto(3, "Queijo", new DateTime(2024, 8, 19));

        // Criando o almoxarifado
        Almoxarifado almoxarifado = new Almoxarifado();

        // Adicionando produtos ao almoxarifado
        almoxarifado.AdicionarProduto(leite);
        almoxarifado.AdicionarProduto(iogurte);
        almoxarifado.AdicionarProduto(queijo);

        // Criando funcionários
        Funcionario gerente1 = new Funcionario(1, "Ana", TipoFuncionario.Gerente);
        //Funcionario gerente2 = new Funcionario(2, "João", TipoFuncionario.Gerente);
        Funcionario supervisor = new Funcionario(3, "Carlos", TipoFuncionario.Supervisor);
        Funcionario operador = new Funcionario(4, "Mariana", TipoFuncionario.Operador);

        // Registrando observadores (gerentes)
        almoxarifado.Add(gerente1);
        //almoxarifado.Add(gerente2);

        // Verificando produtos vencidos com a data atual
        DateTime dataAtual = DateTime.Now;
        almoxarifado.VerificarProdutosVencidos(dataAtual);
    }

}