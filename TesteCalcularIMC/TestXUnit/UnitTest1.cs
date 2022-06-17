using TesteCalcularIMC;
using Xunit;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(49.0, 1.56, 20.13)]
        [InlineData(80.0, 1.50, 35.56)]
        [InlineData(111.0, 1.63, 41.78)]
        [InlineData(88.0, 1.70, 30.45)]
        [InlineData(80.0, 1.72, 27.04 )]
        [InlineData(41.0, 1.50, 18.22)]

        public void CalcularIMCLista(double peso, double altura, double imc)
        {
            //act 
            var resultado = IMC.CalcularIMC(peso, altura);
            Assert.Equal (imc, resultado);

        }

        [Theory]
        [InlineData(20.13, "Peso Normal")]
        [InlineData(35.56, "Obesidade Grau II")]
        [InlineData(41.78, "Obesidade Grau III")]
        [InlineData(30.45, "Obesidade Grau I")]
        [InlineData(27.04, "Sobrepeso")]
        [InlineData(18.22, "Abaixo do normal")]

        public void ClassificarIMCLista(double imc, string classificacao)
        {
            var resultado = IMC.ClassificarIMC(imc);

            Assert.Equal(classificacao, resultado);
        }
    }

}