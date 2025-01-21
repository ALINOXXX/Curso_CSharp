namespace EX009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;
            Console.Write("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA == ladoB) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))

            {
                Console.WriteLine("os valores informados formam um triângulo.");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("os valores formam um triângulo equilátero");
                }
                else if ((ladoA == ladoB) || (ladoA == ladoC) || (ladoB == ladoC))
                {
                    Console.WriteLine("Ele é um triângulo isósceles.");
                }
                else
                {
                    Console.WriteLine("Ele é um triângulo escaleno.");
                }

            }
            else 
            { Console.WriteLine("os valores informado formam um triângulo."); 
            }
        }
    }
}
