

namespace TesteCalcularIMC
{
    public static class IMC
    {
        public static double CalcularIMC(double peso, double altura)
        {
            return Math.Round((peso / (Math.Pow(altura, 2.0))), 2);
        }

        public static string ClassificarIMC(double imc)
        {
            var Classificacao = "";

            if (imc < 18.5)
            {
                Classificacao = "Abaixo do normal";
            }
            else if (imc <= 24.9)
            {
                Classificacao = "Peso Normal";
            }
            else if (imc <= 29.9)
            {
                Classificacao = "Sobrepeso";
            }
            else if (imc <= 34.9)
            {
                Classificacao = "Obesidade Grau I";
            }
            else if (imc <= 39.9)
            {
                Classificacao = "Obesidade Grau II";
            }
            else
            {
                Classificacao = "Obesidade Grau III";
            }

            return Classificacao;
        }
    }
}
