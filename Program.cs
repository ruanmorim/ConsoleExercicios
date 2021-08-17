using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite algum Nome :");
            var nome = Console.ReadLine();
           
            Console.WriteLine("Você quer as letras de forma ordenada em 'par' digite p ou 'impar' digite t?");
            var escolha = Console.ReadLine();
            
            var p = "par";
            var t = "impar";

            if (escolha.Equals(p)){
                for (int i=0; i < nome.Length; i++)
                {
                    if  (i%2 == 0)
                    {
                        String a = nome.Substring(i,1);
                        Console.WriteLine($" {a}");
                    }
                }
            }
            else if (escolha.Equals(t)) 
            {
                for (int i=0;i<nome.Length;i++)
                {
                    if(i%2!=0)
                    {
                        String a = nome.Substring(i,1);
                        Console.WriteLine($" {a}");
                    }
                }
            }
                    
        }
    }
}