using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorProject.PlanDePensiones
{
    public class PedirDatos
    {
        public static void Preguntas()
        {
            Console.WriteLine("¿Cuál es tu base imponible?");
            double baseImponible = double.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de persona física? ");
            double pensionPersona = double.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuál es la aportación a tu plan de pensiones de empresa? ");
            double pensionEmpresa = double.Parse(Console.ReadLine());

            Console.WriteLine("Plan de pensiones en España o Andorra");
            String pais = Console.ReadLine().ToLower();


            if (pais == "andorra" || pais == "españa")
            {
                var datos = new DatosFinancieros(baseImponible, pensionPersona, pensionEmpresa, pais);

                var dineroInvertido = CalculosFinancieros.totalInversion(datos.PensionPersona, datos.PensionEmpresa);

                var desgravacion = 0d;
                if (pais == "andorra")
                    desgravacion = CalculosFinancieros.desgravacionAndo(datos.BaseImponible, dineroInvertido);
                else
                    desgravacion = CalculosFinancieros.desgravacionEspa(datos.BaseImponible, dineroInvertido);

                Console.WriteLine("Total del dinero desgravado es: " + desgravacion);
            }
            else
                Console.WriteLine("Pais no valido");
        }
    }

}
