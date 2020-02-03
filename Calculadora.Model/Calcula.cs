using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Model
{
    public class Calcula
    {
        private Decimal _Valor1;
        private Decimal _Valor2;

        public Decimal Valor1
        {
            get { return _Valor1; }
            set { _Valor1 = value; }
        }
        public Decimal Valor2
        {
            get { return _Valor2; }
            set { _Valor2 = value; }
        }

        /*Metodos*/

        public Decimal Soma()
        {
            return _Valor1 + _Valor2;
        }
        public Decimal Subtracao()
        {
            return _Valor1 - _Valor2;
        }
        public Decimal Divisao()
        {
            return _Valor1 / _Valor2;
        }
        public Decimal Multiplicacao()
        {
            return _Valor1 * _Valor2;
        }
    }
}