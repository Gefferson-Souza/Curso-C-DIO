using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Curso_C_DIO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public object Info { get; set; }
        public bool PossuiImovel { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"Olá! meu nome é {Nome}, tenho {Idade} anos.");
        }
    }
}