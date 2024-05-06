using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace prova
{
    public class Leao : Animal
    {
        private string nome;
        public string Name {
        get { return nome; }
        set {nome = value; }
        }
        public Leao()
        {
            nome = "leao";
        }

        public  override void Comer(){
            Console.WriteLine("raw raw raw");
        }
    }
}