using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escolha_de_Combustível
{
    public abstract class CalculoCombustivel
    {
        public static string CalcularCombustivel(double ValorEtanol, double ValorGasolina, double Consumo)
        {
            if (ValorEtanol < (ValorGasolina * Consumo))
            {
                return "O combustível ideal é o Etanol";
            }
            else if ((ValorEtanol * Consumo) == (ValorGasolina * Consumo))
            {
                return "O combustível pode ser Gasolina ou Etanol";

            } else {
                return "O combustível ideal é a Gasolina";
            }
        }

        public static double CalcularConsumo(double ConsumoEtanol, double ConsumoGasolina)
        {
            return ConsumoEtanol / ConsumoGasolina;
        }
    }
}

