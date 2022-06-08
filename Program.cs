using System;

namespace Switch_case
{
     class Program
    {
        static void Main()
        {
            int tempo = 0;
            char escolha;
            
            // v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nA viagem de Belo Horizonte/BH a Vitoria/ES em minutos: ");
            Console.Write("Escolha o transporte: [a]Avião | [c]Carro | [o]Ônibus : ");
            escolha = Convert.ToChar(Console.ReadLine());
        
            switch (escolha)
            {
                case 'a':
                    tempo = 50;
                    break;
                case 'c':
                    tempo = 480;
                    break;
                case 'o':
                    tempo = 660;
                    break;
                default:
                    tempo = 1;
                    break;

            }

            if(tempo<0)
            {
                Console.WriteLine("Transporte indisponivel");
            }else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0}", tempo);
            }
        }
    }
}