using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AgileTickets.Web.Models;

namespace Tests
{
    [TestFixture]
    public class SessaoTest
    {
        [Test]
        public void DeveReservarQuantidadeDesejada()
        {
            int quantidade = 1;

            Sessao objSessao = new Sessao();
            objSessao.TotalDeIngressos = 10;
            objSessao.IngressosReservados = 9;
            bool resultado = objSessao.PodeReservar(quantidade);

            Assert.IsTrue(resultado);
        }
    }
}
