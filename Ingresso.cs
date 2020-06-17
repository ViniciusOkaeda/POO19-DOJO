using System;
namespace AULA19DOJOFIX2
{
    public class Ingresso
    {
        public float IngressoPreco { get; set;}


        public void ImprimirValor(){
            System.Console.WriteLine("O valor do ingresso é R$ " + IngressoPreco);
        }
    }
}