using System;

namespace Agencia_de_viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Agencia de viagens");

            string[] nome =  new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] data = new DateTime[5];

            int opcao = 0;
            int contador = 0;

            do
        {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Cadastrar passagem");
            Console.WriteLine("2 - Listar passagens");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                Console.WriteLine("Vamos Cadastrar Agora");
                break;
                case 2:
                Console.WriteLine("Listando as passagens");
                break;
                case 0:
                Console.WriteLine("Obrigado por usar nosso sistema");
                break;
                default:
                Console.WriteLine("opção invalida");
                break;
        }//fim switch
    }   while (opcao != 0);

    switch(1){
        case 1:
        System.Console.WriteLine("vamos cadastrar agora");
        string resposta = "";
        do{
            if(contador< 2){
            Console.WriteLine("Digite o nome do passageiro");
            nome[contador] = Console.ReadLine();

            Console.WriteLine("Digite a origem");
            origem[contador] = Console.ReadLine();

            Console.WriteLine("Digite o destino");
            destino[contador] = Console.ReadLine();

            Console.WriteLine("Digite a Data");
            data[contador] = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Você deseja cadastrar mais um? s/n");
            contador++;
        }else{
            Console.WriteLine("Número de passagens excedida");
            break;
        }
        } while(resposta =="S");
        break;
        case 2:
        Console.WriteLine("Listando as passagens");
        int contadorB = 0;
        while (contadorB < 2)
        {
            Console.WriteLine($"Passageiro nome: {nome[contadorB]}, origem: {origem[contador]}");
            contadorB++;
        }break;
        case 0:
        Console.WriteLine("Obrigadoo por usar nosso sistema");
        break; 
        default:
        
        Console.WriteLine("Opção iválida");
        break;
    
    } while (opcao != 0);
    //fim switch
    
        
    


        }
    }
}
