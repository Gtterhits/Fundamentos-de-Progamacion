using System;

namespace Deducciones_salariales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa para calcular deducciones salariales y su salario anual.
            Console.WriteLine("Programa para calcular deducciones salariales y su salario anual.");

            // Entrada de salario mensual y su tipo de contrato.
            Console.WriteLine("Ingrese su salario mensual: ");
            double sm = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato" + "Digite 1: Dependiente. / Digite 2: Independiente.");
            int tc = int.Parse(Console.ReadLine());

            // Si y solo si es tipo de contrato independiente se debe de ingresar un numero del 1 al 5 que representa el porcentaje de riesgo.
            double pr = 0;
            if (tc == 2)
            {
                Console.WriteLine("Ingrese un número de 1 a 5 equivalente a la clase del riesgo: ");
                int cr = int.Parse(Console.ReadLine());
                if (cr == 1)
                {
                    pr = 0.00522;
                }
                else if (cr == 2)
                {
                    pr = 0.01044;
                }
                else if (cr == 3)
                {
                    pr = 0.02436;
                }
                else if (cr == 4)
                {
                    pr = 0.04350;
                }
                else if (cr == 5)
                {
                    pr = 0.0696;
                }
            }
            // Calculo de deducciones
            double bc = sm * 0.40;
            double smmlv = 877803;
            if (bc < smmlv){
                bc = smmlv;
            }
            if (tc == 1) {
                double pen = bc * 0.04;
                Console.WriteLine("El calculo de deduccion de la Pension es: " + pen);
                double eps = pen;
                Console.WriteLine("El calculo de deduccion de la EPS es: " + eps);
                double srm = sm - pen - eps;
                Console.WriteLine("El salario real mensual es: " + srm);
                double sa = srm * 12 + sm;
                Console.WriteLine("El salario anual con deducciones y prima es: " + sa);
            }
            if (tc == 2){
                double pen = bc * 0.16;
                Console.WriteLine("El calculo de deduccion de la Pension es: " + pen);
                double eps = bc * 0.125;
                Console.WriteLine("El calculo de deduccion de la EPS es: " + eps);
                double arl = bc * pr;
                Console.WriteLine("El calculo de deduccion de el ARL es: " + arl);
                double srm = sm - pen - eps - arl;
                Console.WriteLine("El salario real mensual es: " + srm);
                double sa = srm * 12;
                Console.WriteLine("El salario anualcon deducciones es: " + sa);
            }
        }
    }
}
