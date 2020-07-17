using System;

namespace Deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular deducciones salariales y su salario anual.
            Console.WriteLine("Programa para calcular deducciones salariales, salario real y salario anual.");
            // Entrada de salario mensual y su tipo de contrato.
            Console.WriteLine("Ingrese su salario mensual: ");
            double salarioMensual = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato" + "Digite 1: Dependiente. / Digite 2: Independiente.");
            int tipoContrato = int.Parse(Console.ReadLine());
            // Calculo de deducciones
            double procenRiesgo = 0, pension = 0, eps = 0, arl = 0, salarioReal = 0, salarioAnual = 0;
            double ibc = salarioMensual * 0.40;
            double smmlv = 877803;
            if (ibc < smmlv) ibc = smmlv;
            if (tipoContrato == 1) {
                pension = ibc * 0.04;
                eps = pension;
                salarioReal = salarioMensual - pension - eps;
                salarioAnual = salarioReal * 12 + salarioMensual;
            }
            if (tipoContrato == 2){
                // Si y solo si es tipo de contrato independiente se debe de ingresar un numero del 1 al 5 que representa el porcentaje de riesgo.
                Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo: ");
                int cr = int.Parse(Console.ReadLine());
                if (cr == 1) procenRiesgo = 0.00522;
                else if (cr == 2) procenRiesgo = 0.01044;
                else if (cr == 3) procenRiesgo = 0.02436;
                else if (cr == 4) procenRiesgo = 0.04350;
                else if (cr == 5) procenRiesgo = 0.0696;
                eps = ibc * 0.125;
                arl = ibc * procenRiesgo;
                salarioReal = salarioMensual - pension - eps - arl;
                salarioAnual = salarioReal * 12;
            }
            Console.WriteLine("El calculo de deduccion de la Pension es: " + pension);
            Console.WriteLine("El calculo de deduccion de la EPS es: " + eps);
            Console.WriteLine("El calculo de deduccion de el ARL es: " + arl);
            Console.WriteLine("El salario real mensual es: " + salarioReal);
            Console.WriteLine("El salario anualcon deducciones es: " + salarioAnual);
            Console.WriteLine("...Fin del programa...");
        }
    }
}
