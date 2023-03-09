using System;
using System.Globalization;

namespace Pergunta4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;
            double total = sp + rj + mg + es + outros;

            double percentageSp = (sp / total) * 100;
            double percentageRj = (rj / total) * 100;
            double percentageMg = (mg / total) * 100;
            double percentageEs = (es / total) * 100;
            double percentageOutros = (outros / total) * 100;

            Console.WriteLine();
            Console.WriteLine("Porcentagem de São Paulo: " + percentageSp.ToString("F2", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Porcentagem do Rio de Janeiro: " + percentageRj.ToString("F2", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Porcentagem de Minas Gerais: " + percentageMg.ToString("F2", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Porcentagem do Espírito Santo: " + percentageEs.ToString("F2", CultureInfo.InvariantCulture) + "%");
            Console.WriteLine("Porcentagem de outros estados: " + percentageOutros.ToString("F2", CultureInfo.InvariantCulture) + "%");

        }
    }
}
