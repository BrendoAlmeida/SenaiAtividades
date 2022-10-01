using ProjetoUC9.Classes;

#region novaPf

// PessoaFisica novaPf = new PessoaFisica();
// Endereco novoEndPf = new Endereco();

// novaPf.Nome = "Brendo";
// novaPf.cpf = "121311321321";
// novaPf.Rendimento = 6600.5f;
// novaPf.dataNasc = new DateTime(2000, 01, 01);

// novoEndPf.Logradouro = "Rua Niteroi";
// novoEndPf.numero = 180;
// novoEndPf.complemento = "Senai";
// novoEndPf.endComercial = true;

// novaPf.Endereco = novoEndPf;

// Console.WriteLine(@$"
// Nome: {novaPf.Nome}
// Endereco: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.numero}
// Maior de Idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
// ");

// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.cpf);

// Console.WriteLine($"Nome: {novaPf.Nome} \n cpf: {novaPf.cpf}");

// Console.WriteLine(novaPf.CalcularImposto(novaPf.Rendimento));

#endregion


#region novaPj

// PessoaJuridica novaPj = new PessoaJuridica();
// Endereco novoEndPj = new Endereco();

// novaPj.Nome = "Nome Pj";
// novaPj.razaoSocial = "Razão Social";
// novaPj.cnpj = "43.392.921/0001-50";
// novaPj.Rendimento = 6000.5f;

// novoEndPj.Logradouro = "Rua Niteroi";
// novoEndPj.numero = 180;
// novoEndPj.complemento = "Senai informatica";

// novaPj.Endereco = novoEndPj;

// Console.WriteLine(@$"
// Nome: {novaPj.Nome}
// Razão Social: {novaPj.razaoSocial}
// cnpj: {novaPj.cnpj} = Valido: {novaPj.ValidarCnpj(novaPj.cnpj)} 
// Rendimento: {novaPj.Rendimento}
// ");



// Console.WriteLine(novaPj.ValidarCnpj("83.562.056/0001-67"));

// Console.WriteLine(novaPj.CalcularImposto(novaPj.Rendimento).ToString("C"));

// Console.WriteLine($"{novaPf.ValidarDataNasc(new DateTime(2004,08,28))}");

// Console.WriteLine($"{novaPf.ValidarDataNasc("2004/08/01")}");

#endregion


#region extra

// string inverterPalavra(string palavra)
// {
//     for (int i = palavra.Length; i > 1; i--)
//     {
//         palavra = palavra.Insert(i, palavra.Substring(0, 1)).Remove(0, 1);
//     }
//     return palavra;
// };

// Console.WriteLine(inverterPalavra("palavra")); //arvalap

#endregion



List<PessoaFisica> listPf = new List<PessoaFisica>();
PessoaFisica metodospf = new PessoaFisica();
PessoaJuridica metodospj = new PessoaJuridica();

#region Menu

Console.Clear();

Console.WriteLine(@$"
============================================
|   Bem vindo ao sistema de cadastro de    |
|       Pessoas Físicas e juridicas        |
============================================
");

Ultils.BarraCarregamento("Carregando");

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
    =====================================
    |   Escolha uma das opçoes abaixo   |
    |-----------------------------------|
    |       1 - Pessoa Física           |
    |       2 - Pessoa Juridica         |
    |                                   |
    |       0 - Sair                    |
    =====================================");

    opcao = Console.ReadLine();

    Console.Clear();

    switch (opcao)
    {
        case "1":

            string? opcaopf;
            Console.Clear();
            Console.WriteLine(@$"
    =====================================
    |   Escolha uma das opçoes abaixo   |
    |-----------------------------------|
    |    1 - Cadastrar Pessoa Física    |
    |    2 - Listar Pessoa Física       |
    |                                   |
    |    0 - Voltar                     |
    =====================================");
            opcaopf = Console.ReadLine();

            switch (opcaopf)
            {
                case "1":
                    PessoaFisica novaPf = new PessoaFisica();
                    Endereco novoEndPf = new Endereco();

                    Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar: ");
                    novaPf.Nome = Console.ReadLine();

                    bool dataValida;
                    do
                    {
                        Console.WriteLine($"Digite a data de nescimento (DD/MM/AAAA): ");
                        string? dataNascimento = Console.ReadLine();

                        dataValida = novaPf.ValidarDataNasc(dataNascimento);

                        if (dataValida)
                        {
                            DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                            novaPf.dataNasc = dataConvertida;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine($"Data inválida, por favor digite novamente");
                            Console.ResetColor();
                            Thread.Sleep(3000);
                        }
                    } while (!dataValida);

                    Console.WriteLine($"Digite o número do CPF");
                    novaPf.cpf = Console.ReadLine();

                    Console.WriteLine($"Digite o rendimento mensal (somente números):");
                    novaPf.Rendimento = float.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o logradouro:");
                    novoEndPf.Logradouro = Console.ReadLine();

                    Console.WriteLine($"Digite o número");
                    novoEndPf.numero = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Digite o complemento (Aperte ENTER para vazio):");
                    novoEndPf.complemento = Console.ReadLine();

                    Console.WriteLine($"Este endereço é comercial? S/N");
                    string? endCom = Console.ReadLine().ToUpper();

                    if (endCom == "S") novoEndPf.endComercial = true; else novoEndPf.endComercial = false;

                    novaPf.Endereco = novoEndPf;

                    metodospf.Inserir(novaPf);

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"O cadastro foi realizado com sucesso!");
                    Console.ResetColor();
                    Thread.Sleep(3000);

                    break;

                case "2":
                    Console.Clear();

                    List<PessoaFisica> listaExibicaoPf = metodospf.LerArquivo();

                    foreach (PessoaFisica cadaItem in listaExibicaoPf)
                    {
                        Console.WriteLine(@$"
Nome: {cadaItem.Nome},
Cpf: {cadaItem.cpf},
Data de nascimento: {cadaItem.dataNasc}
                        ");

                    }

                    Console.WriteLine($"Aperte ENTER para continuar");
                    Console.ReadLine();

                    break;

                case "0":
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Opção inválida!!");
                    Console.ResetColor();
                    Thread.Sleep(3000);
                    break;
            }













            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome Pj";
            novaPj.razaoSocial = "Razão Social";
            novaPj.cnpj = "43.392.921/0001-50";
            novaPj.Rendimento = 6000.5f;

            novoEndPj.Logradouro = "Rua Niteroi";
            novoEndPj.numero = 180;
            novoEndPj.complemento = "Senai informatica";

            novaPj.Endereco = novoEndPj;

            metodospj.Inserir(novaPj);

            List<PessoaJuridica> listaExibicaoPj = metodospj.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaExibicaoPj)
            {
                Console.WriteLine(@$"
Nome: {cadaItem.Nome}
Razão Social: {cadaItem.razaoSocial}
cnpj: {cadaItem.cnpj} = Valido: {(cadaItem.ValidarCnpj(cadaItem.cnpj) ? "Sim" : "Não")} 
Rendimento: {cadaItem.Rendimento}
            ");
            }


            Console.WriteLine("Aperte 'ENTER' para continuar");
            Console.ReadLine();

            break;

        case "0":
            Console.WriteLine($"Obrogado por utilizar nosso sistema!");

            Ultils.BarraCarregamento("Finalizando");

            break;

        default:
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção inválida!!");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }
} while (opcao != "0");





#endregion