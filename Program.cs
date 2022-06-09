using System;

namespace Switch_case
{
     class Program
    {
        static void Main()
        {
            int tempo = 0;
            char escolha;
            
            inicio: //goto
            Console.Clear();

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
                Console.WriteLine("\nPara o transporte escolhido o tempo é: {0} minutos.", tempo);
            }
            //pra continuar o calculo Volta ao inicio do codigo
            Console.Write("\nCalcular outro transporte? [s/n]: ");
            escolha = Char.Parse(Console.ReadLine());
            if (escolha=='s'|| escolha=='S'){
                goto inicio;
            }else{
                Console.Clear();
                Console.WriteLine("Fim do programa");
            }
        }
    }
}