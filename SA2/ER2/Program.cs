using ER2.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.Nome = "Brendo";
novaPf.cpf = "121311321321";


Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.cpf);

Console.WriteLine($"Nome: {novaPf.Nome} \n cpf: {novaPf.cpf}");