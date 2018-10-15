using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraExtra.Application
{
    public class CalculoHora
    {
        private double _salario;

        public CalculoHora(double salario) => 
            _salario = salario;

        public CalculoHora() =>
            _salario = 3000;

        public double CalculaSalarioHora() =>
            _salario / 220;

        public double CalculaValorHoraExtraNormal() =>
            CalculaSalarioHora() * 1.5;

        public double CalculaValorHoraExtraRemunerada() =>
            CalculaSalarioHora() * 2;

        public double CalculaHoraExtraNormal(double quantidade) =>
            CalculaValorHoraExtraNormal() * quantidade;

        public double CalculaHoraExtraRemunerada(double quantidade) =>
            CalculaValorHoraExtraRemunerada() * quantidade;

    }
}
