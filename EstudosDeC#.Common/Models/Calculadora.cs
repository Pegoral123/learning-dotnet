namespace EstudosDeC.Common.Models
{
    public class Calculadora
    {
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return 0;
            }
            return x / y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public void Cosseno(int angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double Cosseno = Math.Cos(radiano);
            Console.WriteLine($"O cosseno do ângulo de {angulo} graus é: {Math.Round(Cosseno, 4)} ");

        }

        public void Tangente(int angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"O cosseno do ângulo de {angulo} graus é: {Math.Round(tangente, 4)} ");

        }

        public void Seno(int angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"O cosseno do ângulo de {angulo} graus é: {Math.Round(seno, 4)} ");

        }

        public void RaizQuadrada(double num)
        {
            double raiz = Math.Sqrt(num);
            Console.WriteLine($"A raiz quadrada de {num} é: {Math.Round(raiz)} ");
        }
    }

}