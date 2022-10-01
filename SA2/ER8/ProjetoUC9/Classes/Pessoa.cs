using ProjetoUC9.Interfaces;

namespace ProjetoUC9.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? Nome { get; set; }

        public float Rendimento { get; set; }

        public Endereco? Endereco { get; set; }

        public abstract float CalcularImposto(float rendimento);
    }
}