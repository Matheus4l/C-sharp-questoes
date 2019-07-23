using System;
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
                    Console.WriteLine("4-Sair do Programa");
                
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
                                Console.WriteLine("Case 2");
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
                                Console.WriteLine("Até a Proxima !3");
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
