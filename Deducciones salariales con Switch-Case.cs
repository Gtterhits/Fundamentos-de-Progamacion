using System;

namespace Deducciones_salariales_con_Switch_Case
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
            double procenRiesgo = 0, pension = 0, eps = 0, arl = 0, salarioReal = 0, salarioAnual = 0, deducciones = 0;
            double ibc = salarioMensual * 0.40;
            double smmlv = 877803;

            if (ibc < smmlv) ibc = smmlv;
            switch (tipoContrato)
            {
                case 1:
                    pension = ibc * 0.04;
                    eps = pension;
                    deducciones = pension + eps;
                    salarioReal = salarioMensual - deducciones;
                    salarioAnual = salarioReal * 12 + salarioMensual; 
                    break;
                case 2:
                    Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo: ");
                    int claseRiesgo = int.Parse(Console.ReadLine());
                    switch (claseRiesgo) {
                        case 1: procenRiesgo = 0.00522; break;
                        case 2: procenRiesgo = 0.01044; break;
                        case 3: procenRiesgo = 0.02436; break;
                        case 4: procenRiesgo = 0.04350; break;
                        case 5: procenRiesgo = 0.0696; break;
                    }
                    pension = ibc * 0.16;
                    eps = ibc * 0.125;
                    arl = ibc * procenRiesgo;
                    deducciones = pension + eps + arl;
                    salarioReal = salarioMensual - deducciones;
                    salarioAnual = salarioReal * 12; 
                    break;
            }
            Console.WriteLine("El calculo de deduccion de la Pension es: " + pension);
            Console.WriteLine("El calculo de deduccion de la EPS es: " + eps);
            Console.WriteLine("El calculo de deduccion de el ARL es: " + arl);
            Console.WriteLine("El calculo del valor total de deducciones: " + deducciones);
            Console.WriteLine("El salario real mensual es: " + salarioReal);
            Console.WriteLine("El salario anualcon deducciones es: " + salarioAnual);
            Console.WriteLine("...Fin del programa...");
        }
    }
}
