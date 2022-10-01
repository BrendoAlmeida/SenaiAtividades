using ProjetoUC9.Interfaces;

namespace ProjetoUC9.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public string path { get; private set; } = "Database/PessoaFisica.csv";

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento <= 3500)
            {
                return rendimento * .02f;
            }
            else if (rendimento <= 6000)
            {
                return rendimento * .035f;
            }
            else
            {
                return rendimento * .05f;
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime DataAtual = DateTime.Today;

            double anos = (DataAtual - dataNasc).TotalDays / 365;

            if (anos >= 18)
            {
                return true;
            }

            return false;
        }

        public bool ValidarDataNasc(string dataNasc)
        {
            if (DateTime.TryParse(dataNasc, out DateTime dataCovertida))
            {
                if ((DateTime.Today - dataCovertida).TotalDays / 365 >= 18)
                {
                    return true;
                }
            }

            return false;
        }

        public void Inserir(PessoaFisica Pf)
        {
            Ultils.VerificarPastaArquivo(path);

            string[] pfValores = { $"{Pf.Nome},{Pf.cpf},{Pf.dataNasc}" };

            File.AppendAllLines(path, pfValores);
        }

        public List<PessoaFisica> LerArquivo()
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();

            string[] linhas = File.ReadAllLines(path);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaFisica novaPf = new PessoaFisica();

                novaPf.Nome = atributos[0];
                novaPf.cpf = atributos[1];
                novaPf.dataNasc = Convert.ToDateTime(atributos[2]);

                listaPf.Add(novaPf);
            }

            return listaPf;
        }
    }
}