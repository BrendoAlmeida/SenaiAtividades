namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Theory]
        [InlineData(40, 1.60, "Abaixo do peso")]
        [InlineData(50, 1.60, "Peso normal")]
        [InlineData(80, 1.70, "Sobrepeso")]
        [InlineData(110, 1.80, "Obesidade grau 1")]
        [InlineData(125, 1.80, "Obesidade grau 2")]
        [InlineData(150, 1.90, "Obesidade grau 3")]
        public void TesteCalculadoraIMC(float peso, float altura, string resultadoEsperado)
        {
            //Act
            var resultado = Calculadora.Calculadora.CalcularIMC(peso, altura);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}