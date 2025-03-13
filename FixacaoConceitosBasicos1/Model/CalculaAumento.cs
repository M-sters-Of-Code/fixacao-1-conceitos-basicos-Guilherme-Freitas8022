using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
     public class CalculaAumento
    {
        public static double Calcular(double salario, double aumento)
        {
            return salario + aumento; // Retorna o salário com o aumento aplicado
        }
    }
