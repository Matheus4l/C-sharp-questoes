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
         public  Stack<int> exibirTrem()
        {
           
            return this.pilha;  
        }

        public Array countNuber(Array arr){
                Array.Sort(arr); 
            return arr;
        }
        
    }

}