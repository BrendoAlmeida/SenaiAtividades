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

Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.razaoSocial}
cnpj: {novaPj.cnpj} = Valido: {novaPj.ValidarCnpj(novaPj.cnpj)} 
Rendimento: {novaPj.Rendimento}
");



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