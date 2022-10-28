// See https://aka.ms/new-console-template for more information
using BE7_FS4_UC12.Classes;

Console.WriteLine(@$"
******************************************************************
*               BEM VINDO AO SISTEMA DE CADASTRO DE              *
*                   PESSOAS FÍSICAS E JURÍDICAS                  *
*                                                                *
******************************************************************
");
//código comentado evitar repetição - criado método estático
/*
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.DarkMagenta;

Console.Write("Carregando  ");

for (var contador = 0; contador < 34; contador++)
{
    Console.Write(".  ");
    Thread.Sleep(200);
}

Console.ResetColor();
*/

BarraCarregamento("Carregando", 100);

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
******************************************************************
*               Escolha uma das opções a segui:                  *
__________________________________________________________________
*                                                                *
*                      1 - Pessoa Física                         *
*                      2 - Pessoa Jurídica                       *
*                      0 - Sair                                  *
*                                                                *
******************************************************************
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
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
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;
        case "2":
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
            Console.WriteLine($"Aperte ENTER para continuar");
            Console.ReadLine();
            break;
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");
            //código comentado evitar repetição - criado método estático
            /*
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"Finalizando");

            for (var contador = 0; contador < 34; contador++)
            {
                Console.Write(".  ");
                Thread.Sleep(100);
            }
            Console.ResetColor();
            break;
        default:
            Console.Clear();
            Console.WriteLine($"opção invalida, por favor digitar outra opção");
            Thread.Sleep(3000);
            */
            BarraCarregamento("Finalizando", 200);
            break;
    }
} while (opcao != "0");

//método estático
static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.Write($"{texto}");

    for (var contador = 0; contador < 34; contador++)
    {
        Console.Write(".  ");
        Thread.Sleep(tempo);
    }
    Console.ResetColor();

}

