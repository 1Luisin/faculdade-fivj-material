using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Filme
    {
        public string nome;
        public string tipo;
        public string data;
        public string estudio;

       static public void Executar() 
        {
            Filme filme = new Filme();
            Console.WriteLine("Rodando Filme: {0}", filme.nome);
            Console.WriteLine("Data do Filme: {0}", filme.data);
            Console.WriteLine("Estúdio do Filme: {0}", filme.estudio);
        
        }
    
        public void Pausar() 
        {
        
        
        }
    }
}
