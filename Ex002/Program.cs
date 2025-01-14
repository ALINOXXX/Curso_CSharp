namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = -45;
            float num = 4.58f;
            char letra = 'c';
            string nome = "Aline";

            Console.WriteLine("0 número é {0}",numero);
            Console.WriteLine("o valor é R${0}",num);
            Console.WriteLine("qual é a letra do alfabeto {0}",letra);   
            Console.WriteLine("qual o seu nome {0}", nome);
            Console.WriteLine("o numero é {0}, o valor é R$ {1} , a letra é {2} e o seu nome é {3}." ,numero, num, letra, nome);

        }
     }
}
