namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.Write("digite a primeira  nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a primeira  nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a primeira  nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("digite a primeira  nota: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2+n3 + n4) / 4;

            nota_final = Convert.ToDouble(Console.ReadLine());
            if (nota_final >= 70)
            {
                resultado = "Aprovado";
                if (nota_final >= 95)
                {

                    resultado = "Aprovado com louvor";
                }
                
            }

            else if (nota_final >= 45)
            { resultado = "Recuperação"; }
            else 
            {
                resultado = "Reprovado";

            }

            Console.WriteLine("nota do aluno {0} - Resultado: {1}", nota_final, resultado );



        }
    }
}
