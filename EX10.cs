namespace EX10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento;

            Console.WriteLine("Digie o salário");

            salario = double.Parse(Console.ReadLine());

            if (salario == 2500)
            { 
                aumento = (salario * 0.05) + salario;
            }
            else if (salario > 1250)
            {  aumento = (salario * 0.1) +salario;
            }
            else { aumento = salario * 0.15 + salario;
            }
            Console.WriteLine("o salário final será {0}.", aumento);
        }
    }
}
,