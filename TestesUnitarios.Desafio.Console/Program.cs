// See https://aka.ms/new-console-template for more information
using TestesUnitarios.Desafio.Console.Services;

Console.WriteLine("Hello, World!");

List<int> Lista = new List<int>();

Lista.Add (1);
Lista.Add (3);
Lista.Add (5);

ValidacoesLista Validacoes = new ValidacoesLista();

List<int> ListaMultiplicada=Validacoes.MultiplicarNumerosLista(Lista, 5);

Console.WriteLine(ListaMultiplicada);
