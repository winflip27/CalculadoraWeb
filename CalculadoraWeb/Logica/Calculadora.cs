using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraWeb.Logica
{
    public class Calculadora
    {
        public double Sumar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Restar(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero.");
            }
            return num1 / num2;
        }

        public double RaizCuadrada(double num)
        {
            if (num < 0)
            {
                throw new ArgumentException("No se puede calcular la raíz cuadrada de un número negativo.");
            }
            return Math.Sqrt(num);
        }

        public double ExponencialCuadratico(double num)
        {
            return Math.Pow(num, 2); 
        }
    }
}