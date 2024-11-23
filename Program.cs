internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            Console.WriteLine("Calculadora");

            Console.WriteLine("Primeiro Número");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha o Sinal: +, -, *, /");
            var sinal = Console.ReadLine();

            Console.WriteLine("Segundo Número Número");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;


            if (sinal == "+")
            {
                resultado = numero1 + numero2;
                Console.WriteLine(numero1 + sinal + numero2 + "=" + resultado);
            }
            else if (sinal == "-")
            {
                resultado = numero1 - numero2;
                Console.WriteLine(numero1 + sinal + numero2 + "=" + resultado);
            }
            else if (sinal == "*")
            {
                resultado = numero1 * numero2;
                Console.WriteLine(numero1 + sinal + numero2 + "=" + resultado);
            }
            else if (sinal == "/")
            {

                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine(numero1 + sinal + numero2 + "=" + resultado);
                }
                else
                {
                    Console.WriteLine("Divisão por zero!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("ERRO!");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}