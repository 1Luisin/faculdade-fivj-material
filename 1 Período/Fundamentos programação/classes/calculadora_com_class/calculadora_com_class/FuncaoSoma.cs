using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_com_class
{
    internal class FuncaoSoma
    {
    
        public void Soma(double soma1, double soma2)
        {

            Console.WriteLine("Digite um número");
            soma1 = Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Digite um número");   
            soma2 = Convert.ToInt32(Console.ReadLine());
            double resultado_soma;
            resultado_soma = soma1 + soma2;


                         
                
             

        }
    
    }
}
