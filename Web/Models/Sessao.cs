using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgileTickets.Web.Models
{
    public class Sessao
    {
        public virtual int Id { get; set; }
        public virtual Espetaculo Espetaculo { get; set; }
        public virtual int TotalDeIngressos { get; set; }
        public virtual int IngressosReservados { get; set; }
        public virtual DateTime Inicio { get; set; }

        public virtual bool PodeReservar(int NumeroDeIngressos)
        {
            bool naoTemEspaco = false;
            int sobraram = IngressosDisponiveis - NumeroDeIngressos;
            if(sobraram < 0)
            {
                 naoTemEspaco = true;
            }

            return !naoTemEspaco;
        }

        public virtual int IngressosDisponiveis
        {
            get
            {
                return TotalDeIngressos - IngressosReservados;
            }
        }

        public virtual void Reserva(int quantidade)
        {
            this.IngressosReservados += quantidade;
        }
    }
}
