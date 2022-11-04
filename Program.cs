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

List<PessoaFisica> listaPF = new List<PessoaFisica>();

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
            PessoaFisica metodoPF = new PessoaFisica();
            
            string? opcaoPF;
            
            do
            {
                    Console.Clear();
                    Console.WriteLine(@$"
******************************************************************
*               Escolha uma das opções a segui:                  *
__________________________________________________________________
*                                                                *
*                      1 - Cadastrar Pessoa Física               *
*                      2 - Mostrar pessoa Física                 *
*                      0 - Sair                                  *
*                                                                *
******************************************************************
");
                opcaoPF = Console.ReadLine();

                switch (opcaoPF)
                {
                    case "1":
                        PessoaFisica novaPF = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa que deseja cadastrar.");
                        novaPF.nome = Console.ReadLine();

                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex.: DD/MM/AA");
                            string dataNasc = Console.ReadLine();
                            
                            dataValida = metodoPF.validarDataNascimento(dataNasc);

                            if (dataValida){
                                novaPF.dataNascimento = dataNasc;
                            }
                            else{
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data digitada é invalida, por favor digitar uma data valida.");
                                Console.ResetColor();
                            }
                        } while (dataValida == false);                      
                

                        Console.WriteLine($"Digite o número do CPF: ");
                        novaPF.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (Apenas números): ");
                        novaPF.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro: ");
                        novoEnd.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o Número: ");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o Complemento (Aperte ENTER para vazio): ");
                        novoEnd.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S"){
                            novoEnd.endComercial = true;
                        }
                        else{
                            novoEnd.endComercial = false;
                        }

                        novaPF.endereco = novoEnd;
                        listaPF.Add(novaPF);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!!");
                        Thread.Sleep(4000);
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.Clear();
                        if (listaPF.Count > 0){
                            foreach (PessoaFisica cadaPessoa in listaPF)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                                    Nome: {cadaPessoa.nome}
                                    Endereco: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                                    Data de nascimento: {cadaPessoa.dataNascimento}
                                    Taxa de Imposto a Ser Pago: {metodoPF.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                                ");
                                Console.WriteLine($"Aperte ENTER para continuar");
                                Console.ReadLine();  
                            }
                        }
                        else{
                            Console.WriteLine($"Lista vazia!!!");
                            Thread.Sleep(3000);
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção invalida, por favor digite outra opção. ");
                        Thread.Sleep(2000);
                        break;
                }
                
            } while (opcaoPF != "0");

           
            break;
        case "2":
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();
            novaPj.nome = "NomePj";
            novaPj.cnpj = "00.000.000/0001-00";
            novaPj.razaoSocial = "razão Social Pj";
            novaPj.rendimento = 5000.0f;
            novoEndPj.logradouro = "Alameda Barao de Limeira";
            novoEndPj.numero = 539;
            novoEndPj.complemento = "Senai Informatica";
            novoEndPj.endComercial = true;
            novaPj.endereco = novoEndPj;
            Console.WriteLine(@$"
                nome: {novaPj.nome}
                Razão Social: {novaPj.razaoSocial}
                CNPJ: {novaPj.cnpj}
                CNPJ é Valido: {(metodoPj.ValidarCnpj(novaPj.cnpj)? "Sim": "Não")}
                Taxa de Imposto a Ser Pago: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
                ");
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

