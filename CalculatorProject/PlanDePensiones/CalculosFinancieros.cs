using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.PlanDePensiones
{
    public class CalculosFinancieros
    {
   
        public static double totalInversion(double pensionPersona, double pensionEmpresa)
        {
            return pensionPersona + pensionEmpresa;
        }
        public static double desgravacionAndo(double baseImponible, double dineroInvertido)
        {
            if (baseImponible < 24000d)
                return 0d;

            else if (baseImponible < 40000d)
                return dineroInvertido * 0.05d;

            else
                return dineroInvertido * 0.1d;
        }
        public static double desgravacionEspa(double baseImponible, double dineroInvertido)
        {

            if (baseImponible < 12450d)
                return dineroInvertido * 0.19d;

            else if (baseImponible < 20200d)
                return dineroInvertido * 0.24d;

            else if (baseImponible < 35200d)
                return dineroInvertido * 0.3d;

            else if (baseImponible < 60000d)
                return dineroInvertido * 0.37d;

            else if (baseImponible < 300000d)
                return dineroInvertido * 0.45d;

            else
                return dineroInvertido * 0.47d;

        }

    }
}
