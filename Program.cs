using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Coletar nome
            //Validar nome != nulo

            //Coletar idade
            //Validar idadr = 0<100

            //coletar salario
            //Validar salario >0

            //coletar Estado civil (s = solteiro), (c = casado), (v = viuvo), (d = divorciado);

            string nome;
            int idade;
            float salario;
            char EstadoCivil;

            Console.WriteLine($"Ola, qual seu nome ?");
            nome = (Console.ReadLine().Trim(' '));

            while (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine($"Insira um nome valido");
                nome = (Console.ReadLine().Trim(' '));
            }

            Console.WriteLine($"Qual sua idade ?");
            idade = int.Parse(Console.ReadLine());

            while (idade <0 && idade <=100)
            {
                Console.WriteLine($"insira uma idade valida");
                idade = int.Parse(Console.ReadLine()); 
            }

            Console.WriteLine($"Qual seu salario ?");
            salario = float.Parse(Console.ReadLine());

            while (salario <0)
            {
                Console.WriteLine($"insira um salario valido");
                salario = float.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"Qual seu Estado-Civil ?\n(S = solteiro), (C = casado), (V = viuvo), (D = divorciado)");
            EstadoCivil = char.Parse(Console.ReadLine().ToLower());

            while (EstadoCivil != 's' || EstadoCivil != 'c' || EstadoCivil != 'v' || EstadoCivil != 'd')
            {
                Console.WriteLine($"insira um Estado-Civil valido\n(S = solteiro), (C = casado), (V = viuvo), (D = divorciado)");
                EstadoCivil = char.Parse(Console.ReadLine().ToLower());
            }
            
            
            
                
                
        }
    }
}

