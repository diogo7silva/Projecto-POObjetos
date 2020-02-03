using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Model;

namespace Calculadora.Control
{
    public class CCalculadora
    {
        Calcula oCalcula = new Calcula();
        public Decimal Soma(Decimal Valor1, Decimal Valor2)
        {
            oCalcula.Valor1 = Valor1;
            oCalcula.Valor2 = Valor2;
            return oCalcula.Soma();
        }
        public Decimal Subtrai(Decimal Valor1, Decimal Valor2)
        {
            oCalcula.Valor1 = Valor1;
            oCalcula.Valor2 = Valor2;
            return oCalcula.Subtracao();
        }
        public Decimal Divide(Decimal Valor1, Decimal Valor2)
        {
            oCalcula.Valor1 = Valor1;
            oCalcula.Valor2 = Valor2;
            return oCalcula.Divisao();
        }
        public Decimal Mulitiplica(Decimal Valor1, Decimal Valor2)
        {
            oCalcula.Valor1 = Valor1;
            oCalcula.Valor2 = Valor2;
            return oCalcula.Multiplicacao();
        }
    }
}