using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
   public class CalculaAluguelCarro
    {
        public static double Calcular(int dias, int quilometragemInicial, int quilometragemFinal)
        {
            double valorDiario = 50.0; // Exemplo de valor diário de aluguel
            double valorPorKm = 0.20;  // Exemplo de valor por quilômetro

            int kmRodado = quilometragemFinal - quilometragemInicial;

            double custoTotal = (dias * valorDiario) + (kmRodado * valorPorKm);

            return custoTotal; // Retorna o valor total do aluguel
        }
    }
}
