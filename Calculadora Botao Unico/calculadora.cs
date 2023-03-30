using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Botao_Unico
{
    internal class Calculadora
    {
        public double valor1 { get; set; }
        public double valor2 { get; set;}
        public double somar(double valor1, double valor2) { return valor1 + valor2; }
        public double subtrair(double valor1, double valor2) {  return valor1 - valor2; }
        public double divisao(double valor1, double valor2) { return valor1 / valor2; }
        public double multiplicacao (double valor1, double valor2) { return valor1 * valor2; }
    }
}
