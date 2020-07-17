using System;

namespace Deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular deducciones salariales y su salario anual.
            Console.WriteLine("Programa para calcular deducciones salariales y su salario anual.
            // Entrada de salario mensual y su tipo de contrato.
            Console.WriteLine("Ingrese su salario mensual: ");
            double sm = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato" + "Digite 1: Dependiente. / Digite 2: Independiente.");
            int tc = int.Parse(Console.ReadLine());
            // Calculo de deducciones
            double pr = 0, pen = 0, eps = 0, arl = 0, srm = 0, sa = 0;
            double bc = sm * 0.40;
            double smmlv = 877803;
            if (bc < smmlv) bc = smmlv;
            if (tc == 1) {
                pen = bc * 0.04;
                eps = pen;
                srm = sm - pen - eps;
                sa = srm * 12 + sm;
            }
            if (tc == 2){
                // Si y solo si es tipo de contrato independiente se debe de ingresar un numero del 1 al 5 que representa el porcentaje de riesgo.
                Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo: ");
                int cr = int.Parse(Console.ReadLine());
                if (cr == 1) pr = 0.00522;
                else if (cr == 2) pr = 0.01044;
                else if (cr == 3) pr = 0.02436;
                else if (cr == 4) pr = 0.04350;
                else if (cr == 5) pr = 0.0696;
                eps = bc * 0.125;
                arl = bc * pr;
                srm = sm - pen - eps - arl;
                sa = srm * 12;
            }
            Console.WriteLine("El calculo de deduccion de la Pension es: " + pen);
            Console.WriteLine("El calculo de deduccion de la EPS es: " + eps);
            Console.WriteLine("El calculo de deduccion de el ARL es: " + arl);
            Console.WriteLine("El salario real mensual es: " + srm);
            Console.WriteLine("El salario anualcon deducciones es: " + sa);
        }
    }
}
