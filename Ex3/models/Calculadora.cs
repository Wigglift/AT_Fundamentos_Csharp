using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3.models
{
    public class Calculadora
    {
        public static double Soma(double a, double b)
        {
            return a + b;
        }
        
        public static double Subtracao(double a, double b)
        {
            return a - b;
        }

        public static double Multiplicacao(double a, double b)
        {
            return a * b;
        }

        //Caso o usuário tente dividir por 0 jogaremos um erro de divisão por zero
        public static double Divisao(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return a / b;
        }
    }
}
