using System;
using System.Collections.Generic;
using C_Teste.classes;
namespace C_Teste
{
    class Program
    {
      
      

      
      
        static void Main(string[] args)
        {
            int op; //auxilia na escolha do menu
            var trem = new tremController() ;
            bool exec=true;// inicia o programa

          while (exec==true)
            {
                
                Console.WriteLine("\n-----------------Menu-----------");
                    Console.WriteLine("1-Atracar Vagão");
                    Console.WriteLine("2-Desatracar Vagão");
                    Console.WriteLine("3-Visualizar Vagão");
                    Console.WriteLine("4-Ir Para o Desafio 2");
                    Console.WriteLine("5-Sair do Programa");
                
                op  = Convert.ToInt32(Console.ReadLine()); //op recebe convertido para inteiro um valor digidado 
                
                    switch (op)
                        {
                            case 1:
                                Console.Clear();

                                Console.WriteLine("1-Atracar Vagão pela esquerda ");
                                Console.WriteLine("2-Atracar Vagão pela Direita ");
                                  int lado=Convert.ToInt32(Console.ReadLine());
                                  Console.Clear();
                                       if (lado==1)
                                       {
                                           Console.WriteLine("Digite o numero do vagão para atracar ");
                                           trem.atracarLadoEsquerdo(Convert.ToInt32(Console.ReadLine())); //envia pra pilha o valor digitado np teclado 
                                       }else if(lado==2)
                                       {
                                          Console.WriteLine("Digite o numero do vagão para atracar ");
                                           trem.atracarLadoDireiro(Convert.ToInt32(Console.ReadLine())); //envia pra pilha o valor digitado np teclado  
                                       }else{
                                           Console.WriteLine("Erro1 ");
                                       }
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("1-Desatracar Vagão pela esquerda ");
                                Console.WriteLine("2-Desatracar Vagão pela Direita ");
                                  int lado2=Convert.ToInt32(Console.ReadLine());
                                  Console.Clear();
                                       if (lado2==1)
                                       {
                                          
                                           trem.DesatracarLadoEsquerdo(); 
                                       }else if(lado2==2)
                                       {
                                          
                                           trem.DesatracarLadoDireito(); 
                                       }else{
                                           Console.WriteLine("Erro1 ");
                                       }
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Trem");
                                var stack=trem.exibirTrem();
                                string row = "|";
                                foreach (int i in stack)
                                    {
                                        row +=i+"|";
                                    }
                                    Console.WriteLine(row);
                                break;
                            case 4:
                                Console.Clear();
                                  List<int> list = new List<int>();
                                  Console.WriteLine("----------Count Number----------");
                                  bool exec2 =true;
                                    while ( exec2==true)
                                    {   
                                         Console.WriteLine("Insirir numero \t");
                                         list.Add( Convert.ToInt32(Console.ReadLine()) );
                                         Console.WriteLine("Continuar Inserindo Sim[1] Não[2]\t");
                                         string condicaoParada = Console.ReadLine();
                                           if( condicaoParada=="2"){exec2=false;}

                                    }
                                        Console.Clear();
                                        int[] arrays= list.ToArray();
                                        var  vetor= trem.countNuber(arrays);
                                        string rows = "|";
                                            foreach (int i in vetor)
                                            {
                                                rows +=i+"|";
                                            }
                                           
                                            Console.WriteLine(rows);

                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Até a Proxima !");
                                exec=false;
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Default case");
                                break;
                        }
            }
            
            
           
        } 

            
    }
}
