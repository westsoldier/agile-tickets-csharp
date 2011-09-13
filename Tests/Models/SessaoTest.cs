using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using AgileTickets.Web.Models;

namespace Tests.Models
{
    [TestFixture]
    public class SessaoTest
    {
        private Sessao sessao;

        [SetUp]
        public void inicializa()
        {
            sessao = new Sessao();
        }

        [Test]
        public void DeveVender1IngressoSeHa2Vagas()
        {
            sessao.TotalDeIngressos = 2;

            Assert.IsTrue(sessao.PodeReservar(1));
        }

        [Test]
        public void NaodeveVender3IngressoSeHa2Vagas()
        {
            sessao.TotalDeIngressos = 2;

            Assert.IsFalse(sessao.PodeReservar(3));
        }

        [Test]
        public void ReservarIngressosDeveDiminuirONumeroDeIngressosDisponiveis()
        {
            sessao.TotalDeIngressos = 5;

            sessao.Reserva(3);
            Assert.AreEqual(2, sessao.IngressosDisponiveis);
        }
        [Test]
        public void DeveReservarQuantidadeDesejada()
        {
            int quantidade = 1;

            sessao.TotalDeIngressos = 10;
            sessao.IngressosReservados = 9;
            bool resultado = sessao.PodeReservar(quantidade);

            Assert.IsTrue(resultado);
        }

        [Test]
        public void DeveReservarQuantidadeDesejadaComCemDeNoventa()
        {
            sessao.TotalDeIngressos = 90;
            Assert.IsFalse(sessao.PodeReservar(100));
        }
    }
}
