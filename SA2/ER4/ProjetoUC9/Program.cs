using ProjetoUC9.Classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();


novaPf.Nome = "Brendo";
novaPf.cpf = "121311321321";
novaPf.Rendimento = 6600.5f;
novaPf.dataNasc = new DateTime(2000, 01, 01);

novoEndPf.Logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "Senai";
novoEndPf.endComercial = true;

novaPf.Endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.Nome}
Endereco: {novaPf.Endereco.Logradouro}, {novaPf.Endereco.numero}
Maior de Idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");

// Console.WriteLine(novaPf.Nome);
// Console.WriteLine(novaPf.cpf);

// Console.WriteLine($"Nome: {novaPf.Nome} \n cpf: {novaPf.cpf}");

// Console.WriteLine(novaPf.CalcularImposto(novaPf.Rendimento));


// PessoaJuridica novaPj = new PessoaJuridica();
// novaPj.Rendimento = 6600.5f;
// Console.WriteLine(novaPj.CalcularImposto(novaPj.Rendimento).ToString("C"));

// Console.WriteLine($"{novaPf.ValidarDataNasc(new DateTime(2004,08,28))}");

// Console.WriteLine($"{novaPf.ValidarDataNasc("2004/08/01")}");