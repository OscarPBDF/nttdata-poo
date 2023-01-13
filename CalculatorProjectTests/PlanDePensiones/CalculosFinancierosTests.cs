using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject.PlanDePensiones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones.Tests
{
    [TestClass()]
    public class CalculosFinancierosTests
    { 

        [TestMethod()]
        public void totalInversionTest()
        {
            Assert.IsTrue(CalculosFinancieros.totalInversion(1500, 8500) == 10000);
        }

        [DataRow(20000d, 10000d, 0d)]
        [DataRow(30000d, 10000d, 500d)]
        [DataRow(60000d, 10000d, 1000d)]
        [DataTestMethod]
        public void desgravacionAndoTest(double baseImponible, double dineroInvertido, double resultado)
        {
            Assert.IsTrue(CalculosFinancieros.desgravacionAndo(baseImponible, dineroInvertido) == resultado);
        }

        [DataRow(10000d, 10000d, 1900d)]
        [DataRow(20000d, 10000d, 2400d)]
        [DataRow(30000d, 10000d, 3000d)]
        [DataRow(50000d, 10000d, 3700d)]
        [DataRow(100000d, 10000d, 4500d)]
        [DataRow(350000d, 10000d, 4700d)]
        [DataTestMethod]
        public void desgravacionEspaTest(double baseImponible, double dineroInvertido, double resultado)
        {
            Assert.IsTrue(CalculosFinancieros.desgravacionEspa(baseImponible, dineroInvertido) == resultado);
        }
    }
}