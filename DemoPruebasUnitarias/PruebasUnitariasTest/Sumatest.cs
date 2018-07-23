using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoPruebasUnitarias;

namespace PruebasUnitariasTest
{
    [TestClass]
    public class SumaTest
    {
        [TestMethod]
        public void SumaValoresValidos()
        {
            //arrange o planteamiento
            const int sumadoUno = 3;
            const int sumadoDos = 5;
            const int esperado = 8;

            //Act o Prueba
            var actual = Program.Suma(sumadoUno, sumadoDos);

       
            //Asset
            Assert.AreEqual(esperado, actual);


        }
    }
}
