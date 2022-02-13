using System;
using Interfaces;

namespace Models
{
    class Calculadora : ICalculadora
    {
        public int Dividir(int n1, int n2)
        {
            return n1/n2;
        }

        public int Multipliar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
