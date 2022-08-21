using ER2.Interfaces;

namespace ER2.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime dataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }else if (rendimento <= 3500)
            {
                return rendimento * .02f;
            }else if (rendimento <= 6000)
            {
                return rendimento * .035f;
            }else
            {
                return rendimento * .05f;                
            }
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}