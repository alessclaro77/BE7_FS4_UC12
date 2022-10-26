// See https://aka.ms/new-console-template for more information
using BE7_FS4_UC12.Classes;

/*
PessoaFisica novaPF = new PessoaFisica();
Endereco novoEnd = new Endereco();

PessoaFisica metodoPF = new PessoaFisica();

novaPF.nome = "Luiz";
novaPF.dataNascimento = "18/02/1982";
novaPF.cpf = "1234578900";
novaPF.rendimento = 600.0f;

novoEnd.logradouro = "Alameda Barao de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai Informatica";
novoEnd.endComercial = true;

novaPF.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPF.nome}
Endereco: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}
Maior de idade: {metodoPF.validarDataNascimento(novaPF.dataNascimento)}
");
*/

/*
novaPF.nome = "Lozano";
Console.WriteLine(novaPF.nome);
Console.WriteLine("Nome:" + novaPF.nome);
Console.WriteLine($"Nome: {novaPF.nome}");
*/

//Console.WriteLine(novaPF.validarDataNascimento(new DateTime(2000,01,01)));
//Console.WriteLine(novaPF.validarDataNascimento("2010,01,01"));

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "NomePj";
novaPj.cnpj = "00.000.000/0001-00";
novaPj.razaoSocial = "razão Social Pj";
novaPj.rendimento = 8000.5f;
novoEndPj.logradouro = "Alameda Barao de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai Informatica";
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;


Console.WriteLine(@$"
nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj}
CNPJ é Valido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");

