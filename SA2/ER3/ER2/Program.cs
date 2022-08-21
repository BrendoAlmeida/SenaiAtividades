using ER2.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.Nome = "Brendo";
novaPf.cpf = "121311321321";
novaPf.Rendimento = 6600.5f;

Console.WriteLine(novaPf.Nome);
Console.WriteLine(novaPf.cpf);

Console.WriteLine($"Nome: {novaPf.Nome} \n cpf: {novaPf.cpf}");

Console.WriteLine(novaPf.CalcularImposto(novaPf.Rendimento));


PessoaJuridica novaPj = new PessoaJuridica();
novaPj.Rendimento = 6600.5f;
Console.WriteLine(novaPj.CalcularImposto(novaPj.Rendimento).ToString("C"));

