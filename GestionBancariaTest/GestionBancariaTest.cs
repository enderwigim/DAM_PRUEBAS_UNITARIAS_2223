using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GestionBancariaTest
{
    [TestClass]
    public class GestionBancariaTest
    {
        [TestMethod]
        public void ValidarMetodoIngreso()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = 500;
            double saldoActual = 0;
            double saldoEsperado = 1500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodoIngresoNegativo()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double ingreso = -500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarIngreso(ingreso);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();
            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");

            
        }
        [TestMethod]
        public void ValidarMetodoReIntegro()
        {
            // preparación del caso de prueba
            double saldoInicial = 1000;
            double retiro = 500;
            double saldoActual = 0;
            double saldoEsperado = 500;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retiro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodoReIntegroSaldoInsuf()
        {
            // preparación del caso de prueba
            double saldoInicial = 250;
            double retiro = 500;
            double saldoActual = 0;
            double saldoEsperado = -250;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retiro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ValidarMetodoReIntegroCantidadNeg()
        {
            // preparación del caso de prueba
            double saldoInicial = 250;
            double retiro = -500;
            double saldoActual = 0;
            double saldoEsperado = -250;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);

            // Método a probar
            cuenta.realizarReintegro(retiro);

            // afirmación de la prueba (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
    
}
