// See https://aka.ms/new-console-template for more information
using BE7_FS4_UC12.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Lozano";

Console.WriteLine(novaPF.nome);
Console.WriteLine("Nome:" + novaPF.nome);
Console.WriteLine($"Nome: {novaPF.nome}");
