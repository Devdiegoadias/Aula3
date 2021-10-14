using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operador ! (NEGAÇÃO)
            bool variavel = false;
            Console.WriteLine(!variavel); //Retorna True
            Console.WriteLine(!true);     //Retorna False

            //Operador && (AND)
            int idade;
            bool idadeValida;

            Console.WriteLine("Digita sua idade:");
            idade = int.Parse(Console.ReadLine());

            idadeValida = idade >= 0 && idade <= 120;

            Console.WriteLine(idadeValida.ToString());

            //Operador || (OU)
            int temperatura;
            bool temperaturaInvalida;

            Console.WriteLine("Qual temperatura a água está em estado líquido?");
            temperatura = int.Parse(Console.ReadLine());
            temperaturaInvalida = (temperatura < 0) || (temperatura > 100);

            Console.WriteLine(temperaturaInvalida.ToString());
        }
    }
}
