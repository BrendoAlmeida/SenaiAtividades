namespace Calculadora
{
    public static class Calculadora
    {
        public static string CalcularIMC(float peso, float altura)
        {
            double resultado = peso / (altura * altura);

            if (resultado < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (resultado <= 24.9)
            {
                return "Peso normal";
            }
            else if (resultado <= 29.9)
            {
                return "Sobrepeso";
            }
            else if (resultado <= 34.9)
            {
                return "Obesidade grau 1";
            }
            else if (resultado <= 39.9)
            {
                return "Obesidade grau 2";
            }
            else
            {
                return "Obesidade grau 3";
            }
        }
    }
}