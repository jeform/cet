using System;

namespace CET
{
    public class Cet
    {
        public double CalcularCet(
           double valorFinanciado,
           double valorParcela,
           int prazo,
           DateTime dataContrato,
           DateTime dataPrimeiroVencimento)
        {
            double valorMaximoCet = 10000;
            double precisaoCalculo = 0.00001;
            double cet = 0;

            while (true)
            {
                DateTime c = new DateTime();
                DateTime dj = new DateTime();
                double total = 0.0;

                for (int j = 0; j < prazo; j++)
                {
                    dj = dataPrimeiroVencimento;
                    if (j != 0)
                    {
                        c = dataPrimeiroVencimento;
                        dj = c.AddMonths(j);
                    }
                    double days = (dj - dataContrato).Days;
                    total += valorParcela / Math.Pow(1 + cet, days / 365);
                }

                cet += precisaoCalculo;

                if (cet >= valorMaximoCet)
                {
                    return -1;
                }
                if (total - valorFinanciado <= 0)
                {
                    break;
                }
                else
                {
                    cet *= total / valorFinanciado;
                }
            }

            return cet * 100;
        }
    }
}
