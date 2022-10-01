using System.Text.RegularExpressions;
using ProjetoUC9.Interfaces;

namespace ProjetoUC9.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }

        public string? razaoSocial { get; set; }

        public string path { get; private set; } = "Database/PessoaJuridica.csv";

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return rendimento * .03f;
            }else if (rendimento <= 6000)
            {
                return rendimento * .05f;
            }else if (rendimento <= 10000)
            {
                return rendimento * .07f;
            }else
            {
                return rendimento * .09f;                
            }
        }

        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj, @"^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$"))
            {
                if (cnpj.Substring(8, 4) == "0001" || cnpj.Substring(11,4) == "0001")
                {
                    return true;
                }
            }

            return false;
        }

        public void Inserir(PessoaJuridica Pj)
        {
            Ultils.VerificarPastaArquivo(path);

            string[] pjValores = { $"{Pj.Nome},{Pj.cnpj},{Pj.razaoSocial}" };

            File.AppendAllLines(path, pjValores);
        }

        public List<PessoaJuridica> LerArquivo()
        {
            List<PessoaJuridica> listaPj = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(path);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica novaPj = new PessoaJuridica();

                novaPj.Nome = atributos[0];
                novaPj.cnpj = atributos[1];
                novaPj.razaoSocial = atributos[2];

                listaPj.Add(novaPj);
            }

            return listaPj;
        }
    }
}