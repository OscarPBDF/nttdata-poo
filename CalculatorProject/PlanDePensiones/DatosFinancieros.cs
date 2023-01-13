using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CalculatorProject.PlanDePensiones
{
    public class DatosFinancieros
    {
        public double BaseImponible { get; set; }
        public double PensionPersona { get; set; }
        public double PensionEmpresa { get; set; }
        public String Pais { get; set; }
        public DatosFinancieros()
        { 
        
        }

        public DatosFinancieros(double baseImponible, double pensionPersona, double pensionEmpresa, String pais)
        {
            BaseImponible = baseImponible;
            PensionPersona = pensionPersona;
            PensionEmpresa = pensionEmpresa;
            Pais = pais;
        }
    }
}
