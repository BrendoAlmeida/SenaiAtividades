namespace TesteXUnit
{
    public class TesteCalcXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange
            var pNum = 1;
            var sNum = 2;
            var resultadoEsperado = 3;

            //Act
            var resultado = Calculadora.Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2, 5)]
        [InlineData(4, 2, 6)]
        [InlineData(5, 2, 7)]
        public void TesteSomaDoisNumerosComInlineData(double pNum, double sNum, double resultadoEsperado)
        {
            //Act
            var resultado = Calculadora.Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}