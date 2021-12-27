using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void somaTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 10;
            var contas = new Contas();

            var resultado = contas.soma(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void subtracaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 0;
            var contas = new Contas();

            var resultado = contas.subtracao(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void divisaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 1;
            var contas = new Contas();  

            var resultado = contas.divisao(a,b);

            Assert.AreEqual(esperado, resultado);

        }

        [TestMethod()]
        public void multiplicacaoTest()
        {
            var a = 5;
            var b = 5;
            var esperado = 25;

            var contas = new Contas();

            var resultado = contas.multiplicacao(a,b);

            Assert.AreEqual(esperado , resultado);
        }
    }
}