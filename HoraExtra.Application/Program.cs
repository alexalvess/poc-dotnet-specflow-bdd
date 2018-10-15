using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoraExtra.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double quantidadeHorasExtra = 0;
            double quantidadeHorasExtraRemunerada = 0;

            Console.Write("Valor do salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Horas extras trabalhadas em domingos e/ou feriados: ");
            quantidadeHorasExtra = Convert.ToDouble(Console.ReadLine());

            Console.Write("Horas extras trabalhadas em dias normais: ");
            quantidadeHorasExtraRemunerada = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("-----------------------");

            var calculoHoraExtra = new CalculoHora(salario);

            Console.WriteLine($"Valor por hora: {calculoHoraExtra.CalculaSalarioHora().ToString("C2")}");
            Console.WriteLine($"Valor por hora extra: {calculoHoraExtra.CalculaValorHoraExtraNormal().ToString("C2")}");
            Console.WriteLine($"Valor por hora extra remunerada: {calculoHoraExtra.CalculaValorHoraExtraRemunerada().ToString("C2")}");

            Console.WriteLine("-----------------------");

            var horaExtraNormal = calculoHoraExtra.CalculaHoraExtraNormal(quantidadeHorasExtra);
            var horaExtraRemunerada = calculoHoraExtra.CalculaHoraExtraRemunerada(quantidadeHorasExtraRemunerada);

            Console.WriteLine($"Total de horas extras normais: {horaExtraNormal.ToString("C2")}");
            Console.WriteLine($"Total de horas extras remuneradas: {horaExtraRemunerada.ToString("C2")}");
            Console.WriteLine($"Total de horas extras: {(horaExtraNormal + horaExtraRemunerada).ToString("C2")}");

            Console.ReadKey();
        }
    }
}
