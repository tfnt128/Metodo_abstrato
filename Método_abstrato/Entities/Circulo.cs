using System;
namespace Método_abstrato.Entities
{
    class Circulo : Forma
    {
        //Declarando a variavel 
        public double Raio { get; set; }

        //Criando construtor peronalizado com herança da classe "Forma"
         public Circulo(double raio, Color cor) : base(cor)
        {
            Raio = raio;
        }

        //método abstrato da classe "Forma"
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
