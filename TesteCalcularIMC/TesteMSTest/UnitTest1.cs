using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteCalcularIMC;

namespace TesteMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculeIMC()
        {
            //Prepara��o
            double peso = 49;
            double altura = 1.56;
            double rIMC = 20.1;
            //A��o
            var resultado = CalcularIMC.CalculeIMC(peso, altura).ToString("#.#");

            //Verifica��o
            Assert.AreEqual(rIMC, resultado);
        }
       [DataTestMethod]
        public void ClassificarIMC()
        {
            //Arrange
            double rIMC = 20.1;
            string result = "Peso Normal";

            //Act
            var resultado = CalcularIMC.ClassificarIMC(rIMC);

            //Assert
            Assert.AreEqual(result, resultado);
        }
    }
}