using System;
using System.Collections.Generic;
namespace C_Teste.classes
{

    class tremController
    {
        private  Stack<int> pilha = new Stack<int>();
        
        
        
       public  void atracarLadoEsquerdo(int n)
        {
            this.pilha.Push(n);
            Console.Clear();
             
            Console.WriteLine("Vagão "+n+" inserido com sucesso");
        }
       public  void DesatracarLadoEsquerdo()
        {
           
              this.pilha.Pop();
              Console.Clear();     
              Console.WriteLine("Vagão Retirado com sucesso");
            
            
        }
       public  void atracarLadoDireiro(int n)
        {
             int[]aux2 =this.pilha.ToArray();

              this.pilha.Clear();
              this.pilha.Push(n);

               for (int i = aux2.Length-1; i  >= 0; i--)
              {
                 this.pilha.Push(aux2[i]);
              }
               
            Console.WriteLine("Vagão "+n+" inserido com sucesso"); 
        }

        public  void DesatracarLadoDireito()
        {
                int[]aux2 =this.pilha.ToArray();
                List<int> lista= new List<int>();
                int x=-1;

                    foreach (var item in this.pilha)
                    {
                        lista.Add(item);
                        x=item; 
                    }
            lista.Remove(x);// remove pelo lado direito
            this.pilha.Clear();  

                    for (int i = lista.Count-1; i  >= 0; i--)
                    {
                        this.pilha.Push(lista[i]);
                    }       
         }

        public Stack<int> exibirTrem() => this.pilha;

        
        
        public int[] countNuber(int[] arr)
        {
                Array.Sort(arr); 
                int contador=0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if(arr[i]< arr.Length)
                        {
                            contador++;
                        }
                        
                    }
                     Console.WriteLine("Existe "+contador+" Elementos menores do que tamanho do array");
            return arr;
        }


        
    }

}