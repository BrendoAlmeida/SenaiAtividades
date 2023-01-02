namespace TesteMSTeste
{
    [TestClass]
    public class TesteCalcMSTeste
    {
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 5)]
        [DataRow(4, 2, 6)]
        [DataRow(5, 2, 7)]
        public void TesteSomaDoisNumerosComDataTestMethod(double pNum, double sNum, double resultadoEsperado)
        {
            //Act
            var resultado = Calculadora.Calculadora.Somar(pNum, sNum);

            //Assert
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}